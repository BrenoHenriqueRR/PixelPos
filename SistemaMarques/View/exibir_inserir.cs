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
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.CompilerServices;
using System.Windows.Documents;

namespace SistemaMarques
{
    public partial class exibir_inserir : Form
    {
        public exibir_inserir()
        {
            InitializeComponent();
            this.Left = 0;
        }

        public void exibir_inserir_Load(object sender, EventArgs e)
        {

        }

        private void pnupload_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnupload_Paint(object sender, DragEventArgs e)
        {
          
        }

        private void btnvermn_Click(object sender, EventArgs e)
        {

        }


        private string caminhoimagem;

        private void btnupload_Click(object sender, EventArgs e)
        {
            string LocalPasta = @"C:\Users\breno\OneDrive\Imagens\PixelPos";

            try
            {
                Directory.CreateDirectory(LocalPasta);
                DirectoryInfo pasta = new DirectoryInfo(LocalPasta); 

            }
            catch(Exception err)
            {
                throw new Exception("Erro: Problemas ao criar a pasta.\n"
                    + err.Message);
            }


                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os arquivos|*.*";
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "Selecione uma imagem";
                
            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileNames.Length > 0)
            {
                foreach (var caminhoImagem in openFileDialog.FileNames)
                {
                    //label1.Text = "Quantidade de fotos selecionadas: " + openFileDialog.FileNames.Length;

                    InserirCaminhoNoBanco(caminhoImagem);
                    //this.caminhoimagem = openFileDialog.FileName;
                    //string novoCaminho = Path.Combine(LocalPasta, Path.GetFileName(caminhoimagem));
                    //File.Move(caminhoimagem, novoCaminho);
                    //MessageBox.Show(caminhoimagem);
                }
            }
            else
            {
                return;
            }
         }
        static void InserirCaminhoNoBanco(string caminhoImagem)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "INSERT INTO fotos (id_album,caminho_foto) VALUES (SCOPE_IDENTITY(),@caminho_foto)";
            sqlCom.Parameters.AddWithValue("@caminhoImagem", caminhoImagem);
            sqlCom.ExecuteNonQuery();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        { 
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            DateTime dataHoraAtual = DateTime.Now;
            


            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "INSERT INTO Imagens Values(@nome_album,@nome_cli,@email_cli,@album_criacao)";
            sqlCommand.Parameters.AddWithValue("@nome_album", txbnomealbum.Text);
            sqlCommand.Parameters.AddWithValue("@nome_cli", txbnomecli.Text);
            sqlCommand.Parameters.AddWithValue("@email_cli", txbemailcli.Text);
            sqlCommand.Parameters.AddWithValue("@album_criacao", dataHoraAtual);

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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pninserir_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

