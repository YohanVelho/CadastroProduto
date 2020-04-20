using System.Windows.Forms;

namespace CadastroDeProduto
{
    partial class TelaDeCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIcms = new System.Windows.Forms.Label();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtICMS = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.comboBox_Filtros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClassificacao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBarras = new System.Windows.Forms.ComboBox();
            this.btnAdicionarCodigoBarra = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(10, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(91, 12);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(172, 12);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 8;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(10, 127);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(54, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(34, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(135, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(637, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(94, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 40;
            this.lblNome.Text = "Nome";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(32, 58);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 501;
            this.lblId.Text = "Id";
            // 
            // lblIcms
            // 
            this.lblIcms.AutoSize = true;
            this.lblIcms.Location = new System.Drawing.Point(429, 96);
            this.lblIcms.Name = "lblIcms";
            this.lblIcms.Size = new System.Drawing.Size(33, 13);
            this.lblIcms.TabIndex = 403;
            this.lblIcms.Text = "ICMS";
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Location = new System.Drawing.Point(32, 96);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(80, 13);
            this.lblPrecoCusto.TabIndex = 503;
            this.lblPrecoCusto.Text = "Preço de Custo";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Location = new System.Drawing.Point(113, 92);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(75, 20);
            this.txtPrecoCusto.TabIndex = 2;
            this.txtPrecoCusto.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecoCusto_Validating);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(305, 92);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(75, 20);
            this.txtPrecoVenda.TabIndex = 3;
            this.txtPrecoVenda.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecoVenda_Validating);
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(215, 96);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(84, 13);
            this.lblPrecoVenda.TabIndex = 503;
            this.lblPrecoVenda.Text = "Preço de Venda";
            // 
            // txtICMS
            // 
            this.txtICMS.Location = new System.Drawing.Point(468, 92);
            this.txtICMS.Name = "txtICMS";
            this.txtICMS.Size = new System.Drawing.Size(75, 20);
            this.txtICMS.TabIndex = 4;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(97, 128);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(511, 20);
            this.txtPesquisar.TabIndex = 10;
            // 
            // gridProdutos
            // 
            this.gridProdutos.AllowUserToAddRows = false;
            this.gridProdutos.AllowUserToDeleteRows = false;
            this.gridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Location = new System.Drawing.Point(10, 177);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.ReadOnly = true;
            this.gridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdutos.Size = new System.Drawing.Size(762, 372);
            this.gridProdutos.TabIndex = 20;
            this.gridProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellContentClick_1);
            this.gridProdutos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellContentClick_1);
            // 
            // comboBox_Filtros
            // 
            this.comboBox_Filtros.DisplayMember = "SelecionarPreco";
            this.comboBox_Filtros.FormattingEnabled = true;
            this.comboBox_Filtros.Items.AddRange(new object[] {
            "Pesquisar por id",
            "Pesquisar por nome",
            "Pesquisar por preço de custo",
            "Pesquisar por preço de venda",
            "Pesquisar por classificação",
            "Pesquisar por icms"});
            this.comboBox_Filtros.Location = new System.Drawing.Point(614, 128);
            this.comboBox_Filtros.Name = "comboBox_Filtros";
            this.comboBox_Filtros.Size = new System.Drawing.Size(158, 21);
            this.comboBox_Filtros.TabIndex = 504;
            this.comboBox_Filtros.Text = "Filtros";
            this.comboBox_Filtros.ValueMember = "Selecionar por preço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 403;
            this.label1.Text = "Classificação";
            // 
            // comboBoxClassificacao
            // 
            this.comboBoxClassificacao.DisplayMember = "SelecionarPreco";
            this.comboBoxClassificacao.FormattingEnabled = true;
            this.comboBoxClassificacao.Items.AddRange(new object[] {
            "Alimentos",
            "Cigarros",
            "Bebidas"});
            this.comboBoxClassificacao.Location = new System.Drawing.Point(675, 92);
            this.comboBoxClassificacao.Name = "comboBoxClassificacao";
            this.comboBoxClassificacao.Size = new System.Drawing.Size(97, 21);
            this.comboBoxClassificacao.TabIndex = 5;
            this.comboBoxClassificacao.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxClassificacao_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 403;
            this.label2.Text = "Código de Barras";
            // 
            // comboBoxBarras
            // 
            this.comboBoxBarras.FormattingEnabled = true;
            this.comboBoxBarras.Location = new System.Drawing.Point(675, 13);
            this.comboBoxBarras.Name = "comboBoxBarras";
            this.comboBoxBarras.Size = new System.Drawing.Size(97, 21);
            this.comboBoxBarras.TabIndex = 505;
            // 
            // btnAdicionarCodigoBarra
            // 
            this.btnAdicionarCodigoBarra.Location = new System.Drawing.Point(432, 11);
            this.btnAdicionarCodigoBarra.Name = "btnAdicionarCodigoBarra";
            this.btnAdicionarCodigoBarra.Size = new System.Drawing.Size(143, 23);
            this.btnAdicionarCodigoBarra.TabIndex = 506;
            this.btnAdicionarCodigoBarra.Text = "Adicionar Código de Barra";
            this.btnAdicionarCodigoBarra.UseVisualStyleBackColor = true;
            this.btnAdicionarCodigoBarra.Click += new System.EventHandler(this.btnAdicionarCodigoBarra_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(132, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(93, 13);
            this.lbl1.TabIndex = 507;
            this.lbl1.Text = "*Nome em Branco";
            this.lbl1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Red;
            this.lbl2.Location = new System.Drawing.Point(302, 76);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(115, 13);
            this.lbl2.TabIndex = 507;
            this.lbl2.Text = "*Preço de venda vazio";
            // 
            // TelaDeCadastro
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnAdicionarCodigoBarra);
            this.Controls.Add(this.comboBoxBarras);
            this.Controls.Add(this.comboBoxClassificacao);
            this.Controls.Add(this.comboBox_Filtros);
            this.Controls.Add(this.gridProdutos);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrecoCusto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIcms);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtICMS);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.MaximizeBox = false;
            this.Name = "TelaDeCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIcms;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtICMS;
        private System.Windows.Forms.TextBox txtPesquisar;
        public System.Windows.Forms.DataGridView gridProdutos;
        private ComboBox comboBox_Filtros;
        private Label label1;
        private ComboBox comboBoxClassificacao;
        private Label label2;
        private ComboBox comboBoxBarras;
        private Button btnAdicionarCodigoBarra;
        private Label lbl1;
        private Label lbl2;
    }
}

