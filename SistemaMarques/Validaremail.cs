﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMarques
{
    public partial class Validaremail : Form
    {
        public Validaremail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Validaremail_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            Html i = new Html();
            Cadastro cadastro = new Cadastro();
            int n = cadastro.teste();
            MessageBox.Show("" + n);
            int number = Convert.ToInt32(textBox1.Text);
            if (number == n)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
