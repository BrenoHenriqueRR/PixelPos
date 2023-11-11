using SistemaMarques.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMarques.View
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
            lvalbunscriados.Columns.Add("Total de albuns");
            Left = 0;

        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
        }

        private void mcData_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            DateTime dataInicio = mcData.SelectionRange.Start;
            DateTime dataFim = mcData.SelectionRange.End;

            string dataFormatadaI = dataInicio.ToString("yyyy/MM/dd HH:mm:ss");
            string dataFormatadaF = dataFim.ToString("yyyy/MM/dd HH:mm:ss");

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @" Set dateformat ymd
                                    SELECT COUNT(*) as TotalAlbuns 
                                    FROM Imagens 
                                    WHERE album_criacao >= @datainicial 
                                    AND album_criacao <= @datafinal";
            sqlCom.Parameters.AddWithValue("@datainicial", dataFormatadaI);
            sqlCom.Parameters.AddWithValue("@datafinal", dataFormatadaF);
            SqlDataReader dr = sqlCom.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["TotalAlbuns"].ToString());
                //string teste3 = dr.ToString();
                lvalbunscriados.Items.Add(lv);
            }
            //ListViewItem lv = new ListViewItem(dr["Totalalbuns"].ToString());
            //lvalbunscriados.Items.Add(lv);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lvalbunscriados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            DateTime dataInicio = mcData.SelectionRange.Start;
            DateTime dataFim = mcData.SelectionRange.End;

            string dataFormatadaI = dataInicio.ToString("yyyy/MM/dd HH:mm:ss");
            string dataFormatadaF = dataFim.ToString("yyyy/MM/dd HH:mm:ss");

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @" Set dateformat ymd
                                    SELECT * FROM Imagens 
                                    WHERE album_criacao >= @datainicial 
                                    AND album_criacao <= @datafinal";
            sqlCom.Parameters.AddWithValue("@datainicial", dataInicio);
            sqlCom.Parameters.AddWithValue("@datafinal", dataFim);

            SqlDataReader dr = sqlCom.ExecuteReader();
            Excel excel = new Excel();
            excel.gerarExcel(dr);
        }
    }
}
