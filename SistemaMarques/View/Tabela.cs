﻿using SistemaMarques.View;
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
        private int Id;
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

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr["id"].ToString());
                    lv.SubItems.Add(dr["nome_album"].ToString());
                    lv.SubItems.Add(dr["nome_cli"].ToString());
                    lv.SubItems.Add(dr["email_cli"].ToString());
                    lv.SubItems.Add(dr["album_criacao"].ToString());


                    lvtabela.Items.Add(lv);
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
                sqlCom.Connection = conn.ReturnConnection();
                sqlCom.CommandText = "DELETE FROM Imagens WHERE id = @id";
                sqlCom.Parameters.AddWithValue("@id", id);
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    try
                    {
                        //deleta por id
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
                
                try
                {
                    //executa a query e manda para o outro form
                    SqlDataReader query = sqlCom.ExecuteReader();
                    MessageBox.Show(id.ToString());
                    Imagens imagens = new Imagens(query);
                    imagens.ShowDialog();
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
               // sqlCom.Parameters.AddWithValue("@searchTerm2", "%" + album + "%");
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
    }
}
