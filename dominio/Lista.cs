using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace domain
{
    public class Lista
    {
        public List<Article> Listar()
        {
            List<Article> Listas = new List<Article>();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true ";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select Nombre FROM ARTICULOS";
                command.Connection = connection;

                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Article aux = new Article();
                    aux.Name = (string)reader["Nombre"];

                    Listas.Add(aux);
                }
                connection.Close();
                return Listas;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

