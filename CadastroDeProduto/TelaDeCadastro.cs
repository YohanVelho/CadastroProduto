﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeProduto
{
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
            Conection con = new Conection();
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = con.Select();
        }

        private void gridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                txtID.Text = gridProdutos.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtNome.Text = gridProdutos.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            }
        }
    }
}
