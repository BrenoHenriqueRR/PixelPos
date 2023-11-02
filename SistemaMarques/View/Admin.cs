using SistemaMarques.Controller;
using SistemaMarques.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaMarques
{
    public partial class Admin : Form
    {
        private Form frmAtivo;
        public Admin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Biblioteca_Load(Form frm)
        {
            bibliotecaClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            pnhome.Controls.Add(frm);
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
            Biblioteca_Load(exibirin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtivarBotao(Btnbiblioteca);
            bibliotecaClose();
            Tabela Blibioteca = new Tabela();
            Biblioteca_Load(Blibioteca);
        }

        private void pnhomee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            AtivarBotao(btnExcluir);
            bibliotecaClose();
            Excluir apagar = new Excluir();
            Biblioteca_Load(apagar);
        }

        private void btnrelatorio_Click(object sender, EventArgs e)
        {
            AtivarBotao(btnrelatorio);
            bibliotecaClose();
            Relatorio relatorio = new Relatorio();  
            Biblioteca_Load(relatorio);
        }
    }
}
 
