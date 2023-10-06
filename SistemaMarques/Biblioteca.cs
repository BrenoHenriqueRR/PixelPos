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
        private Form frmAtivo;
        public Biblioteca()
        {
            InitializeComponent();

        }

        private void Biblioteca_Load(Form frm)
        {
            bibliotecaClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            pnhomee.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void bibliotecaClose()
        {
            if (frmAtivo != null) {
                frmAtivo.Close();
            }
        }

        private void AtivarBotao(Button frmAtivo)
        {
            foreach (Control ctrl in pnopcoes.Controls)
            {
                ctrl.ForeColor = Color.White;
            }

            frmAtivo.ForeColor = Color.Red;
        }

        private void Biblioteca_Load(object sender, EventArgs e)
        {
             
        }



        private void Biblioteca_Resize(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            AtivarBotao(btninserir);
            exibir_inserir exibirin = new exibir_inserir();
            exibirin.Show();

             //this.ismdicontainer = true;
             //exibir_inserir exibir = new exibir_inserir();
             //exibir.mdiparent = this;
             //exibir.show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtivarBotao(button1);
            Galeria Blibioteca = new Galeria();
            Blibioteca.Show();
        }
    }
}
 
