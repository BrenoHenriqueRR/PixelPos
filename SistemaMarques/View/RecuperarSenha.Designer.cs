namespace SistemaMarques.View
{
    partial class RecuperarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarSenha));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnesqueci = new System.Windows.Forms.Panel();
            this.lbsenha = new System.Windows.Forms.Label();
            this.txbsenharecu = new System.Windows.Forms.TextBox();
            this.lbemailrecu = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.txbconfsenharecu = new System.Windows.Forms.TextBox();
            this.lbrecuperarsenha = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnesqueci.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 230);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pnesqueci
            // 
            this.pnesqueci.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnesqueci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnesqueci.Controls.Add(this.lbsenha);
            this.pnesqueci.Controls.Add(this.txbsenharecu);
            this.pnesqueci.Controls.Add(this.lbemailrecu);
            this.pnesqueci.Controls.Add(this.btnenviar);
            this.pnesqueci.Controls.Add(this.txbconfsenharecu);
            this.pnesqueci.Controls.Add(this.lbrecuperarsenha);
            this.pnesqueci.Location = new System.Drawing.Point(29, 239);
            this.pnesqueci.Name = "pnesqueci";
            this.pnesqueci.Size = new System.Drawing.Size(503, 293);
            this.pnesqueci.TabIndex = 8;
            // 
            // lbsenha
            // 
            this.lbsenha.AutoSize = true;
            this.lbsenha.Location = new System.Drawing.Point(71, 76);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(46, 16);
            this.lbsenha.TabIndex = 9;
            this.lbsenha.Text = "Senha";
            // 
            // txbsenharecu
            // 
            this.txbsenharecu.Location = new System.Drawing.Point(68, 95);
            this.txbsenharecu.Name = "txbsenharecu";
            this.txbsenharecu.Size = new System.Drawing.Size(370, 22);
            this.txbsenharecu.TabIndex = 8;
            this.txbsenharecu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbemailrecu
            // 
            this.lbemailrecu.AutoSize = true;
            this.lbemailrecu.Location = new System.Drawing.Point(71, 168);
            this.lbemailrecu.Name = "lbemailrecu";
            this.lbemailrecu.Size = new System.Drawing.Size(128, 16);
            this.lbemailrecu.TabIndex = 7;
            this.lbemailrecu.Text = "Confirme sua senha:";
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnenviar.Location = new System.Drawing.Point(68, 235);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(370, 35);
            this.btnenviar.TabIndex = 5;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // txbconfsenharecu
            // 
            this.txbconfsenharecu.Location = new System.Drawing.Point(68, 187);
            this.txbconfsenharecu.Name = "txbconfsenharecu";
            this.txbconfsenharecu.Size = new System.Drawing.Size(370, 22);
            this.txbconfsenharecu.TabIndex = 4;
            // 
            // lbrecuperarsenha
            // 
            this.lbrecuperarsenha.AutoSize = true;
            this.lbrecuperarsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrecuperarsenha.Location = new System.Drawing.Point(127, 17);
            this.lbrecuperarsenha.Name = "lbrecuperarsenha";
            this.lbrecuperarsenha.Size = new System.Drawing.Size(262, 29);
            this.lbrecuperarsenha.TabIndex = 3;
            this.lbrecuperarsenha.Text = "Crie uma Nova senha";
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.Color.IndianRed;
            this.btnfechar.Location = new System.Drawing.Point(474, 12);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(88, 36);
            this.btnfechar.TabIndex = 9;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // RecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 567);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.pnesqueci);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecuperarSenha";
            this.Text = "RecuperarSenha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnesqueci.ResumeLayout(false);
            this.pnesqueci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnesqueci;
        private System.Windows.Forms.Label lbsenha;
        private System.Windows.Forms.TextBox txbsenharecu;
        private System.Windows.Forms.Label lbemailrecu;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.TextBox txbconfsenharecu;
        private System.Windows.Forms.Label lbrecuperarsenha;
        private System.Windows.Forms.Button btnfechar;
    }
}