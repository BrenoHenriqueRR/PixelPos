namespace SistemaMarques
{
    partial class Galeria
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
            this.lvtabela.GridLines = true;
            this.lvtabela.HideSelection = false;
            this.lvtabela.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvtabela.Location = new System.Drawing.Point(49, 93);
            this.lvtabela.Name = "lvtabela";
            this.lvtabela.Size = new System.Drawing.Size(1049, 450);
            this.lvtabela.TabIndex = 1;
            this.lvtabela.UseCompatibleStateImageBehavior = false;
            this.lvtabela.View = System.Windows.Forms.View.Details;
            this.lvtabela.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Galeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 642);
            this.Controls.Add(this.lvtabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(205, 0);
            this.Name = "Galeria";
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
    }
}