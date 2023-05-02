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
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("select Codigo, Nombre, Descripcion FROM ARTICULOS");
                data.execute();

                while (data.sqlReader.Read())
                {
                    Article aux = new Article();
                    //aux.ArticleCode = (string)reader["Codigo"];
                    aux.Name = (string)data.sqlReader["Nombre"];
                    aux.Description = (string)data.sqlReader["Descripcion"];
                    //aux.Image = (string)reader["https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542"]

                    Listas.Add(aux);
                }
                return Listas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.close();
            }
        }
    }
}

