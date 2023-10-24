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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaMarques
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Pncadastro_Paint(object sender, PaintEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void lbtextologin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            Cadastro form2 = new Cadastro();
            form2.ShowDialog();
            

        }


        private void btAcessar_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.Parameters.AddWithValue("@email", txbemail.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txbsenhalogin.Text);
            sqlCommand.CommandText = "SELECT * FROM TB_Cadastro WHERE email = @email AND senha = @senha";


            if (string.IsNullOrWhiteSpace(txbemail.Text) | string.IsNullOrWhiteSpace(txbsenhalogin.Text) )
            {
                MessageBox.Show("Campos Vazios!! Por favor digite novamente.");
                return; 
            }
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {    
                  if (reader.HasRows)
                  {
                     MessageBox.Show("Login bem-sucedido!");
                     Admin biblioteca = new Admin();
                     this.Visible = false;
                     biblioteca.Show();
                  }
                  else
                  {
                    MessageBox.Show("Email ou senha incorretos!");
                    return;
                  }
            }
        }

        private void txbemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbsenhalogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btAcessar_Click(sender, e);
            }
        }

        private void txbsenhalogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
