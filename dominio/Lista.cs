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
                data.setQuery("select art.Id ArtId, Codigo, Nombre, Descripcion artDescrip, imagenUrl imagen FROM Articulos art, IMAGENES img where art.Id = img.IdArticulo");
                data.execute();

                while (data.sqlReader.Read())
                {
                    Article aux = new Article();
                    aux.ArticleId = (int)data.sqlReader["ArtId"];
                    aux.Name = (string)data.sqlReader["Nombre"];
                    aux.Description = (string)data.sqlReader["artDescrip"];
                    aux.ArticleCode = (string)data.sqlReader["Codigo"];
                    aux.Image = (string)data.sqlReader["imagen"];
               
                   // aux.ArticleCategory = new Category();
                    //aux.ArticleCategory.Description = (string)data.sqlReader["descrip"];
                    
                   // aux.ArticleBrand = new Brand();
                    //aux.ArticleBrand.Description = (string)data.sqlReader["marca"];
              
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
        public void Add(Article Nuevo)
        {
            DataAccess acces = new DataAccess();

            try
            {
                acces.setQuery("INSERT INTO ARTICULOS (Nombre, Descripcion) values('" + Nuevo.Name + "', '" + Nuevo.Description + "')");
                acces.executeAction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                acces.close();
            }
        }
    }

    
}

