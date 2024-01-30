namespace ListagemClientes
{
    partial class frmCadastroCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtInscEst = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.cmbEstCiv = new System.Windows.Forms.ComboBox();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Insc. est.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado civil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data nascimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "UF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cidade";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(37, 47);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(225, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtRg
            // 
            this.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Location = new System.Drawing.Point(37, 176);
            this.txtRg.MaxLength = 20;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(93, 20);
            this.txtRg.TabIndex = 2;
            this.txtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRg_KeyPress);
            // 
            // txtInscEst
            // 
            this.txtInscEst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscEst.Location = new System.Drawing.Point(37, 245);
            this.txtInscEst.MaxLength = 20;
            this.txtInscEst.Name = "txtInscEst";
            this.txtInscEst.Size = new System.Drawing.Size(93, 20);
            this.txtInscEst.TabIndex = 3;
            this.txtInscEst.TextChanged += new System.EventHandler(this.txtInscEst_TextChanged);
            this.txtInscEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInscEst_KeyPress);
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(366, 47);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(225, 20);
            this.txtCidade.TabIndex = 4;
            // 
            // txtUf
            // 
            this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.Location = new System.Drawing.Point(366, 245);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(69, 20);
            this.txtUf.TabIndex = 7;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(592, 270);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // cmbEstCiv
            // 
            this.cmbEstCiv.FormattingEnabled = true;
            this.cmbEstCiv.Items.AddRange(new object[] {
            "SOLTEIRO",
            "CASADO",
            "VIÚVO",
            "DIVORCIADO",
            "OUTRO"});
            this.cmbEstCiv.Location = new System.Drawing.Point(366, 113);
            this.cmbEstCiv.Name = "cmbEstCiv";
            this.cmbEstCiv.Size = new System.Drawing.Size(169, 21);
            this.cmbEstCiv.TabIndex = 5;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(366, 176);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(69, 20);
            this.txtDataNasc.TabIndex = 6;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            this.txtDataNasc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataNasc_KeyPress);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(37, 108);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(93, 20);
            this.txtCpf.TabIndex = 1;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(511, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 314);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.cmbEstCiv);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtInscEst);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtRg;
        public System.Windows.Forms.TextBox txtInscEst;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtUf;
        public System.Windows.Forms.ComboBox cmbEstCiv;
        public System.Windows.Forms.MaskedTextBox txtDataNasc;
        public System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Button btnCancelar;
    }
}