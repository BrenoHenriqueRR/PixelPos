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
using System.Xml.Linq;

namespace SistemaMarques
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM TB_User";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["Id"];
                    string name = (string)dr["Name"];
                    string job = (string)dr["Job"];
                    string email = (string)dr["Email"];
                    string cpf = (string)dr["Cpf"];
                    string gender = (string)dr["Gender"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(job);
                    lv.SubItems.Add(email);
                    lv.SubItems.Add(cpf);
                    lv.SubItems.Add(gender);
                    LtvList.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbName.Clear();
            txbJob.Clear();
            txbEmail.Clear();
            mtbCPF.Clear();
            cmbGender.ResetText();
        }


        private void Pncadastro_Paint(object sender, PaintEventArgs e)
        {
                this.WindowState = FormWindowState.Normal;
        }

        private void lbtextologin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
        }
    }
}
