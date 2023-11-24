namespace SistemaMarques.View
{
    partial class EsqueciSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueciSenha));
            this.lbrecuperar = new System.Windows.Forms.Label();
            this.pnesqueci = new System.Windows.Forms.Panel();
            this.lbemailrecu = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.txbemailrecu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnesqueci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbrecuperar
            // 
            this.lbrecuperar.AutoSize = true;
            this.lbrecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrecuperar.Location = new System.Drawing.Point(63, 20);
            this.lbrecuperar.Name = "lbrecuperar";
            this.lbrecuperar.Size = new System.Drawing.Size(375, 29);
            this.lbrecuperar.TabIndex = 3;
            this.lbrecuperar.Text = "RECUPERAR A MINHA SENHA";
            // 
            // pnesqueci
            // 
            this.pnesqueci.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnesqueci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnesqueci.Controls.Add(this.lbemailrecu);
            this.pnesqueci.Controls.Add(this.richTextBox1);
            this.pnesqueci.Controls.Add(this.btnenviar);
            this.pnesqueci.Controls.Add(this.txbemailrecu);
            this.pnesqueci.Controls.Add(this.lbrecuperar);
            this.pnesqueci.Location = new System.Drawing.Point(42, 222);
            this.pnesqueci.Name = "pnesqueci";
            this.pnesqueci.Size = new System.Drawing.Size(503, 291);
            this.pnesqueci.TabIndex = 5;
            // 
            // lbemailrecu
            // 
            this.lbemailrecu.AutoSize = true;
            this.lbemailrecu.Location = new System.Drawing.Point(74, 168);
            this.lbemailrecu.Name = "lbemailrecu";
            this.lbemailrecu.Size = new System.Drawing.Size(44, 16);
            this.lbemailrecu.TabIndex = 7;
            this.lbemailrecu.Text = "Email:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(68, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(388, 94);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Insira seu e-mail, siga o link recebido por e-mail, crie uma nova senha forte. Gu" +
    "arde-a com cuidado. Este processo é essencial para manter a segurança da sua con" +
    "ta online.";
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnenviar.Location = new System.Drawing.Point(68, 236);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(370, 35);
            this.btnenviar.TabIndex = 5;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // txbemailrecu
            // 
            this.txbemailrecu.Location = new System.Drawing.Point(68, 187);
            this.txbemailrecu.Name = "txbemailrecu";
            this.txbemailrecu.Size = new System.Drawing.Size(370, 22);
            this.txbemailrecu.TabIndex = 4;
            this.txbemailrecu.TextChanged += new System.EventHandler(this.txbemailrecu_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 204);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // EsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnesqueci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EsqueciSenha";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EsqueciSenha";
            this.Load += new System.EventHandler(this.EsqueciSenha_Load);
            this.pnesqueci.ResumeLayout(false);
            this.pnesqueci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbrecuperar;
        private System.Windows.Forms.Panel pnesqueci;
        private System.Windows.Forms.TextBox txbemailrecu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label lbemailrecu;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}