using SistemaMarques.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMarques.View
{
    public partial class EsqueciSenha : Form
    {
        public EsqueciSenha()
        {
            InitializeComponent();
        }

        private void EsqueciSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            string e_mail = txbemailrecu.Text;
            int x;

            Usuario user = new Usuario();
            int verifica = user.selectEmail(e_mail);
            MessageBox.Show(verifica.ToString());

            if (verifica == 1)
            {
                MessageBox.Show("Email nao Cadastrado!!",
                    "Tente novamente!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {

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
                    x = gerars.gerar();

                    Email html = new Email();
                    string armazena = html.enviarEmail();
                    string testehtml = armazena + @"<p class= ""verification-code"">" + x +
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

                Validaremail validaremail = new Validaremail(x);
                validaremail.ShowDialog();
                bool validado = validaremail.Validarcodigo;
                if (validado)
                {
                    RecuperarSenha senha = new RecuperarSenha(e_mail);
                    senha.ShowDialog();
                }
            }
        }

        private void txbemailrecu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
