namespace SistemaMarques.View
{
    partial class Relatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lvquantidadef = new System.Windows.Forms.ListView();
            this.lvclientes = new System.Windows.Forms.ListView();
            this.lvalbunscriados = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexcel = new System.Windows.Forms.Button();
            this.mcData = new System.Windows.Forms.MonthCalendar();
            this.lbrelatorio = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ntiexcel = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnexcel);
            this.panel1.Controls.Add(this.mcData);
            this.panel1.Location = new System.Drawing.Point(47, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 475);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.lvquantidadef);
            this.panel2.Controls.Add(this.lvclientes);
            this.panel2.Controls.Add(this.lvalbunscriados);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(28, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 427);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Mostrar dados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvquantidadef
            // 
            this.lvquantidadef.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvquantidadef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvquantidadef.HideSelection = false;
            this.lvquantidadef.Location = new System.Drawing.Point(211, 200);
            this.lvquantidadef.Name = "lvquantidadef";
            this.lvquantidadef.Size = new System.Drawing.Size(252, 33);
            this.lvquantidadef.TabIndex = 5;
            this.lvquantidadef.UseCompatibleStateImageBehavior = false;
            // 
            // lvclientes
            // 
            this.lvclientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvclientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvclientes.HideSelection = false;
            this.lvclientes.Location = new System.Drawing.Point(211, 133);
            this.lvclientes.Name = "lvclientes";
            this.lvclientes.Size = new System.Drawing.Size(252, 48);
            this.lvclientes.TabIndex = 4;
            this.lvclientes.UseCompatibleStateImageBehavior = false;
            this.lvclientes.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // lvalbunscriados
            // 
            this.lvalbunscriados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvalbunscriados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvalbunscriados.HideSelection = false;
            this.lvalbunscriados.Location = new System.Drawing.Point(167, 84);
            this.lvalbunscriados.Name = "lvalbunscriados";
            this.lvalbunscriados.Size = new System.Drawing.Size(252, 61);
            this.lvalbunscriados.TabIndex = 3;
            this.lvalbunscriados.UseCompatibleStateImageBehavior = false;
            this.lvalbunscriados.View = System.Windows.Forms.View.SmallIcon;
            this.lvalbunscriados.SelectedIndexChanged += new System.EventHandler(this.lvalbunscriados_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantidade de Fotos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clientes cadastrados: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Albuns Criados:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(840, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione a Data Baixo:";
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.Color.LimeGreen;
            this.btnexcel.Location = new System.Drawing.Point(810, 380);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(269, 33);
            this.btnexcel.TabIndex = 2;
            this.btnexcel.Text = "Gerar Excel";
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // mcData
            // 
            this.mcData.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mcData.Location = new System.Drawing.Point(810, 161);
            this.mcData.MaxSelectionCount = 31;
            this.mcData.Name = "mcData";
            this.mcData.TabIndex = 3;
            this.mcData.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcData_DateChanged);
            // 
            // lbrelatorio
            // 
            this.lbrelatorio.AutoSize = true;
            this.lbrelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrelatorio.Location = new System.Drawing.Point(39, 20);
            this.lbrelatorio.Name = "lbrelatorio";
            this.lbrelatorio.Size = new System.Drawing.Size(156, 38);
            this.lbrelatorio.TabIndex = 1;
            this.lbrelatorio.Text = "Relatório";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.lbrelatorio);
            this.panel3.Location = new System.Drawing.Point(75, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1091, 78);
            this.panel3.TabIndex = 2;
            // 
            // ntiexcel
            // 
            this.ntiexcel.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntiexcel.Icon = ((System.Drawing.Icon)(resources.GetObject("ntiexcel.Icon")));
            this.ntiexcel.Text = "Relatório";
            this.ntiexcel.Visible = true;
            this.ntiexcel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntiexcel_MouseDoubleClick);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 642);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(205, 0);
            this.Name = "Relatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar mcData;
        private System.Windows.Forms.Label lbrelatorio;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvquantidadef;
        private System.Windows.Forms.ListView lvclientes;
        private System.Windows.Forms.ListView lvalbunscriados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon ntiexcel;
    }
}