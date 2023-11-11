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
    public partial class Imagens : Form
    {
        private SqlDataReader sql2;
        public Imagens(SqlDataReader sql)
        {
            InitializeComponent();
            this.sql2 = sql;

        }

        private void Imagens_Load(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT caminho_foto FROM fotos where id_album IN (";

            while (sql2.Read())
            {
                int idAlbum = sql2.GetInt32(sql2.GetOrdinal("id"));
                sqlCom.CommandText += idAlbum + ",";
            }

            sqlCom.CommandText = sqlCom.CommandText.TrimEnd(',') + ")";
            sqlCom.Parameters.Clear(); // Limpa os parâmetros anteriores

            using (SqlDataReader ler = sqlCom.ExecuteReader())
            {
                List<string> caminho_fotos = new List<string>();

                while (ler.Read())
                {
                    caminho_fotos.Add(ler["caminho_foto"].ToString());
                }
                conn.CloseConnection();

                foreach (string caminhoDaImagem in caminho_fotos)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 200;
                    pictureBox.Height = 200;
                    pictureBox.ImageLocation = caminhoDaImagem;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    // Adicione o PictureBox ao seu controle de layout (por exemplo, um FlowLayoutPanel ou Panel)
                    panel1.Controls.Add(pictureBox);
                }
            }
        }
    }
}
