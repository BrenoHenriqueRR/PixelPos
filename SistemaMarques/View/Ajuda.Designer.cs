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
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbcalendar = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnajuda.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.lbcalendar);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(78, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 480);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(74, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(311, 286);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "\nPara selecionar de uma data até a outra no calendário é necessário segurar o \nbo" +
    "tão shift do teclado.\n\n\nQuando desejar selecionar apenas um dia no calendário, c" +
    "oloque ele e o próximo dia";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbcalendar
            // 
            this.lbcalendar.AutoSize = true;
            this.lbcalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcalendar.Location = new System.Drawing.Point(151, 47);
            this.lbcalendar.Name = "lbcalendar";
            this.lbcalendar.Size = new System.Drawing.Size(136, 22);
            this.lbcalendar.TabIndex = 3;
            this.lbcalendar.Text = "CALENDÁRIO";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(687, 72);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(311, 286);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "\nQuando fizer um pesquisa e quiser retornar a mostrar tudo basta clickar na lupa " +
    "\n\n\nSelecione uma linha antes de apertar o botão desejado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(779, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Biblioteca";
            // 
            // Ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 642);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnajuda;
        private System.Windows.Forms.Label lbajuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbcalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}