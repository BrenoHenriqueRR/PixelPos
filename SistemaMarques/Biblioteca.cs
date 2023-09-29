using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaMarques
{
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();

        }

        private void Biblioteca_Load(object sender, EventArgs e)
        {

        }



        private void Biblioteca_Resize(object sender, EventArgs e)
        {


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btninserir_Click(object sender, EventArgs e)
        {
             this.IsMdiContainer = true;
             exibir_inserir Exibir = new exibir_inserir();
             Exibir.MdiParent = this;
             Exibir.Show();
        }   

        private void Ibinseririmagem_Paint(object sender, PaintEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
 
