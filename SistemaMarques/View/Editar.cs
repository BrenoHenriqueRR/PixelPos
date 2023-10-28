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
            int id = editarid;
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
            sqlCom.CommandText = "UPDATE Imagens SET nome_album,nome_cli,nome_email WHERE id = @id";
            sqlCom.Parameters.AddWithValue("@id", this.id);
            sqlCom.Parameters.AddWithValue("@nome_album", this.id);
            sqlCom.Parameters.AddWithValue("@nome_cli", this.id);
            sqlCom.Parameters.AddWithValue("@nome_email", this.id)

        }
    }
}
