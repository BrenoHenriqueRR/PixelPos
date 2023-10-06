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
            this.pnopcoes = new System.Windows.Forms.Panel();
            this.btnrelatório = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbHome = new System.Windows.Forms.Label();
            this.btninserir = new System.Windows.Forms.Button();
            this.pnhomee = new System.Windows.Forms.Panel();
            this.pnopcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnopcoes
            // 
            this.pnopcoes.AutoSize = true;
            this.pnopcoes.BackColor = System.Drawing.Color.Black;
            this.pnopcoes.Controls.Add(this.btnrelatório);
            this.pnopcoes.Controls.Add(this.button1);
            this.pnopcoes.Controls.Add(this.btninserir);
            this.pnopcoes.Controls.Add(this.lbHome);
            this.pnopcoes.Location = new System.Drawing.Point(0, 0);
            this.pnopcoes.Name = "pnopcoes";
            this.pnopcoes.Size = new System.Drawing.Size(195, 590);
            this.pnopcoes.TabIndex = 0;
            // 
            // btnrelatório
            // 
            this.btnrelatório.AutoSize = true;
            this.btnrelatório.BackColor = System.Drawing.Color.Black;
            this.btnrelatório.FlatAppearance.BorderSize = 0;
            this.btnrelatório.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnrelatório.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrelatório.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrelatório.ForeColor = System.Drawing.Color.White;
            this.btnrelatório.Location = new System.Drawing.Point(-1, 422);
            this.btnrelatório.Name = "btnrelatório";
            this.btnrelatório.Size = new System.Drawing.Size(193, 69);
            this.btnrelatório.TabIndex = 6;
            this.btnrelatório.Text = "Relatório";
            this.btnrelatório.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-1, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 77);
            this.button1.TabIndex = 5;
            this.button1.Text = "Biblioteca";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.ForeColor = System.Drawing.Color.White;
            this.lbHome.Location = new System.Drawing.Point(40, 27);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(96, 36);
            this.lbHome.TabIndex = 4;
            this.lbHome.Text = "Home";
            this.lbHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbHome.Click += new System.EventHandler(this.label1_Click);
            // 
            // btninserir
            // 
            this.btninserir.AutoSize = true;
            this.btninserir.BackColor = System.Drawing.Color.Black;
            this.btninserir.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btninserir.FlatAppearance.BorderSize = 0;
            this.btninserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btninserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btninserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninserir.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.ForeColor = System.Drawing.Color.White;
            this.btninserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninserir.Location = new System.Drawing.Point(-1, 110);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(193, 66);
            this.btninserir.TabIndex = 1;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = false;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // pnhomee
            // 
            this.pnhomee.Location = new System.Drawing.Point(189, 0);
            this.pnhomee.Name = "pnhomee";
            this.pnhomee.Size = new System.Drawing.Size(987, 590);
            this.pnhomee.TabIndex = 1;
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 590);
            this.Controls.Add(this.pnhomee);
            this.Controls.Add(this.pnopcoes);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Biblioteca";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PixelPOS";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Biblioteca_Load);
            this.Resize += new System.EventHandler(this.Biblioteca_Resize);
            this.pnopcoes.ResumeLayout(false);
            this.pnopcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnopcoes;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btnrelatório;
        private System.Windows.Forms.Panel pnhomee;
    }
}