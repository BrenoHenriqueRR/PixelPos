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
            this.pnupload = new System.Windows.Forms.Panel();
            this.btnupload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbupload = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvermn = new System.Windows.Forms.Button();
            this.pnupload.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnupload
            // 
            this.pnupload.AllowDrop = true;
            this.pnupload.BackColor = System.Drawing.Color.White;
            this.pnupload.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnupload.Controls.Add(this.btnupload);
            this.pnupload.Controls.Add(this.label3);
            this.pnupload.Controls.Add(this.lbupload);
            this.pnupload.Controls.Add(this.label2);
            this.pnupload.Location = new System.Drawing.Point(123, 51);
            this.pnupload.Name = "pnupload";
            this.pnupload.Size = new System.Drawing.Size(853, 454);
            this.pnupload.TabIndex = 3;
            this.pnupload.Paint += new System.Windows.Forms.PaintEventHandler(this.pnupload_Paint);
            // 
            // btnupload
            // 
            this.btnupload.BackColor = System.Drawing.Color.Turquoise;
            this.btnupload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupload.ForeColor = System.Drawing.Color.White;
            this.btnupload.Location = new System.Drawing.Point(253, 292);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(383, 34);
            this.btnupload.TabIndex = 4;
            this.btnupload.Text = "Clique aqui para fazer upload ";
            this.btnupload.UseVisualStyleBackColor = false;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(381, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ou,se quiser..";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(245, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arraste uma imagem";
            // 
            // lbupload
            // 
            this.lbupload.AutoSize = true;
            this.lbupload.BackColor = System.Drawing.Color.White;
            this.lbupload.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbupload.Location = new System.Drawing.Point(3, 0);
            this.lbupload.Name = "lbupload";
            this.lbupload.Size = new System.Drawing.Size(97, 31);
            this.lbupload.TabIndex = 5;
            this.lbupload.Text = "Upload";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inserir Imagem";
            // 
            // btnvermn
            // 
            this.btnvermn.BackColor = System.Drawing.Color.Maroon;
            this.btnvermn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvermn.ForeColor = System.Drawing.Color.White;
            this.btnvermn.Location = new System.Drawing.Point(850, 511);
            this.btnvermn.Name = "btnvermn";
            this.btnvermn.Size = new System.Drawing.Size(126, 32);
            this.btnvermn.TabIndex = 7;
            this.btnvermn.Text = "Ver mangas";
            this.btnvermn.UseVisualStyleBackColor = false;
            this.btnvermn.Click += new System.EventHandler(this.btnvermn_Click);
            // 
            // exibir_inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 592);
            this.Controls.Add(this.btnvermn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnupload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "exibir_inserir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "exibir_inserir";
            this.Load += new System.EventHandler(this.exibir_inserir_Load);
            this.pnupload.ResumeLayout(false);
            this.pnupload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnupload;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbupload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvermn;
    }
}