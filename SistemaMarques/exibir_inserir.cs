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
    public partial class exibir_inserir : Form
    {
        public exibir_inserir()
        {
            InitializeComponent();
            pnupload.AllowDrop = true;
            pnupload.DragEnter += pnupload_Paint;
            pnupload.DragDrop += pnupload_Paint;
        }

        public void exibir_inserir_Load(object sender, EventArgs e)
        {
            
        }

        private void pnupload_Paint(object sender, PaintEventArgs e) { 
        
        }

        private void pnupload_Paint(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Permite a operação de arrastar
                e.Effect = DragDropEffects.Copy;
            }
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Verifica se há pelo menos um arquivo
        }

        private void btnvermn_Click(object sender, EventArgs e)
        {

        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os arquivos|*.*";

            openFileDialog.Title = "Selecione uma imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaImagem = openFileDialog.FileName;
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = "INSERT INTO Imagens Values(@CaminhoImagem)";
                sqlCommand.Parameters.AddWithValue("@CaminhoImagem", caminhoDaImagem);
                try
                {
                    //Insere o cliente
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    throw new Exception("Erro: Problemas ao inserir colaborador no banco.\n"
                        + err.Message);
                }
                finally
                {
                    connection.CloseConnection();
                }
                MessageBox.Show(
                    "Cadastrado com Sucesso",
                    "CADASTRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                //pictureBox1.Image = new System.Drawing.Bitmap(caminhoDaImagem);
            }
        }

        private void btnupload_Click(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Permite a operação de arrastar
                e.Effect = DragDropEffects.Copy;
            }
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
