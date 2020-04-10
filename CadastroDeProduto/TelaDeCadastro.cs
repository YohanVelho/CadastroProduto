using System;
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
            Conection con = new Conection();
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
            gridProdutos.DataSource = con.Select();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Selecione um produto para ser excluído!");
                    return;
            }
            else
            {
                try
                {
                    con.conn.Open();
                    con.sql = @"delete from produtos where pro_id = @ID";
                    NpgsqlCommand cmd = new NpgsqlCommand(con.sql, con.conn);
                    cmd.Parameters.AddWithValue("ID",int.Parse(gridProdutos.Rows[rowIndex].Cells["ID"].Value.ToString())); 
                    MessageBox.Show("Produto excluído com sucesso!");
                    rowIndex = -1;
                    con.conn.Close();
                }
                catch (Exception ex)
                {
                    con.conn.Close();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            con.Select();
        }
    }
}

