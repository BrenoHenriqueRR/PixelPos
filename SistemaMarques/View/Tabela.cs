using iText.Layout.Splitting;
using SistemaMarques.View;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaMarques
{
    public partial class Tabela : Form
    {
        private int pageSize = 10;
        private int currentPage = 0;


        public Tabela()
        {
            InitializeComponent();

            // lvtabela.View = View.Details;
            lvtabela.Columns.Add("id", 80);
            lvtabela.Columns.Add("nome_album", 110);
            lvtabela.Columns.Add("nome_cli", 250);
            lvtabela.Columns.Add("email_cli", 250);
            lvtabela.Columns.Add("album_criacao", 150);
            StartPosition = FormStartPosition.Manual;
            this.Left = 0;
        }

        private string i;
        private void Galeria_Load(object sender, EventArgs e)
        {
            lvtabela.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Imagens";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();
                int cont = 1;
                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr["id"].ToString());
                    lv.SubItems.Add(dr["nome_album"].ToString());
                    lv.SubItems.Add(dr["nome_cli"].ToString());
                    lv.SubItems.Add(dr["email_cli"].ToString());
                    lv.SubItems.Add(dr["album_criacao"].ToString());
                    lvtabela.Items.Add(lv);
                    if (cont < 10)
                    {
                        i = dr["id"].ToString();
                        cont++;
                    }
                    else
                    {
                        break;
                    }
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pixelPOSDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            int indiceLinhaSelecionada;
            if (lvtabela.SelectedItems.Count > 0)
            {
                indiceLinhaSelecionada = lvtabela.SelectedIndices[0];
                int id = Convert.ToInt32(lvtabela.Items[indiceLinhaSelecionada].SubItems[0].Text);
                /*sqlCom.Connection = conn.ReturnConnection();
                sqlCom.CommandText = "DELETE FROM fotos WHERE id = @id";
                sqlCom.Parameters.AddWithValue("@id", id);
                sqlCom.ExecuteNonQuery();*/

                // Exclui o registro da outra tabela (substitua 'OutraTabela' pelo nome real)


                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    try
                    {
                        //deleta por id
                        sqlCom.Connection = conn.ReturnConnection();
                        sqlCom.CommandText = "DELETE FROM Imagens WHERE id = @id";
                        sqlCom.Parameters.AddWithValue("@id", id);
                        sqlCom.ExecuteNonQuery();
                        MessageBox.Show(
                        "Album deletado com Sucesso",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                       );
                        lvtabela.Items.RemoveAt(indiceLinhaSelecionada);
                    }
                    catch (Exception err)
                    {
                        throw new Exception("Erro: Problemas ao inserir colaborador no banco.\n"
                            + err.Message);
                    }
                    finally
                    {
                        conn.CloseConnection();
                    }
                }
                else
                {
                    return;
                }
            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (lvtabela.SelectedItems.Count > 0)
            {
                ListViewItem lvid = lvtabela.SelectedItems[0];
                string sid = lvid.SubItems[0].Text;
                int editarid = Convert.ToInt32(sid);


                Editar editar = new Editar(editarid);
                editar.ShowDialog();
                Galeria_Load(sender, e);
            }
        }

        private void btnimagens_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            int indiceLinhaSelecionada;
            if (lvtabela.SelectedItems.Count > 0)
            {
                indiceLinhaSelecionada = lvtabela.SelectedIndices[0];
                int id = Convert.ToInt32(lvtabela.Items[indiceLinhaSelecionada].SubItems[0].Text);
                sqlCom.Connection = conn.ReturnConnection();
                sqlCom.CommandText = "SELECT * FROM Imagens WHERE id = @id";
                sqlCom.Parameters.AddWithValue("@id", id);

                    //executa a query e manda para o outro form
                    SqlDataReader query = sqlCom.ExecuteReader();
                    // Imagens imagens = new Imagens(query);
                    // imagens.ShowDialog();
                    Exibir_imagens imagens = new Exibir_imagens(query);
                    imagens.ShowDialog();


                conn.CloseConnection();
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            string dataString = txbpesquisar.Text;
            DateTime album;
            DateTime.TryParse(dataString, out album);


            if (txbpesquisar.Text == "")
            {
                Galeria_Load(sender, e);
            }
            else
            {
                sqlCom.Connection = conn.ReturnConnection();
                sqlCom.CommandText = @"SELECT * FROM Imagens 
                                        WHERE id Like @searchTerm 
                                        OR nome_album LIKE @searchTerm 
                                        OR nome_cli LIKE @searchTerm 
                                        OR email_cli LIKE @searchTerm";
                sqlCom.Parameters.AddWithValue("@searchTerm", "%" + txbpesquisar.Text + "%");
                try
                {
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    lvtabela.Items.Clear();
                    //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr["id"].ToString());
                        //lv.SubItems.Add(dr["imagens_binar"].ToString());
                        lv.SubItems.Add(dr["nome_album"].ToString());
                        lv.SubItems.Add(dr["nome_cli"].ToString());
                        lv.SubItems.Add(dr["email_cli"].ToString());
                        lv.SubItems.Add(dr["album_criacao"].ToString());

                        lvtabela.Items.Add(lv);
                        txbpesquisar.Clear();
                    }
                    dr.Close();
                }
                catch (Exception err)
                {
                    throw new Exception("Erro: Problemas ao inserir colaborador no banco.\n"
                        + err.Message);
                }
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if(lvtabela.Items.Count < 10) return;
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"SELECT * FROM Imagens Where id > @id";
            sqlCom.Parameters.AddWithValue("@id", i);
            int cont = 1;
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();
                lvtabela.Items.Clear();
                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr["id"].ToString());
                    //lv.SubItems.Add(dr["imagens_binar"].ToString());
                    lv.SubItems.Add(dr["nome_album"].ToString());
                    lv.SubItems.Add(dr["nome_cli"].ToString());
                    lv.SubItems.Add(dr["email_cli"].ToString());
                    lv.SubItems.Add(dr["album_criacao"].ToString());
                    lvtabela.Items.Add(lv);
                    txbpesquisar.Clear();
                    if (cont < 10)
                    {
                        i = dr["id"].ToString();
                        cont++;
                    }
                    else
                    {
                        break;
                    }
                }
                dr.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir colaborador no banco.\n"
                    + err.Message);
            }

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();

            sqlCom.CommandText = @"SELECT * FROM Imagens";
            sqlCom.Parameters.AddWithValue("@id", i);
            int cont = 1;
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();
                lvtabela.Items.Clear();
                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr["id"].ToString());
                    //lv.SubItems.Add(dr["imagens_binar"].ToString());
                    lv.SubItems.Add(dr["nome_album"].ToString());
                    lv.SubItems.Add(dr["nome_cli"].ToString());
                    lv.SubItems.Add(dr["email_cli"].ToString());
                    lv.SubItems.Add(dr["album_criacao"].ToString());
                    lvtabela.Items.Add(lv);
                    txbpesquisar.Clear();
                    if (cont < 10)
                    {
                        i = dr["id"].ToString();
                        cont++;
                    }
                    else
                    {
                        break;
                    }
                }
                dr.Close();
             
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir colaborador no banco.\n"
                    + err.Message);
            }
        }
       /* private int GetTotalItemsCount()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            // Use SqlCommand para contar o número total de itens
            sqlCom.CommandText = ("SELECT COUNT(*) FROM Imagens");
            return Convert.ToInt32(sqlCom.ExecuteScalar());

        }*/
     /*   private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                lvtabela.VirtualListSize = GetTotalItemsCount(); // Atualize a lista virtual
                lvtabela.Refresh();
            }
        }*/
    }
}
