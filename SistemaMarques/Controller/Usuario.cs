using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMarques.Controller
{
    internal class Usuario
    {
        public int selectEmail(string mail)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"SELECT count(*) as mail FROM TB_Cadastro where email = @email";
            sqlCommand.Parameters.AddWithValue("@email", mail);
            try
            {
                //Insere o cliente
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    if (Convert.ToInt32(dr["mail"]) > 0)
                    {
                        return 0;
                    }
                }
                return 1;
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
        }
    }
}
