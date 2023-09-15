namespace SistemaMarques
{
    partial class Biblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteca));
            this.pnBiblioteca = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnBiblioteca
            // 
            this.pnBiblioteca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBiblioteca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.pnBiblioteca.Name = "pnBiblioteca";
            this.pnBiblioteca.Size = new System.Drawing.Size(822, 450);
            this.pnBiblioteca.TabIndex = 0;
            this.pnBiblioteca.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBiblioteca_Paint);
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.pnBiblioteca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Biblioteca";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Biblioteca_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBiblioteca;
    }
}