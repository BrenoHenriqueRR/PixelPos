namespace SistemaMarques
{
    partial class Tabela
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabela));
            this.pixelPOSDataSet = new SistemaMarques.PixelPOSDataSet();
            this.pixelPOSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lvtabela = new System.Windows.Forms.ListView();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnimagens = new System.Windows.Forms.Button();
            this.pbpesquisar = new System.Windows.Forms.PictureBox();
            this.txbpesquisar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbtabela = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pixelPOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelPOSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpesquisar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pixelPOSDataSet
            // 
            this.pixelPOSDataSet.DataSetName = "PixelPOSDataSet";
            this.pixelPOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pixelPOSDataSetBindingSource
            // 
            this.pixelPOSDataSetBindingSource.DataSource = this.pixelPOSDataSet;
            this.pixelPOSDataSetBindingSource.Position = 0;
            this.pixelPOSDataSetBindingSource.CurrentChanged += new System.EventHandler(this.pixelPOSDataSetBindingSource_CurrentChanged);
            // 
            // lvtabela
            // 
            this.lvtabela.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lvtabela.FullRowSelect = true;
            this.lvtabela.GridLines = true;
            this.lvtabela.HideSelection = false;
            this.lvtabela.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.lvtabela.Location = new System.Drawing.Point(12, 137);
            this.lvtabela.MultiSelect = false;
            this.lvtabela.Name = "lvtabela";
            this.lvtabela.Size = new System.Drawing.Size(1045, 347);
            this.lvtabela.TabIndex = 1;
            this.lvtabela.UseCompatibleStateImageBehavior = false;
            this.lvtabela.View = System.Windows.Forms.View.Details;
            this.lvtabela.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.Brown;
            this.btnexcluir.ForeColor = System.Drawing.Color.White;
            this.btnexcluir.Location = new System.Drawing.Point(1063, 502);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(94, 41);
            this.btnexcluir.TabIndex = 2;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(1063, 298);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(94, 41);
            this.btneditar.TabIndex = 3;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnimagens
            // 
            this.btnimagens.BackColor = System.Drawing.Color.SteelBlue;
            this.btnimagens.ForeColor = System.Drawing.Color.White;
            this.btnimagens.Location = new System.Drawing.Point(1063, 93);
            this.btnimagens.Name = "btnimagens";
            this.btnimagens.Size = new System.Drawing.Size(94, 41);
            this.btnimagens.TabIndex = 4;
            this.btnimagens.Text = "Imagens";
            this.btnimagens.UseVisualStyleBackColor = false;
            this.btnimagens.Click += new System.EventHandler(this.btnimagens_Click);
            // 
            // pbpesquisar
            // 
            this.pbpesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbpesquisar.Image = ((System.Drawing.Image)(resources.GetObject("pbpesquisar.Image")));
            this.pbpesquisar.Location = new System.Drawing.Point(1097, 38);
            this.pbpesquisar.Name = "pbpesquisar";
            this.pbpesquisar.Size = new System.Drawing.Size(58, 49);
            this.pbpesquisar.TabIndex = 5;
            this.pbpesquisar.TabStop = false;
            this.pbpesquisar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txbpesquisar
            // 
            this.txbpesquisar.Location = new System.Drawing.Point(561, 38);
            this.txbpesquisar.Multiline = true;
            this.txbpesquisar.Name = "txbpesquisar";
            this.txbpesquisar.Size = new System.Drawing.Size(530, 32);
            this.txbpesquisar.TabIndex = 6;
            this.txbpesquisar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lbtabela);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 75);
            this.panel1.TabIndex = 7;
            // 
            // lbtabela
            // 
            this.lbtabela.AutoSize = true;
            this.lbtabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtabela.Location = new System.Drawing.Point(39, 20);
            this.lbtabela.Name = "lbtabela";
            this.lbtabela.Size = new System.Drawing.Size(139, 38);
            this.lbtabela.TabIndex = 2;
            this.lbtabela.Text = "PAINEL";
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(965, 549);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(92, 33);
            this.btnProximo.TabIndex = 8;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(12, 549);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 33);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btninserir
            // 
            this.btninserir.BackColor = System.Drawing.Color.DarkCyan;
            this.btninserir.ForeColor = System.Drawing.Color.White;
            this.btninserir.Location = new System.Drawing.Point(735, 92);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(176, 39);
            this.btninserir.TabIndex = 10;
            this.btninserir.Text = "Inserir img";
            this.btninserir.UseVisualStyleBackColor = false;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // Tabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 642);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbpesquisar);
            this.Controls.Add(this.txbpesquisar);
            this.Controls.Add(this.btnimagens);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.lvtabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(205, 0);
            this.Name = "Tabela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Galeria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pixelPOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelPOSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpesquisar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pixelPOSDataSetBindingSource;
        private PixelPOSDataSet pixelPOSDataSet;
        private System.Windows.Forms.ListView lvtabela;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnimagens;
        private System.Windows.Forms.PictureBox pbpesquisar;
        private System.Windows.Forms.TextBox txbpesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbtabela;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btninserir;
    }
}