using System;
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
        private int codigo;
        private bool validarcodigo = false;
        public Validaremail(int codigo)
        {
            this.codigo = codigo;
            InitializeComponent();
        }

        public bool Validarcodigo
        {
            get { return validarcodigo; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /*Cadastro cadastro = new Cadastro();
            int t = cadastro.receba();
            MessageBox.Show("" + t);
            int number = Convert.ToInt32(textBox1.Text);

            if (number == t)
            {
                this.Close();
            }
            else
            {
                return;
            }*/
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
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Campo Vazio!!", "Digite novamente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            if(int.Parse(textBox1.Text) == codigo)
            {
                validarcodigo = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Codigo Invalido!!", "Digite novamente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
