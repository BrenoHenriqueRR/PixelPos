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

namespace SistemaMarques
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            string data_nasc = msktxbdate.Text;
            msktxbdate.TextChanged += (obj, args) =>
            {
                if (DateTime.TryParse(msktxbdate.Text, out DateTime data)){
                    if (data.Month > 12)
                    {
                        MessageBox.Show("Mês inválido. Insira um mês de 1 a 12.");
                        msktxbdate.Clear(); // Limpa o TextBox
                    }
                }
                else
                {
                    MessageBox.Show("Data inválida. Insira uma data válida no formato correto.");
                    msktxbdate.Clear(); // Limpa o TextBox
                }
            };

            string senha1 = txbsenha.Text;
            string senha2 = txbsenhafirme.Text;
           
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO TB_Cadastro VALUES 
            (@NOME,@Data_de_nascimento,@email,@senha,@CPF,@Gender)";

            sqlCommand.Parameters.AddWithValue("@NOME", txbfistname.Text);
            sqlCommand.Parameters.AddWithValue("@Data_de_nascimento", msktxbdate.Text);
            sqlCommand.Parameters.AddWithValue("@email", txbemailCadastrar.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txbsenha.Text);
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

            if (string.IsNullOrWhiteSpace(txbemailCadastrar.Text))
            {
                
                lbemailregister.ForeColor = Color.Red;
                MessageBox.Show(
                            "Campos Vazios!!",
                             "",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error
                             );
                return;
            }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}


