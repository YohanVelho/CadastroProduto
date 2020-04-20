using System;
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
    public partial class AdicionarCodigoBarra : Form
    {
        TelaDeCadastro tela = new TelaDeCadastro();
        Conection con = new Conection();

        public AdicionarCodigoBarra()
        {
            InitializeComponent();
            txtBarraId.Text = TelaDeCadastro.id;
            txtBarraNome.Text = TelaDeCadastro.nome;
        }

        private void btnBarraCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBarraSalvar_Click(object sender, EventArgs e)
        {
            con.CadastroBarra(int.Parse(txtBarraId.Text), int.Parse(txtBarraCodigo.Text));
            Close();
        }

        private void txtBarraCodigo_Validating(object sender, CancelEventArgs e)
        {
            double numero = 0;
            if (string.IsNullOrEmpty(txtBarraCodigo.Text.Trim()))
            {
            }
            else if (!(double.TryParse(txtBarraCodigo.Text.ToString(), out numero)))
            {
                MessageBox.Show("Digite apenas numeros");
                txtBarraCodigo.Text = null;
            }
            else if (double.Parse(txtBarraCodigo.Text) < 0)
            {
                MessageBox.Show("O código de barra não pode ser negativo");
                txtBarraCodigo.Text = null;
            }
        }
    }
}
