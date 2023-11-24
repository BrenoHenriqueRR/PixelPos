namespace SistemaMarques.View
{
    partial class Ajuda
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
            this.pnajuda = new System.Windows.Forms.Panel();
            this.lbajuda = new System.Windows.Forms.Label();
            this.pnajuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnajuda
            // 
            this.pnajuda.BackColor = System.Drawing.Color.Gray;
            this.pnajuda.Controls.Add(this.lbajuda);
            this.pnajuda.Location = new System.Drawing.Point(78, 12);
            this.pnajuda.Name = "pnajuda";
            this.pnajuda.Size = new System.Drawing.Size(1091, 78);
            this.pnajuda.TabIndex = 3;
            // 
            // lbajuda
            // 
            this.lbajuda.AutoSize = true;
            this.lbajuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbajuda.Location = new System.Drawing.Point(39, 20);
            this.lbajuda.Name = "lbajuda";
            this.lbajuda.Size = new System.Drawing.Size(105, 38);
            this.lbajuda.TabIndex = 1;
            this.lbajuda.Text = "Ajuda";
            this.lbajuda.Click += new System.EventHandler(this.lbrelatorio_Click);
            // 
            // Ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 642);
            this.Controls.Add(this.pnajuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(205, 0);
            this.Name = "Ajuda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir";
            this.Load += new System.EventHandler(this.Excluir_Load);
            this.pnajuda.ResumeLayout(false);
            this.pnajuda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnajuda;
        private System.Windows.Forms.Label lbajuda;
    }
}