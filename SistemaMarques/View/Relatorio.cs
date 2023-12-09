using SistemaMarques.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            Left = 0;
            RichTextBox1.ReadOnly = true;
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
        }

        private void mcData_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            helpProvider1.SetHelpString(button3, "Para Selecionar de uma data até a outro no calendario ,Segure o botão shift do teclado!!");
            helpProvider1.SetShowHelp(button3, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                Relatorio_Load(sender, e);
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
                    RichTextBox1.Text = dr["TotalAlbuns"].ToString();
                }
                conn.CloseConnection();
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
            ntiexcel.BalloonTipClicked += ntiexcel_BalloonTipClicked;
            ntiexcel.ShowBalloonTip(3000, "Clique para abrir", "Relatório foi  enviado para os downloads", ToolTipIcon.Info);
        }

        private void ntiexcel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        
        }

        private void ntiexcel_BalloonTipClicked(object sender, EventArgs e)
        {
            pastadownload pastadownload = new pastadownload();
            string diretorioDesejado = pastadownload.GetDownloadsPath();

            // Certifique-se de que o diretório existe antes de tentar abri-lo
            if (System.IO.Directory.Exists(diretorioDesejado))
            {
                Process.Start("explorer.exe", diretorioDesejado);
            }
            else
            {
                MessageBox.Show("O diretório especificado não existe.");
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help.ShowPopup(button3, helpProvider1.GetHelpString(button3), Cursor.Position);
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }


    }
}
