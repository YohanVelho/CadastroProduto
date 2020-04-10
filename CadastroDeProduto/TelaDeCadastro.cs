﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CadastroDeProduto
{
    public partial class TelaDeCadastro : Form
    {
        private int rowIndex = -1;
        Conection con = new Conection();

        public TelaDeCadastro()
        {
            InitializeComponent();
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = con.Select();
        }


        private void gridProdutos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtID.Text = gridProdutos.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = gridProdutos.CurrentRow.Cells[1].Value.ToString();
                txtPrecoCusto.Text = gridProdutos.CurrentRow.Cells[2].Value.ToString();
                txtPrecoVenda.Text = gridProdutos.CurrentRow.Cells[3].Value.ToString();
                txtICMS.Text = gridProdutos.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            con.Cadastro(int.Parse(txtID.Text), txtNome.Text, double.Parse(txtPrecoCusto.Text), double.Parse(txtPrecoVenda.Text), int.Parse(txtICMS.Text));
            txtID.Text = txtNome.Text = txtPrecoCusto.Text = txtPrecoVenda.Text = txtICMS.Text = null;
            gridProdutos.DataSource = con.Select();
            rowIndex = -1;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtID.Text == null)
            {
                MessageBox.Show("Selecione um produto para ser excluído.");
                return;
            }
            else
            {
                try
                {
                    con.conn.Open();
                    con.sql = @"delete from produtos where pro_id = (:id)";
                    con.cmd = new NpgsqlCommand(con.sql, con.conn);
                    con.cmd.Parameters.AddWithValue("id", int.Parse(txtID.Text));
                    con.cmd.ExecuteReader();
                    MessageBox.Show("Produto excluído com sucesso!");
                    con.conn.Close();
                }
                catch (Exception ex)
                {
                    con.conn.Close();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = con.Select();
            txtID.Text = txtNome.Text = txtPrecoCusto.Text = txtPrecoVenda.Text = txtICMS.Text = null;
            rowIndex = -1;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
            {
                MessageBox.Show("Selecione um produto para ser atualizado.");
            }
            else
            {
                con.Atualizar(int.Parse(txtID.Text), txtNome.Text, double.Parse(txtPrecoCusto.Text), double.Parse(txtPrecoVenda.Text), int.Parse(txtICMS.Text));
            }
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = con.Select();
            txtID.Text = txtNome.Text = txtPrecoCusto.Text = txtPrecoVenda.Text = txtICMS.Text = null;
            rowIndex = -1;
        }
    }
}

