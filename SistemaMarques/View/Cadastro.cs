using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net;
using System.Net.Mail;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using SistemaMarques.Controller;

namespace SistemaMarques
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mktxbsenhafirme_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private int i;
        private void button1_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            Usuario user = new Usuario();
            CriarHash gerarhash = new CriarHash();


            string data_nasc = msktxbdate.Text;
            string senha1 = txbsenha.Text;
            string senhacli = gerarhash.criarHash(senha1);
            string senha2 = txbsenhafirme.Text;
            string e_mail = txbemailCadastrar.Text;


            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO TB_Cadastro VALUES 
            (@NOME,@Data_de_nascimento,@email,@senha,@CPF,@Gender)";

            sqlCommand.Parameters.AddWithValue("@NOME", txbfistname.Text);
            sqlCommand.Parameters.AddWithValue("@Data_de_nascimento", msktxbdate.Text);
            sqlCommand.Parameters.AddWithValue("@email", txbemailCadastrar.Text);
            sqlCommand.Parameters.AddWithValue("@senha", senhacli);
            sqlCommand.Parameters.AddWithValue("@CPF", msktxbcpf.Text);
            if (cbfeminino.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@Gender", cbfeminino.Text);
            }
            if (cbmasculino.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@Gender", cbmasculino.Text);
            }
            if (cboutros.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@Gender", cboutros.Text);
            }
            if (senha1 != senha2)
            {
                MessageBox.Show(
                    "Senhas diferentes ,digite novamente!!",
                    "",
                     MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            if (string.IsNullOrWhiteSpace(txbemailCadastrar.Text) ||
                string.IsNullOrWhiteSpace(txbsenha.Text) ||
                string.IsNullOrWhiteSpace(msktxbcpf.Text) ||
                string.IsNullOrWhiteSpace(msktxbdate.Text) ||
                string.IsNullOrWhiteSpace(txbfistname.Text))
            {
                MessageBox.Show("Campos Vazios!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user.selectEmail(e_mail) == 0)
            {
                MessageBox.Show("Email ja existe!! Tente outro!",
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            Thread Mensagem = new Thread(() =>
            {
                MessageBox.Show("Enviando Código de validação por Email\nAguarde...");
            });
            Mensagem.Start();
            try
            {
                string remetente = "SistemaBreno@outlook.com";
                string senha = "Ul100traman";
                string destinatario = e_mail;
                string assunto = "Criação de conta:";
                GerarSenha gerars = new GerarSenha();
                i = gerars.gerar();

                Email html = new Email();
                string armazena = html.enviarEmail();
                string testehtml = armazena + @"<p class= ""verification-code"">" + i +
                                                @"</p> 
                                                </div>
                                                </body>
                                                </html>";
                SmtpClient client = new SmtpClient("smtp.office365.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(remetente, senha);

                MailMessage message = new MailMessage(remetente, destinatario, assunto, testehtml);
                message.IsBodyHtml = true;
                client.Send(message);

                MessageBox.Show("E-mail enviado com sucesso para: " + destinatario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar o email: " + ex.Message);
                return;
            }

            Validaremail validaremail = new Validaremail(i);
            validaremail.ShowDialog();
            bool validado = validaremail.Validarcodigo;
            if (validado)
            {
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
                this.Close();
            }
            else
            {
                return;
            }

        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = txbfistname.Text;
        }

        private void lbfirstname_Click(object sender, EventArgs e)
        {

        }

        private void txbsenhafirme_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbmostrarsenha1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmostrarsenha1.Checked)
            {
                txbsenha.PasswordChar = '\0'; 
            }
            else
            {
                txbsenha.PasswordChar = '*'; 
            }
        }

        private void cbmostrarsenha2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmostrarsenha2.Checked)
            {
                txbsenhafirme.PasswordChar = '\0';
            }
            else
            {
                txbsenhafirme.PasswordChar = '*';
            }
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbfeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbfeminino.Checked)
            {
                cbmasculino.Checked = false;
                cboutros.Checked = false;
            }

        }

        private void cbmasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmasculino.Checked)
            {
                cbfeminino.Checked = false;
                cboutros.Checked = false;
            }
        }

        private void cboutros_CheckedChanged(object sender, EventArgs e)
        {
            if (cboutros.Checked)
            {
                cbfeminino.Checked = false;
                cbmasculino.Checked = false;
            }
        }

        private void msktxbdate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

    }
}


