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

namespace SistemaMarques.View
{
    public partial class Editar : Form
    {
        private int id;
        public Editar(int editarid)
        {
            InitializeComponent();
            this.id = editarid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbeditar_Click(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"UPDATE Imagens SET  
                nome_album = @nome_album,
                nome_cli = @nome_cli ,
                email_cli = @email_cli
                WHERE id = @id ";
            sqlCom.Parameters.AddWithValue("@nome_album", txbnome_album.Text);
            sqlCom.Parameters.AddWithValue("@nome_cli", txbnome_cli.Text);
            sqlCom.Parameters.AddWithValue("@email_cli", txbemail_cli.Text);
            sqlCom.Parameters.AddWithValue("@id", id);

            try
            {
                sqlCom.ExecuteNonQuery();
                MessageBox.Show(
                    "Album editado com Sucesso",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                   );

            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir colaborador no banco.\n"
                    + err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            this.Close();
        }
    }
}
