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
    public partial class cliente_imagens : Form
    {
        public cliente_imagens()
        {
            InitializeComponent();
        }

        private void cliente_imagens_Load(object sender, EventArgs e)
        {
            this.Resize += cliente_imagens_Resize;
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = conn.ReturnConnection();
        
                sqlCom.Parameters.Clear();
                sqlCom.CommandText = "SELECT caminho_foto FROM fotos where id_album = @id_album ";
                sqlCom.Parameters.AddWithValue("@id_album", 3);

                using (SqlDataReader dr = sqlCom.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string caminhoImagem = dr.GetString(0);

                        // Converte o caminho da imagem em um objeto Image
                        Image imagem = Image.FromFile(caminhoImagem);

                        // Adiciona a imagem ao ImageList
                        ilmagens.Images.Add(imagem);

                        ListViewItem item = new ListViewItem();
                        item.ImageIndex = ilmagens.Images.Count - 1;
                        lv2imagens.Items.Add(item);

                        item.Text = caminhoImagem;
                    }
                }
            lv2imagens.LargeImageList = ilmagens;
        }

        private void cliente_imagens_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Screen primaryScreen = Screen.PrimaryScreen;
                int width = primaryScreen.Bounds.Width;
                int height = 78;

                pnimagens.Size = new Size(width, height);
                lv2imagens.Size = new Size(width, primaryScreen.Bounds.Height);

            }
            else if (WindowState == FormWindowState.Normal)
            {
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
