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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.pixelPOSDataSet = new SistemaMarques.PixelPOSDataSet();
            this.pixelPOSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lvtabela = new System.Windows.Forms.ListView();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnimagens = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pixelPOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelPOSDataSetBindingSource)).BeginInit();
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
            listViewItem1});
            this.lvtabela.Location = new System.Drawing.Point(49, 93);
            this.lvtabela.MultiSelect = false;
            this.lvtabela.Name = "lvtabela";
            this.lvtabela.Size = new System.Drawing.Size(974, 450);
            this.lvtabela.TabIndex = 1;
            this.lvtabela.UseCompatibleStateImageBehavior = false;
            this.lvtabela.View = System.Windows.Forms.View.Details;
            this.lvtabela.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.Brown;
            this.btnexcluir.ForeColor = System.Drawing.Color.White;
            this.btnexcluir.Location = new System.Drawing.Point(1039, 502);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(118, 41);
            this.btnexcluir.TabIndex = 2;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(1039, 298);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(118, 41);
            this.btneditar.TabIndex = 3;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnimagens
            // 
            this.btnimagens.BackColor = System.Drawing.Color.SteelBlue;
            this.btnimagens.ForeColor = System.Drawing.Color.White;
            this.btnimagens.Location = new System.Drawing.Point(1039, 93);
            this.btnimagens.Name = "btnimagens";
            this.btnimagens.Size = new System.Drawing.Size(118, 41);
            this.btnimagens.TabIndex = 4;
            this.btnimagens.Text = "Imagens";
            this.btnimagens.UseVisualStyleBackColor = false;
            // 
            // Tabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 642);
            this.Controls.Add(this.btnimagens);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.lvtabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(205, 0);
            this.Name = "Tabela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ldgaleria";
            this.Load += new System.EventHandler(this.Galeria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pixelPOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelPOSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource pixelPOSDataSetBindingSource;
        private PixelPOSDataSet pixelPOSDataSet;
        private System.Windows.Forms.ListView lvtabela;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnimagens;
    }
}