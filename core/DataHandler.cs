using System;
using System.Collections.Generic;
using domain;

namespace core
{
    public class DataHandler
    {
        List<Article> articles;

        public void addArticle(Article Article)
        {

            try
            {
                articles.Add(Article);
            }
            catch (Exception ex)
            {
                throw ex;
            }
       
        }

        public List<Article> getArticles()
        {
            return articles;
        }

    }
}
