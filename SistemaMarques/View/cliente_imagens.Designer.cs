namespace SistemaMarques
{
    partial class cliente_imagens
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cliente_imagens));
            this.pnimagens = new System.Windows.Forms.Panel();
            this.lbimagens = new System.Windows.Forms.Label();
            this.lv2imagens = new System.Windows.Forms.ListView();
            this.ilmagens = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnimagens.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnimagens
            // 
            this.pnimagens.BackColor = System.Drawing.Color.Gray;
            this.pnimagens.Controls.Add(this.lbimagens);
            this.pnimagens.Location = new System.Drawing.Point(78, 21);
            this.pnimagens.Name = "pnimagens";
            this.pnimagens.Size = new System.Drawing.Size(973, 78);
            this.pnimagens.TabIndex = 4;
            // 
            // lbimagens
            // 
            this.lbimagens.AutoSize = true;
            this.lbimagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbimagens.Location = new System.Drawing.Point(39, 20);
            this.lbimagens.Name = "lbimagens";
            this.lbimagens.Size = new System.Drawing.Size(255, 38);
            this.lbimagens.TabIndex = 1;
            this.lbimagens.Text = "Imagens Album";
            // 
            // lv2imagens
            // 
            this.lv2imagens.HideSelection = false;
            this.lv2imagens.Location = new System.Drawing.Point(1, 138);
            this.lv2imagens.Name = "lv2imagens";
            this.lv2imagens.Size = new System.Drawing.Size(1063, 449);
            this.lv2imagens.TabIndex = 5;
            this.lv2imagens.UseCompatibleStateImageBehavior = false;
            // 
            // ilmagens
            // 
            this.ilmagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilmagens.ImageStream")));
            this.ilmagens.TransparentColor = System.Drawing.Color.Transparent;
            this.ilmagens.Images.SetKeyName(0, "lupa.png");
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 626);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cliente_imagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 626);
            this.Controls.Add(this.lv2imagens);
            this.Controls.Add(this.pnimagens);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cliente_imagens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cliente_imagens";
            this.Load += new System.EventHandler(this.cliente_imagens_Load);
            this.pnimagens.ResumeLayout(false);
            this.pnimagens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnimagens;
        private System.Windows.Forms.Label lbimagens;
        private System.Windows.Forms.ListView lv2imagens;
        private System.Windows.Forms.ImageList ilmagens;
        private System.Windows.Forms.Panel panel1;
    }
}