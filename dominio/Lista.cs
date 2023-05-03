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
                data.setQuery("select Codigo, Nombre, art.Descripcion artDescrip, cat.Descripcion descrip, marc.Descripcion marca FROM Articulos art, CATEGORIAS cat, MARCAS marc where art.IdCategoria = cat.Id and marc.Id = art.IdMarca");
                data.execute();

                while (data.sqlReader.Read())
                {
                    Article aux = new Article();
                    aux.Name = (string)data.sqlReader["Nombre"];
                    aux.Description = (string)data.sqlReader["artDescrip"];
                    aux.ArticleCode = (string)data.sqlReader["Codigo"];
               
                    aux.ArticleCategory = new Category();
                    aux.ArticleCategory.Description = (string)data.sqlReader["descrip"];
                    
                    aux.ArticleBrand = new Brand();
                    aux.ArticleBrand.Description = (string)data.sqlReader["marca"];

                    aux.ArticleImage = new Image();
                   // aux.ArticleImage.ArtImage = (string)data.sqlReader["https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542"]
              
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

