namespace SistemaMarques
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.btcadastrar = new System.Windows.Forms.Button();
            this.lbCadastre_se = new System.Windows.Forms.Label();
            this.txbfistname = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.lbfirstname = new System.Windows.Forms.Label();
            this.lbemailregister = new System.Windows.Forms.Label();
            this.txbemailCadastrar = new System.Windows.Forms.TextBox();
            this.lbsenharegister = new System.Windows.Forms.Label();
            this.lbdatanasc = new System.Windows.Forms.Label();
            this.LBCPF = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbfeminino = new System.Windows.Forms.CheckBox();
            this.cbmasculino = new System.Windows.Forms.CheckBox();
            this.cboutros = new System.Windows.Forms.CheckBox();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.msktxbdate = new System.Windows.Forms.MaskedTextBox();
            this.txbsenhafirme = new System.Windows.Forms.TextBox();
            this.msktxbcpf = new System.Windows.Forms.MaskedTextBox();
            this.cbmostrarsenha2 = new System.Windows.Forms.CheckBox();
            this.cbmostrarsenha1 = new System.Windows.Forms.CheckBox();
            this.pnCadastro = new System.Windows.Forms.Panel();
            this.pnCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btcadastrar
            // 
            this.btcadastrar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.ForeColor = System.Drawing.Color.White;
            this.btcadastrar.Location = new System.Drawing.Point(47, 428);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(566, 37);
            this.btcadastrar.TabIndex = 0;
            this.btcadastrar.Text = "CADASTRAR";
            this.btcadastrar.UseVisualStyleBackColor = false;
            this.btcadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCadastre_se
            // 
            this.lbCadastre_se.AutoSize = true;
            this.lbCadastre_se.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastre_se.Location = new System.Drawing.Point(40, 17);
            this.lbCadastre_se.Name = "lbCadastre_se";
            this.lbCadastre_se.Size = new System.Drawing.Size(183, 37);
            this.lbCadastre_se.TabIndex = 1;
            this.lbCadastre_se.Text = "Cadastre-se";
            // 
            // txbfistname
            // 
            this.txbfistname.AccessibleDescription = "";
            this.txbfistname.AccessibleName = "";
            this.txbfistname.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txbfistname.Location = new System.Drawing.Point(47, 129);
            this.txbfistname.Name = "txbfistname";
            this.txbfistname.Size = new System.Drawing.Size(231, 22);
            this.txbfistname.TabIndex = 2;
            this.txbfistname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.Crimson;
            this.btnentrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar.ForeColor = System.Drawing.Color.White;
            this.btnentrar.Location = new System.Drawing.Point(524, 24);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(89, 34);
            this.btnentrar.TabIndex = 3;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // lbfirstname
            // 
            this.lbfirstname.AutoSize = true;
            this.lbfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfirstname.Location = new System.Drawing.Point(44, 99);
            this.lbfirstname.Name = "lbfirstname";
            this.lbfirstname.Size = new System.Drawing.Size(135, 16);
            this.lbfirstname.TabIndex = 4;
            this.lbfirstname.Text = "Digite o seu Nome";
            this.lbfirstname.Click += new System.EventHandler(this.lbfirstname_Click);
            // 
            // lbemailregister
            // 
            this.lbemailregister.AutoSize = true;
            this.lbemailregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemailregister.Location = new System.Drawing.Point(44, 179);
            this.lbemailregister.Name = "lbemailregister";
            this.lbemailregister.Size = new System.Drawing.Size(51, 16);
            this.lbemailregister.TabIndex = 5;
            this.lbemailregister.Text = "E-mail";
            // 
            // txbemailCadastrar
            // 
            this.txbemailCadastrar.Location = new System.Drawing.Point(47, 208);
            this.txbemailCadastrar.Name = "txbemailCadastrar";
            this.txbemailCadastrar.Size = new System.Drawing.Size(231, 22);
            this.txbemailCadastrar.TabIndex = 6;
            this.txbemailCadastrar.TextChanged += new System.EventHandler(this.txbemail_TextChanged);
            // 
            // lbsenharegister
            // 
            this.lbsenharegister.AutoSize = true;
            this.lbsenharegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsenharegister.Location = new System.Drawing.Point(44, 273);
            this.lbsenharegister.Name = "lbsenharegister";
            this.lbsenharegister.Size = new System.Drawing.Size(51, 16);
            this.lbsenharegister.TabIndex = 7;
            this.lbsenharegister.Text = "Senha";
            // 
            // lbdatanasc
            // 
            this.lbdatanasc.AutoSize = true;
            this.lbdatanasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdatanasc.Location = new System.Drawing.Point(395, 99);
            this.lbdatanasc.Name = "lbdatanasc";
            this.lbdatanasc.Size = new System.Drawing.Size(148, 16);
            this.lbdatanasc.TabIndex = 9;
            this.lbdatanasc.Text = "Data de Nascimento";
            // 
            // LBCPF
            // 
            this.LBCPF.AutoSize = true;
            this.LBCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCPF.Location = new System.Drawing.Point(395, 179);
            this.LBCPF.Name = "LBCPF";
            this.LBCPF.Size = new System.Drawing.Size(36, 16);
            this.LBCPF.TabIndex = 11;
            this.LBCPF.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Confime sua senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Gênero";
            // 
            // cbfeminino
            // 
            this.cbfeminino.AutoSize = true;
            this.cbfeminino.Location = new System.Drawing.Point(47, 385);
            this.cbfeminino.Name = "cbfeminino";
            this.cbfeminino.Size = new System.Drawing.Size(84, 20);
            this.cbfeminino.TabIndex = 18;
            this.cbfeminino.Text = "Feminino";
            this.cbfeminino.UseVisualStyleBackColor = true;
            this.cbfeminino.CheckedChanged += new System.EventHandler(this.cbfeminino_CheckedChanged);
            // 
            // cbmasculino
            // 
            this.cbmasculino.AutoSize = true;
            this.cbmasculino.Location = new System.Drawing.Point(297, 385);
            this.cbmasculino.Name = "cbmasculino";
            this.cbmasculino.Size = new System.Drawing.Size(90, 20);
            this.cbmasculino.TabIndex = 19;
            this.cbmasculino.Text = "Masculino";
            this.cbmasculino.UseVisualStyleBackColor = true;
            this.cbmasculino.CheckedChanged += new System.EventHandler(this.cbmasculino_CheckedChanged);
            // 
            // cboutros
            // 
            this.cboutros.AutoSize = true;
            this.cboutros.Location = new System.Drawing.Point(545, 385);
            this.cboutros.Name = "cboutros";
            this.cboutros.Size = new System.Drawing.Size(68, 20);
            this.cboutros.TabIndex = 20;
            this.cboutros.Text = "Outros";
            this.cboutros.UseVisualStyleBackColor = true;
            this.cboutros.CheckedChanged += new System.EventHandler(this.cboutros_CheckedChanged);
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(47, 301);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.PasswordChar = '*';
            this.txbsenha.Size = new System.Drawing.Size(212, 22);
            this.txbsenha.TabIndex = 22;
            this.txbsenha.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // msktxbdate
            // 
            this.msktxbdate.Location = new System.Drawing.Point(398, 129);
            this.msktxbdate.Mask = "00/00/0000";
            this.msktxbdate.Name = "msktxbdate";
            this.msktxbdate.Size = new System.Drawing.Size(125, 22);
            this.msktxbdate.TabIndex = 23;
            this.msktxbdate.ValidatingType = typeof(System.DateTime);
            this.msktxbdate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktxbdate_MaskInputRejected);
            // 
            // txbsenhafirme
            // 
            this.txbsenhafirme.BackColor = System.Drawing.Color.White;
            this.txbsenhafirme.Location = new System.Drawing.Point(398, 301);
            this.txbsenhafirme.Name = "txbsenhafirme";
            this.txbsenhafirme.PasswordChar = '*';
            this.txbsenhafirme.Size = new System.Drawing.Size(212, 22);
            this.txbsenhafirme.TabIndex = 24;
            this.txbsenhafirme.TextChanged += new System.EventHandler(this.txbsenhafirme_TextChanged);
            // 
            // msktxbcpf
            // 
            this.msktxbcpf.Location = new System.Drawing.Point(398, 208);
            this.msktxbcpf.Mask = "000.000.000-00";
            this.msktxbcpf.Name = "msktxbcpf";
            this.msktxbcpf.Size = new System.Drawing.Size(125, 22);
            this.msktxbcpf.TabIndex = 25;
            // 
            // cbmostrarsenha2
            // 
            this.cbmostrarsenha2.AutoSize = true;
            this.cbmostrarsenha2.BackColor = System.Drawing.SystemColors.Control;
            this.cbmostrarsenha2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbmostrarsenha2.ForeColor = System.Drawing.SystemColors.Control;
            this.cbmostrarsenha2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbmostrarsenha2.Location = new System.Drawing.Point(613, 305);
            this.cbmostrarsenha2.Name = "cbmostrarsenha2";
            this.cbmostrarsenha2.Size = new System.Drawing.Size(18, 17);
            this.cbmostrarsenha2.TabIndex = 26;
            this.cbmostrarsenha2.UseVisualStyleBackColor = false;
            this.cbmostrarsenha2.CheckedChanged += new System.EventHandler(this.cbmostrarsenha2_CheckedChanged);
            // 
            // cbmostrarsenha1
            // 
            this.cbmostrarsenha1.AutoSize = true;
            this.cbmostrarsenha1.Location = new System.Drawing.Point(260, 305);
            this.cbmostrarsenha1.Name = "cbmostrarsenha1";
            this.cbmostrarsenha1.Size = new System.Drawing.Size(18, 17);
            this.cbmostrarsenha1.TabIndex = 27;
            this.cbmostrarsenha1.UseVisualStyleBackColor = true;
            this.cbmostrarsenha1.CheckedChanged += new System.EventHandler(this.cbmostrarsenha1_CheckedChanged);
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.cbmostrarsenha2);
            this.pnCadastro.Controls.Add(this.cbmostrarsenha1);
            this.pnCadastro.Controls.Add(this.msktxbcpf);
            this.pnCadastro.Controls.Add(this.txbsenhafirme);
            this.pnCadastro.Controls.Add(this.msktxbdate);
            this.pnCadastro.Controls.Add(this.txbsenha);
            this.pnCadastro.Controls.Add(this.cboutros);
            this.pnCadastro.Controls.Add(this.cbmasculino);
            this.pnCadastro.Controls.Add(this.cbfeminino);
            this.pnCadastro.Controls.Add(this.label6);
            this.pnCadastro.Controls.Add(this.label5);
            this.pnCadastro.Controls.Add(this.LBCPF);
            this.pnCadastro.Controls.Add(this.lbdatanasc);
            this.pnCadastro.Controls.Add(this.lbsenharegister);
            this.pnCadastro.Controls.Add(this.txbemailCadastrar);
            this.pnCadastro.Controls.Add(this.lbemailregister);
            this.pnCadastro.Controls.Add(this.lbfirstname);
            this.pnCadastro.Controls.Add(this.btnentrar);
            this.pnCadastro.Controls.Add(this.txbfistname);
            this.pnCadastro.Controls.Add(this.lbCadastre_se);
            this.pnCadastro.Controls.Add(this.btcadastrar);
            this.pnCadastro.Location = new System.Drawing.Point(2, -5);
            this.pnCadastro.Name = "pnCadastro";
            this.pnCadastro.Size = new System.Drawing.Size(652, 499);
            this.pnCadastro.TabIndex = 28;
            this.pnCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 485);
            this.Controls.Add(this.pnCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Label lbCadastre_se;
        private System.Windows.Forms.TextBox txbfistname;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Label lbfirstname;
        private System.Windows.Forms.Label lbemailregister;
        private System.Windows.Forms.TextBox txbemailCadastrar;
        private System.Windows.Forms.Label lbsenharegister;
        private System.Windows.Forms.Label lbdatanasc;
        private System.Windows.Forms.Label LBCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbfeminino;
        private System.Windows.Forms.CheckBox cbmasculino;
        private System.Windows.Forms.CheckBox cboutros;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.MaskedTextBox msktxbdate;
        private System.Windows.Forms.TextBox txbsenhafirme;
        private System.Windows.Forms.MaskedTextBox msktxbcpf;
        private System.Windows.Forms.CheckBox cbmostrarsenha2;
        private System.Windows.Forms.CheckBox cbmostrarsenha1;
        private System.Windows.Forms.Panel pnCadastro;
    }
}