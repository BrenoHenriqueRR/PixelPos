namespace SistemaMarques
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pncadastro = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btAcessar = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbtextologin = new System.Windows.Forms.Label();
            this.txbsenhalogin = new System.Windows.Forms.TextBox();
            this.Lbsenha = new System.Windows.Forms.Label();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.Lbemail = new System.Windows.Forms.Label();
            this.Pncadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pncadastro
            // 
            this.Pncadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Pncadastro.BackColor = System.Drawing.Color.White;
            this.Pncadastro.Controls.Add(this.linkLabel1);
            this.Pncadastro.Controls.Add(this.btncadastrar);
            this.Pncadastro.Controls.Add(this.btAcessar);
            this.Pncadastro.Controls.Add(this.lbLogin);
            this.Pncadastro.Controls.Add(this.lbtextologin);
            this.Pncadastro.Controls.Add(this.txbsenhalogin);
            this.Pncadastro.Controls.Add(this.Lbsenha);
            this.Pncadastro.Controls.Add(this.txbemail);
            this.Pncadastro.Controls.Add(this.Lbemail);
            this.Pncadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pncadastro.Location = new System.Drawing.Point(0, -1);
            this.Pncadastro.Name = "Pncadastro";
            this.Pncadastro.Size = new System.Drawing.Size(463, 561);
            this.Pncadastro.TabIndex = 0;
            this.Pncadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.Pncadastro_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(34, 484);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 18);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot password?";
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btncadastrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btncadastrar.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncadastrar.Location = new System.Drawing.Point(257, 479);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(165, 29);
            this.btncadastrar.TabIndex = 7;
            this.btncadastrar.Text = "Criar Conta";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btAcessar
            // 
            this.btAcessar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAcessar.BackColor = System.Drawing.Color.Brown;
            this.btAcessar.ForeColor = System.Drawing.Color.White;
            this.btAcessar.Location = new System.Drawing.Point(45, 356);
            this.btAcessar.Name = "btAcessar";
            this.btAcessar.Size = new System.Drawing.Size(365, 53);
            this.btAcessar.TabIndex = 6;
            this.btAcessar.Text = "Acessar";
            this.btAcessar.UseVisualStyleBackColor = false;
            this.btAcessar.Click += new System.EventHandler(this.btAcessar_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(43, 51);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(96, 39);
            this.lbLogin.TabIndex = 5;
            this.lbLogin.Text = "Login";
            // 
            // lbtextologin
            // 
            this.lbtextologin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbtextologin.AutoSize = true;
            this.lbtextologin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtextologin.ForeColor = System.Drawing.Color.DimGray;
            this.lbtextologin.Location = new System.Drawing.Point(46, 104);
            this.lbtextologin.Name = "lbtextologin";
            this.lbtextologin.Size = new System.Drawing.Size(320, 20);
            this.lbtextologin.TabIndex = 4;
            this.lbtextologin.Text = "Digite os seus dados nos campos abaixo.";
            this.lbtextologin.Click += new System.EventHandler(this.lbtextologin_Click);
            // 
            // txbsenhalogin
            // 
            this.txbsenhalogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txbsenhalogin.Location = new System.Drawing.Point(46, 299);
            this.txbsenhalogin.Name = "txbsenhalogin";
            this.txbsenhalogin.PasswordChar = '*';
            this.txbsenhalogin.Size = new System.Drawing.Size(364, 24);
            this.txbsenhalogin.TabIndex = 3;
            // 
            // Lbsenha
            // 
            this.Lbsenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbsenha.AutoSize = true;
            this.Lbsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbsenha.Location = new System.Drawing.Point(47, 268);
            this.Lbsenha.Name = "Lbsenha";
            this.Lbsenha.Size = new System.Drawing.Size(55, 18);
            this.Lbsenha.TabIndex = 2;
            this.Lbsenha.Text = "Senha";
            // 
            // txbemail
            // 
            this.txbemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txbemail.Location = new System.Drawing.Point(46, 210);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(364, 24);
            this.txbemail.TabIndex = 1;
            this.txbemail.TextChanged += new System.EventHandler(this.txbemail_TextChanged);
            // 
            // Lbemail
            // 
            this.Lbemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbemail.AutoSize = true;
            this.Lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbemail.Location = new System.Drawing.Point(47, 174);
            this.Lbemail.Name = "Lbemail";
            this.Lbemail.Size = new System.Drawing.Size(56, 18);
            this.Lbemail.TabIndex = 0;
            this.Lbemail.Text = "E-mail";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(448, 558);
            this.Controls.Add(this.Pncadastro);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LERMNGAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pncadastro.ResumeLayout(false);
            this.Pncadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pncadastro;
        private System.Windows.Forms.TextBox txbsenhalogin;
        private System.Windows.Forms.Label Lbsenha;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.Label Lbemail;
        private System.Windows.Forms.Label lbtextologin;
        private System.Windows.Forms.Button btAcessar;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btncadastrar;
    }
}

