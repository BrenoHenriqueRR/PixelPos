namespace SistemaMarques
{
    partial class exibir_inserir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exibir_inserir));
            this.lbinserir = new System.Windows.Forms.Label();
            this.txbnomealbum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbnomecli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbemailcli = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnenviar = new System.Windows.Forms.Button();
            this.lbtextimg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbinserir
            // 
            this.lbinserir.AutoSize = true;
            this.lbinserir.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinserir.ForeColor = System.Drawing.Color.Black;
            this.lbinserir.Location = new System.Drawing.Point(16, 19);
            this.lbinserir.Name = "lbinserir";
            this.lbinserir.Size = new System.Drawing.Size(267, 34);
            this.lbinserir.TabIndex = 6;
            this.lbinserir.Text = "Inserir Imagem";
            // 
            // txbnomealbum
            // 
            this.txbnomealbum.Location = new System.Drawing.Point(18, 519);
            this.txbnomealbum.Name = "txbnomealbum";
            this.txbnomealbum.Size = new System.Drawing.Size(529, 22);
            this.txbnomealbum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome do Album";
            // 
            // txbnomecli
            // 
            this.txbnomecli.Location = new System.Drawing.Point(27, 197);
            this.txbnomecli.Name = "txbnomecli";
            this.txbnomecli.Size = new System.Drawing.Size(529, 22);
            this.txbnomecli.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome do Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email Cliente";
            // 
            // txbemailcli
            // 
            this.txbemailcli.Location = new System.Drawing.Point(27, 345);
            this.txbemailcli.Name = "txbemailcli";
            this.txbemailcli.Size = new System.Drawing.Size(529, 22);
            this.txbemailcli.TabIndex = 2;
            this.txbemailcli.TextChanged += new System.EventHandler(this.txbemailcli_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.lbinserir);
            this.panel3.Location = new System.Drawing.Point(78, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1091, 78);
            this.panel3.TabIndex = 18;
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnenviar.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.ForeColor = System.Drawing.Color.White;
            this.btnenviar.Location = new System.Drawing.Point(837, 560);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(317, 41);
            this.btnenviar.TabIndex = 15;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // lbtextimg
            // 
            this.lbtextimg.AutoSize = true;
            this.lbtextimg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtextimg.Location = new System.Drawing.Point(829, 519);
            this.lbtextimg.Name = "lbtextimg";
            this.lbtextimg.Size = new System.Drawing.Size(328, 18);
            this.lbtextimg.TabIndex = 20;
            this.lbtextimg.Text = "Clique em Enviar para selecionar as fotos ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(879, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 255);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // exibir_inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 642);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbtextimg);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.txbemailcli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbnomecli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbnomealbum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(205, 0);
            this.Name = "exibir_inserir";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "exibir_inserir";
            this.Load += new System.EventHandler(this.exibir_inserir_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbinserir;
        private System.Windows.Forms.TextBox txbnomealbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbnomecli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbemailcli;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label lbtextimg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}