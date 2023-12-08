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
using SistemaMarques.Controller;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Engineering;
using System.Drawing.Drawing2D;
using System.Data.SqlTypes;

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
        private void inserir_img(int i)
        {
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string teste = Path.Combine(downloadsPath, "Downloads");
            string localPasta = teste;

            try
            {
                // Cria o diretório se ainda não existir
                if (!Directory.Exists(localPasta))
                {
                    Directory.CreateDirectory(localPasta);
                    MessageBox.Show("Pasta criada com sucesso em: " + localPasta);
                }
                else
                {
                    Console.WriteLine("A pasta já existe em: " + localPasta);
                }

                DirectoryInfo pasta = new DirectoryInfo(localPasta);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao criar pasta: " + ex.Message);
            }

            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os arquivos|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Selecione uma imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileNames.Length > 0)
            {
                foreach (var caminhoImagem in openFileDialog.FileNames)
                { 
                    InserirCaminhoNoBanco(caminhoImagem,i);

                }
            }
            else
            {
                MessageBox.Show("Nenhuma imagem selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
    }
        static void InserirCaminhoNoBanco(string caminhoImagem,int i)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "INSERT INTO fotos (id_album,caminho_foto) VALUES (@id_album,@caminho_foto)";
            sqlCom.Parameters.AddWithValue("@caminho_foto", caminhoImagem);
            sqlCom.Parameters.AddWithValue("@id_album", i);
            sqlCom.ExecuteNonQuery();
            conn.CloseConnection();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        { 
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            DateTime dataHoraAtual = DateTime.Now;

            if (string.IsNullOrWhiteSpace(txbnomealbum.Text) ||
               string.IsNullOrWhiteSpace(txbnomecli.Text) ||
               string.IsNullOrWhiteSpace(txbemailcli.Text))
            {
                MessageBox.Show("Campos Vazios!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "INSERT INTO Imagens OUTPUT INSERTED.ID VALUES(@nome_album,@nome_cli,@email_cli,@album_criacao)";
            sqlCommand.Parameters.AddWithValue("@nome_album", txbnomealbum.Text);
            sqlCommand.Parameters.AddWithValue("@nome_cli", txbnomecli.Text);
            sqlCommand.Parameters.AddWithValue("@email_cli", txbemailcli.Text);
            sqlCommand.Parameters.AddWithValue("@album_criacao", dataHoraAtual);
            try
            {
                //Insere o cliente
                int ultimoIdInserido = Convert.ToInt32(sqlCommand.ExecuteScalar());
                inserir_img(ultimoIdInserido);
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

