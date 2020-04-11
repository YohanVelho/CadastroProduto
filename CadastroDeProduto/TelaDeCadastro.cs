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
        public static string id;
        public static string nome;

        public TelaDeCadastro()
        {
            InitializeComponent();
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = con.Select();
            txtID.Enabled = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
        }


        private void gridProdutos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtID.Text = txtNome.Text = txtPrecoCusto.Text = txtPrecoVenda.Text = comboBoxClassificacao.Text = txtICMS.Text = comboBoxBarras.Text = null;
                txtID.Text = gridProdutos.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = gridProdutos.CurrentRow.Cells[1].Value.ToString();
                txtPrecoCusto.Text = gridProdutos.CurrentRow.Cells[2].Value.ToString();
                txtPrecoVenda.Text = gridProdutos.CurrentRow.Cells[3].Value.ToString();
                comboBoxClassificacao.Text = gridProdutos.CurrentRow.Cells[4].Value.ToString();
                txtICMS.Text = gridProdutos.CurrentRow.Cells[5].Value.ToString();
                comboBoxBarras.DisplayMember = "pb_codigodebarra";
                comboBoxBarras.DataSource = con.CodBarras(int.Parse(txtID.Text));

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtPrecoCusto.Text == null || txtPrecoCusto.Text == "")
            {
                txtPrecoCusto.Text = "0.0";
                MessageBox.Show("O preço de custo está vazio");
            }if (txtICMS.Text == null || txtICMS.Text == "")
            {
                txtICMS.Text = "0";
                MessageBox.Show("O ICMS está vazio");
            }
            if(comboBoxClassificacao.Text == null || comboBoxClassificacao.Text == "")
            {
                comboBoxClassificacao.Text = "Vazio";
                MessageBox.Show("A Classificação está vazia");
            }
            con.Cadastro(txtNome.Text, double.Parse(txtPrecoCusto.Text), double.Parse(txtPrecoVenda.Text), comboBoxClassificacao.Text, int.Parse(txtICMS.Text));
            txtID.Text = txtNome.Text = txtPrecoCusto.Text = txtPrecoVenda.Text = comboBoxClassificacao.Text = txtICMS.Text = comboBoxBarras.Text = null;
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
                con.Deletar(int.Parse(txtID.Text));
            }
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = con.Select();
            txtID.Text = txtNome.Text = txtPrecoCusto.Text = txtPrecoVenda.Text = comboBoxClassificacao.Text = txtICMS.Text = comboBoxBarras.Text = null;
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
                con.Atualizar(int.Parse(txtID.Text), txtNome.Text, double.Parse(txtPrecoCusto.Text), double.Parse(txtPrecoVenda.Text), comboBoxClassificacao.Text, int.Parse(txtICMS.Text));
            }
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = con.Select();
            txtID.Text = txtNome.Text = txtPrecoCusto.Text = txtPrecoVenda.Text = comboBoxClassificacao.Text = txtICMS.Text = comboBoxBarras.Text = null;
            rowIndex = -1;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (comboBox_Filtros.Text == "Filtros")
            {
                MessageBox.Show("Selecione um Filtro.");
                return;
            }
            else if (comboBox_Filtros.Text == "Pesquisar por preço de custo")
            {
                gridProdutos.DataSource = null;
                gridProdutos.DataSource = con.SelectByPrecoCusto(double.Parse(txtPesquisar.Text)); ;
                rowIndex = -1;
            }
            else if (comboBox_Filtros.Text == "Pesquisar por id")
            {
                gridProdutos.DataSource = null;
                gridProdutos.DataSource = con.SelectById(int.Parse(txtPesquisar.Text)); ;
                rowIndex = -1;
            }
            else if (comboBox_Filtros.Text == "Pesquisar por nome")
            {
                gridProdutos.DataSource = null;
                gridProdutos.DataSource = con.SelectByName(txtPesquisar.Text); ;
                rowIndex = -1;
            }
            else if (comboBox_Filtros.Text == "Pesquisar por classificação")
            {
                gridProdutos.DataSource = null;
                gridProdutos.DataSource = con.SelectByClassification(txtPesquisar.Text); ;
                rowIndex = -1;
            }
            else if (comboBox_Filtros.Text == "Pesquisar por icms")
            {
                gridProdutos.DataSource = null;
                gridProdutos.DataSource = con.SelectByICMS(int.Parse(txtPesquisar.Text)); ;
                rowIndex = -1;
            }
            else if (comboBox_Filtros.Text == "Pesquisar por preço de venda")
            {
                gridProdutos.DataSource = null;
                gridProdutos.DataSource = con.SelectByPrecoVenda(double.Parse(txtPesquisar.Text)); ;
                rowIndex = -1;
            }
        }

        private void btnAdicionarCodigoBarra_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            nome = txtNome.Text;
            AdicionarCodigoBarra adicionarCodigoBarra = new AdicionarCodigoBarra();
            adicionarCodigoBarra.ShowDialog();
            gridProdutos.DataSource = null;
            gridProdutos.DataSource = con.Select();
            rowIndex = -1;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                lbl1.Visible = true;
            }
            else
            {
                lbl1.Visible = false;
            }
        }

        private void txtPrecoCusto_Validating(object sender, CancelEventArgs e)
        {

            double numero = 0;
            if (string.IsNullOrEmpty(txtPrecoCusto.Text.Trim()))
            {
            }
            else if (!(double.TryParse(txtPrecoCusto.Text.ToString(), out numero)))
            {
                MessageBox.Show("Digite apenas numeros");
                txtPrecoCusto.Text = null;
            }
            else if (double.Parse(txtPrecoCusto.Text) < 0)
            {
                MessageBox.Show("O valor não pode ser negativo");
                txtPrecoCusto.Text = null;
            }  
        }

        private void txtPrecoVenda_Validating(object sender, CancelEventArgs e)
        {
            double numero = 0;
            if (string.IsNullOrEmpty(txtPrecoVenda.Text.Trim()))
            {
                lbl2.Visible = true;
            }
            else if (!(double.TryParse(txtPrecoVenda.Text.ToString(), out numero)))
            {
                MessageBox.Show("Digite apenas numeros");
                txtPrecoVenda.Text = null;
                lbl2.Visible = false;
            }
            else if (double.Parse(txtPrecoVenda.Text) < 0)
            {
                MessageBox.Show("O valor não pode ser negativo");
                txtPrecoVenda.Text = null;
                lbl2.Visible = false;
            }
            else
            {
                lbl2.Visible = false;
            }

        }

        private void comboBoxClassificacao_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecoCusto.Text))
            {
                MessageBox.Show("Classificação em Branco");
            }

        }
    }
}

