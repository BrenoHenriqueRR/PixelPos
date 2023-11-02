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
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            DateTime dataInicio = mcData.SelectionRange.Start;
            DateTime dataFim = mcData.SelectionRange.End;

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"SELECT COUNT(nome_album) FROM imagens WHERE data_criacao >= " + dataInicio +
                " AND data_criacao <" + dataFim;
            SqlDataReader dr = sqlCom.ExecuteReader();
            ListViewItem lv = new ListViewItem(dr["Total de albuns"].ToString());
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
    }
}
