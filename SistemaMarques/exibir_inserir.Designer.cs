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
            this.btnvermn = new System.Windows.Forms.Button();
            this.btnupload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvermn
            // 
            this.btnvermn.BackColor = System.Drawing.Color.Maroon;
            this.btnvermn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvermn.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvermn.ForeColor = System.Drawing.Color.White;
            this.btnvermn.Location = new System.Drawing.Point(12, 269);
            this.btnvermn.Name = "btnvermn";
            this.btnvermn.Size = new System.Drawing.Size(170, 32);
            this.btnvermn.TabIndex = 7;
            this.btnvermn.UseVisualStyleBackColor = false;
            this.btnvermn.Click += new System.EventHandler(this.btnvermn_Click);
            // 
            // btnupload
            // 
            this.btnupload.BackColor = System.Drawing.Color.Turquoise;
            this.btnupload.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupload.ForeColor = System.Drawing.Color.White;
            this.btnupload.Location = new System.Drawing.Point(12, 144);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(170, 34);
            this.btnupload.TabIndex = 4;
            this.btnupload.Text = "Inserir";
            this.btnupload.UseVisualStyleBackColor = false;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inserir Imagem";
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.DarkRed;
            this.btnexcluir.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.Color.White;
            this.btnexcluir.Location = new System.Drawing.Point(12, 405);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(170, 34);
            this.btnexcluir.TabIndex = 8;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            // 
            // exibir_inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.btnvermn);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "exibir_inserir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "exibir_inserir";
            this.Load += new System.EventHandler(this.exibir_inserir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvermn;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexcluir;
    }
}