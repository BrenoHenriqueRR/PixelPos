namespace SistemaMarques.View
{
    partial class Exibir_imagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exibir_imagens));
            this.ilimagens = new System.Windows.Forms.ImageList(this.components);
            this.pnexibiri = new System.Windows.Forms.Panel();
            this.lvimagens = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbrelatorio = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.pnexibiri.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilimagens
            // 
            this.ilimagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilimagens.ImageStream")));
            this.ilimagens.TransparentColor = System.Drawing.Color.Transparent;
            this.ilimagens.Images.SetKeyName(0, "lupa.png");
            // 
            // pnexibiri
            // 
            this.pnexibiri.BackColor = System.Drawing.Color.White;
            this.pnexibiri.Controls.Add(this.btnexcluir);
            this.pnexibiri.Controls.Add(this.panel3);
            this.pnexibiri.Controls.Add(this.lvimagens);
            this.pnexibiri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnexibiri.Location = new System.Drawing.Point(0, 0);
            this.pnexibiri.Name = "pnexibiri";
            this.pnexibiri.Size = new System.Drawing.Size(1063, 626);
            this.pnexibiri.TabIndex = 0;
            this.pnexibiri.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lvimagens
            // 
            this.lvimagens.HideSelection = false;
            this.lvimagens.Location = new System.Drawing.Point(0, 174);
            this.lvimagens.Name = "lvimagens";
            this.lvimagens.Size = new System.Drawing.Size(1063, 449);
            this.lvimagens.TabIndex = 0;
            this.lvimagens.UseCompatibleStateImageBehavior = false;
            this.lvimagens.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.lbrelatorio);
            this.panel3.Location = new System.Drawing.Point(90, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 78);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbrelatorio
            // 
            this.lbrelatorio.AutoSize = true;
            this.lbrelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrelatorio.Location = new System.Drawing.Point(39, 20);
            this.lbrelatorio.Name = "lbrelatorio";
            this.lbrelatorio.Size = new System.Drawing.Size(255, 38);
            this.lbrelatorio.TabIndex = 1;
            this.lbrelatorio.Text = "Imagens Album";
            this.lbrelatorio.Click += new System.EventHandler(this.lbrelatorio_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.Brown;
            this.btnexcluir.ForeColor = System.Drawing.Color.White;
            this.btnexcluir.Location = new System.Drawing.Point(966, 127);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(94, 41);
            this.btnexcluir.TabIndex = 3;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // Exibir_imagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 626);
            this.Controls.Add(this.pnexibiri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exibir_imagens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exibir_imagens";
            this.Load += new System.EventHandler(this.Exibir_imagens_Load);
            this.pnexibiri.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilimagens;
        private System.Windows.Forms.Panel pnexibiri;
        private System.Windows.Forms.ListView lvimagens;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbrelatorio;
        private System.Windows.Forms.Button btnexcluir;
    }
}