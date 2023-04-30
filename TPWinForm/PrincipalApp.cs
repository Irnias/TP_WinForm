using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain;

namespace TPWinForm
{
    public partial class PrincipalApp : Form
    {
        private static readonly Random getRandom = new Random();

        public PrincipalApp()
        {
            InitializeComponent();
        }

        private List<Article> GetInitialValues()
        {
            List<Article> ArticlesList = new List<Article>();
            Article aux = new Article();

            aux.ArticleCode = getRandom.Next(100, 999);
            aux.Name = "Apple 14";
            aux.Description = "Telefono de ultima generacion";
            aux.ArticleBrand = buildDummyBrand();
            aux.ArticleCategory = buildDummyCategory();
            aux.Image = "url";
            aux.Price = getRandom.Next(1000, 9999);
            ArticlesList.Add(aux);
            return ArticlesList;

        }

        private Brand buildDummyBrand()
        {
            Brand brand = new Brand();
            brand.Id = getRandom.Next(1000, 9999);
            brand.Name = "Apple";
            return brand;
        }

        private Category buildDummyCategory()
        {
            Category category = new Category();
            category.Id = getRandom.Next(1000, 9999);
            category.Name = "Celphone";
            return category;
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            AddArticleFom newForm = new AddArticleFom();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void LoadPrincipalApp(object sender, EventArgs e)
        {

        }

        private void dgvArticle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
