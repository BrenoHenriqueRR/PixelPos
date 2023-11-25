using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace SistemaMarques.View
{
    public partial class Exibir_imagens : Form
    {
        private SqlDataReader sql2;
        public Exibir_imagens(SqlDataReader sql)
        {
            InitializeComponent();
            this.sql2 = sql;
        }

        private void Exibir_imagens_Load(object sender, EventArgs e)
        {
            this.Resize += Exibir_imagens_Resize;
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = conn.ReturnConnection();
            while (sql2.Read())
            {
                int idAlbum = sql2.GetInt32(sql2.GetOrdinal("id"));
                sqlCom.Parameters.Clear(); // Limpar parâmetros anteriores
                sqlCom.CommandText = "SELECT caminho_foto FROM fotos where id_album = @id_album ";
                sqlCom.Parameters.AddWithValue("@id_album", idAlbum);

                // Executar a consulta SQL dentro do loop
                using (SqlDataReader dr = sqlCom.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string caminhoImagem = dr.GetString(0);

                        // Converta o caminho da imagem em um objeto Image
                        Image imagem = Image.FromFile(caminhoImagem);

                        // Adicione a imagem ao ImageList
                        ilimagens.Images.Add(imagem);

                        ListViewItem item = new ListViewItem();
                        item.ImageIndex = ilimagens.Images.Count - 1;
                        lvimagens.Items.Add(item);
                        int pontoDeCorte = 32; // O índice até o qual você quer manter os caracteres

                            string resultado = caminhoImagem.Substring(pontoDeCorte);
                            item.Text = resultado;
                    }
                }
            }
            lvimagens.LargeImageList = ilimagens;
        }
        private void Exibir_imagens_Resize(object sender, EventArgs e)
        {
          if(WindowState == FormWindowState.Maximized)
            {
                Screen primaryScreen = Screen.PrimaryScreen;
                int width = primaryScreen.Bounds.Width;
                int height = 78;

                panel3.Size = new Size(width, height);
                lvimagens.Size = new Size(width, primaryScreen.Bounds.Height);
                btnexcluir.Location = new Point(1450, 100);

            }  
          else if(WindowState == FormWindowState.Normal)
            {
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbrelatorio_Click(object sender, EventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
