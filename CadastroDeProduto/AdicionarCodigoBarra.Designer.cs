namespace CadastroDeProduto
{
    partial class AdicionarCodigoBarra
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
            this.txtBarraId = new System.Windows.Forms.TextBox();
            this.txtBarraNome = new System.Windows.Forms.TextBox();
            this.txtBarraCodigo = new System.Windows.Forms.TextBox();
            this.lblBarraId = new System.Windows.Forms.Label();
            this.lblBarraNome = new System.Windows.Forms.Label();
            this.lblBarraCod = new System.Windows.Forms.Label();
            this.btnBarraSalvar = new System.Windows.Forms.Button();
            this.btnBarraCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBarraId
            // 
            this.txtBarraId.Location = new System.Drawing.Point(101, 31);
            this.txtBarraId.Name = "txtBarraId";
            this.txtBarraId.Size = new System.Drawing.Size(32, 20);
            this.txtBarraId.TabIndex = 0;
            // 
            // txtBarraNome
            // 
            this.txtBarraNome.Location = new System.Drawing.Point(101, 80);
            this.txtBarraNome.Name = "txtBarraNome";
            this.txtBarraNome.Size = new System.Drawing.Size(214, 20);
            this.txtBarraNome.TabIndex = 0;
            // 
            // txtBarraCodigo
            // 
            this.txtBarraCodigo.Location = new System.Drawing.Point(101, 133);
            this.txtBarraCodigo.Name = "txtBarraCodigo";
            this.txtBarraCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBarraCodigo.TabIndex = 0;
            this.txtBarraCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtBarraCodigo_Validating);
            // 
            // lblBarraId
            // 
            this.lblBarraId.AutoSize = true;
            this.lblBarraId.Location = new System.Drawing.Point(79, 35);
            this.lblBarraId.Name = "lblBarraId";
            this.lblBarraId.Size = new System.Drawing.Size(16, 13);
            this.lblBarraId.TabIndex = 1;
            this.lblBarraId.Text = "Id";
            // 
            // lblBarraNome
            // 
            this.lblBarraNome.AutoSize = true;
            this.lblBarraNome.Location = new System.Drawing.Point(60, 84);
            this.lblBarraNome.Name = "lblBarraNome";
            this.lblBarraNome.Size = new System.Drawing.Size(35, 13);
            this.lblBarraNome.TabIndex = 1;
            this.lblBarraNome.Text = "Nome";
            // 
            // lblBarraCod
            // 
            this.lblBarraCod.AutoSize = true;
            this.lblBarraCod.Location = new System.Drawing.Point(12, 137);
            this.lblBarraCod.Name = "lblBarraCod";
            this.lblBarraCod.Size = new System.Drawing.Size(83, 13);
            this.lblBarraCod.TabIndex = 1;
            this.lblBarraCod.Text = "Código de Barra";
            // 
            // btnBarraSalvar
            // 
            this.btnBarraSalvar.Location = new System.Drawing.Point(72, 179);
            this.btnBarraSalvar.Name = "btnBarraSalvar";
            this.btnBarraSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnBarraSalvar.TabIndex = 2;
            this.btnBarraSalvar.Text = "Salvar";
            this.btnBarraSalvar.UseVisualStyleBackColor = true;
            this.btnBarraSalvar.Click += new System.EventHandler(this.btnBarraSalvar_Click);
            // 
            // btnBarraCancelar
            // 
            this.btnBarraCancelar.Location = new System.Drawing.Point(178, 179);
            this.btnBarraCancelar.Name = "btnBarraCancelar";
            this.btnBarraCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnBarraCancelar.TabIndex = 2;
            this.btnBarraCancelar.Text = "Cancelar";
            this.btnBarraCancelar.UseVisualStyleBackColor = true;
            this.btnBarraCancelar.Click += new System.EventHandler(this.btnBarraCancelar_Click);
            // 
            // AdicionarCodigoBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 224);
            this.Controls.Add(this.btnBarraCancelar);
            this.Controls.Add(this.btnBarraSalvar);
            this.Controls.Add(this.lblBarraCod);
            this.Controls.Add(this.lblBarraNome);
            this.Controls.Add(this.lblBarraId);
            this.Controls.Add(this.txtBarraCodigo);
            this.Controls.Add(this.txtBarraNome);
            this.Controls.Add(this.txtBarraId);
            this.Name = "AdicionarCodigoBarra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarCodigoBarra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarraId;
        private System.Windows.Forms.TextBox txtBarraNome;
        private System.Windows.Forms.TextBox txtBarraCodigo;
        private System.Windows.Forms.Label lblBarraId;
        private System.Windows.Forms.Label lblBarraNome;
        private System.Windows.Forms.Label lblBarraCod;
        private System.Windows.Forms.Button btnBarraSalvar;
        private System.Windows.Forms.Button btnBarraCancelar;
    }
}