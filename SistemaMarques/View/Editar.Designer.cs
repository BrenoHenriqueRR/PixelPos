﻿namespace SistemaMarques.View
{
    partial class Editar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbnome_album = new System.Windows.Forms.TextBox();
            this.lbeditar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbnome_cli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbemail_cli = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome_album";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbnome_album
            // 
            this.txbnome_album.Location = new System.Drawing.Point(146, 214);
            this.txbnome_album.Name = "txbnome_album";
            this.txbnome_album.Size = new System.Drawing.Size(330, 22);
            this.txbnome_album.TabIndex = 1;
            // 
            // lbeditar
            // 
            this.lbeditar.AutoSize = true;
            this.lbeditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbeditar.Location = new System.Drawing.Point(180, 27);
            this.lbeditar.Name = "lbeditar";
            this.lbeditar.Size = new System.Drawing.Size(106, 29);
            this.lbeditar.TabIndex = 2;
            this.lbeditar.Text = "EDITAR";
            this.lbeditar.Click += new System.EventHandler(this.lbeditar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbeditar);
            this.panel1.Location = new System.Drawing.Point(70, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 92);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(151, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preencha os campos que deseja editar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome_Cliente";
            // 
            // txbnome_cli
            // 
            this.txbnome_cli.Location = new System.Drawing.Point(146, 298);
            this.txbnome_cli.Name = "txbnome_cli";
            this.txbnome_cli.Size = new System.Drawing.Size(330, 22);
            this.txbnome_cli.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email_Cliente";
            // 
            // txbemail_cli
            // 
            this.txbemail_cli.Location = new System.Drawing.Point(146, 382);
            this.txbemail_cli.Name = "txbemail_cli";
            this.txbemail_cli.Size = new System.Drawing.Size(330, 22);
            this.txbemail_cli.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(475, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbemail_cli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbnome_cli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbnome_album);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(205, 0);
            this.Name = "Editar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbnome_album;
        private System.Windows.Forms.Label lbeditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbnome_cli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbemail_cli;
        private System.Windows.Forms.Button button1;
    }
}