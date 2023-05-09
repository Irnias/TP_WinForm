using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace domain
{
    public class ArticleConector
    {
        public List<Article> Listar()
        {
            List<Article> ArticlesList = new List<Article>();
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("Select A.Id as artId, Nombre as name, A.Descripcion as artDescrip, Codigo as artCode, Precio as price, C.Descripcion as category, A.IdCategoria as categoryId, " +
                    "M.Descripcion as brand, A.IdMarca as brandId From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria And M.Id = A.IdMarca");
                data.execute();

                while (data.sqlReader.Read())
                {
                    Article aux = new Article();
                    aux.ArticleId = (!(data.sqlReader["artId"] is DBNull)) ? (int)data.sqlReader["artId"] : 0;
                    aux.Name = (!(data.sqlReader["name"] is DBNull)) ? (string)data.sqlReader["name"] : "";
                    aux.Description = (!(data.sqlReader["artDescrip"] is DBNull)) ? (string)data.sqlReader["artDescrip"] : "";
                    aux.ArticleCode = (!(data.sqlReader["artCode"] is DBNull)) ? (string)data.sqlReader["artCode"] : "";
                    aux.Price = (!(data.sqlReader["price"] is DBNull)) ? (decimal) data.sqlReader["price"] : 0;
                    aux.ArticleCategory = new Category(
                        (!(data.sqlReader["categoryId"] is DBNull)) ? (int)data.sqlReader["categoryId"] : 0,
                        (!(data.sqlReader["category"] is DBNull)) ? (string)data.sqlReader["category"] : ""
                        );
                    aux.ArticleBrand = new Brand(
                        (!(data.sqlReader["brandId"] is DBNull)) ? (int)data.sqlReader["brandId"] : 0,
                        (!(data.sqlReader["brand"] is DBNull)) ?(string)data.sqlReader["brand"] : ""
                        );
              
                    ArticlesList.Add(aux);
                }
                return ArticlesList;
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

        public void Modify(Article article)
        {
            DataAccess dataAcces = new DataAccess();

            try
            {
                dataAcces.setQuery("update Articulos set Codigo = @cod , Nombre = @name, Descripcion = @description, IdMarca = @idMarca, Precio = @price  where Id= @id");
                dataAcces.setearParametro("@cod", article.ArticleCode);
                dataAcces.setearParametro("@name", article.Name);
                dataAcces.setearParametro("@description", article.Description);
                dataAcces.setearParametro("@idMarca", article.ArticleBrand.Id);
                dataAcces.setearParametro("@id", article.ArticleId);
                dataAcces.setearParametro("@price", article.Price);

                dataAcces.executeAction();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dataAcces.close();
            }

        }

        public int CreateNewArticle(Article newArt)
        {
            DataAccess acces = new DataAccess();

            try
            {
                string query = "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, Precio) OUTPUT Inserted.ID values('" + newArt.ArticleCode + "', '" + newArt.Name + "', '" + newArt.Description +"', " + newArt.ArticleBrand.Id + ", " +newArt.Price + ")";
                acces.setQuery(query);
                int newArticleId = (int) acces.executeScalar();
                acces.ClearQuery();

                acces.setQuery("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) values(" + newArticleId + ", '"+ newArt.Image + "')");
                acces.executeAction();
                return newArticleId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Listar();
                acces.close();
            }
        }

        public void eliminar(int id)
        {
            try
            {
                DataAccess data = new DataAccess();
                data.setQuery("delete from Articulos where id = @id");
                data.setearParametro("@id", id);
                data.executeAction();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Article> filtrar(string campo, string criterio, string filter)
         {
            List<Article> list = new List<Article>();
            DataAccess data = new DataAccess();
            try
            {
                string consulta = "Select A.Id artId, A.Codigo cod, A.Nombre name, A.Descripcion descrip, A.Precio price, M.Descripcion brand, M.Id brandId, C.Descripcion category, C.Id categoryId From ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdCategoria = A.Id and A.Id = A.IdMarca and   ";

                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "price > " + filter;
                            break;
                        case "Menor A":
                            consulta += "price < " + filter;
                            break;
                        case "Descripcion":
                            consulta += "price = " + filter;
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "name like '" + filter + "%'";

                            break;
                        case "Termina con":
                            consulta += "name like '%'" + filter + "'";
                            break;
                        case "Contiene":
                            consulta += "name like '%" + filter + "%'";
                            break;
                    }
                }
                else if(category == "Descripcion")
                    switch (category)
                    {
                        case "Que comience con ":
                            consulta += "A.Descripcion like '" + filter + "%' ";
                            break;
                        case "Que contenga ":
                            consulta += "A.Descripcion like '%" + filter + "%'";
                            break;
                        case "Que termine con ":
                            consulta += "A.Descripcion like '%" + filter + "'";
                            break;
                    }

                data.setQuery(consulta);
                data.execute();
                while (data.sqlReader.Read())
                {
                    Article aux = new Article();
                    aux.ArticleId = (int)data.sqlReader["artId"];
                    aux.Price = (int)data.sqlReader["price"];
                    aux.ArticleCode = (string)data.sqlReader["cod"];
                    aux.Name = (string)data.sqlReader["name"];
                    aux.Description = (string)data.sqlReader["descrip"];

                    aux.ArticleBrand = new Brand();
                    aux.ArticleBrand.Description = (string)data.sqlReader["brand"];
                    aux.ArticleBrand.Id = (int)data.sqlReader["brandId"];

                    aux.ArticleCategory = new Category();
                    aux.ArticleCategory.Id = (int)data.sqlReader["categoryId"];
                    aux.ArticleCategory.Description = (string)data.sqlReader["category"];


                    list.Add(aux);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }

    
}

