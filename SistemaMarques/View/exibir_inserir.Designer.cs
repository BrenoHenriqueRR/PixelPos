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
            this.btninseririmagem = new System.Windows.Forms.Button();
            this.lbinserir = new System.Windows.Forms.Label();
            this.txbnomealbum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbnomecli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbemailcli = new System.Windows.Forms.TextBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninseririmagem
            // 
            this.btninseririmagem.BackColor = System.Drawing.Color.Turquoise;
            this.btninseririmagem.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninseririmagem.ForeColor = System.Drawing.Color.White;
            this.btninseririmagem.Location = new System.Drawing.Point(15, 485);
            this.btninseririmagem.Name = "btninseririmagem";
            this.btninseririmagem.Size = new System.Drawing.Size(170, 34);
            this.btninseririmagem.TabIndex = 4;
            this.btninseririmagem.Text = "Inserir";
            this.btninseririmagem.UseVisualStyleBackColor = false;
            this.btninseririmagem.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // lbinserir
            // 
            this.lbinserir.AutoSize = true;
            this.lbinserir.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinserir.ForeColor = System.Drawing.Color.Black;
            this.lbinserir.Location = new System.Drawing.Point(9, 121);
            this.lbinserir.Name = "lbinserir";
            this.lbinserir.Size = new System.Drawing.Size(267, 34);
            this.lbinserir.TabIndex = 6;
            this.lbinserir.Text = "Inserir Imagem";
            // 
            // txbnomealbum
            // 
            this.txbnomealbum.Location = new System.Drawing.Point(12, 263);
            this.txbnomealbum.Multiline = true;
            this.txbnomealbum.Name = "txbnomealbum";
            this.txbnomealbum.Size = new System.Drawing.Size(226, 25);
            this.txbnomealbum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome do Album";
            // 
            // txbnomecli
            // 
            this.txbnomecli.Location = new System.Drawing.Point(476, 263);
            this.txbnomecli.Multiline = true;
            this.txbnomecli.Name = "txbnomecli";
            this.txbnomecli.Size = new System.Drawing.Size(226, 25);
            this.txbnomecli.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email Cliente";
            // 
            // txbemailcli
            // 
            this.txbemailcli.Location = new System.Drawing.Point(228, 422);
            this.txbemailcli.Multiline = true;
            this.txbemailcli.Name = "txbemailcli";
            this.txbemailcli.Size = new System.Drawing.Size(226, 25);
            this.txbemailcli.TabIndex = 12;
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnenviar.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.ForeColor = System.Drawing.Color.White;
            this.btnenviar.Location = new System.Drawing.Point(551, 494);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(170, 34);
            this.btnenviar.TabIndex = 15;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // exibir_inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 540);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.txbemailcli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbnomecli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbnomealbum);
            this.Controls.Add(this.lbinserir);
            this.Controls.Add(this.btninseririmagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "exibir_inserir";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "exibir_inserir";
            this.Load += new System.EventHandler(this.exibir_inserir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btninseririmagem;
        private System.Windows.Forms.Label lbinserir;
        private System.Windows.Forms.TextBox txbnomealbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbnomecli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbemailcli;
        private System.Windows.Forms.Button btnenviar;
    }
}