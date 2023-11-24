using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMarques.View
{
    public partial class RecuperarSenha : Form
    {
        private string email;
        public RecuperarSenha(string e_mail)
        {
            InitializeComponent();
            this.email = e_mail;
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            string senha = txbsenharecu.Text;
            if (senha == txbconfsenharecu.Text) {
                Connection conn = new Connection();
                SqlCommand sql = new SqlCommand();


                sql.Connection = conn.ReturnConnection();
                sql.CommandText = ("Update TB_Cadastro set senha = @senha");
                sql.Parameters.AddWithValue("@senha",senha);

                try
                {
                    sql.ExecuteNonQuery();
                    MessageBox.Show(
                    "Cadastrado com Sucesso",
                    "CADASTRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao inserir no banco: " + ex.Message);
                    return;
                }

            }else
                {
                MessageBox.Show("Senhas diferentes ,digite novamente!!",
                               "",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
                 }
        }
    }
}
