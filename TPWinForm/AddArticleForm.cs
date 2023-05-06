using commerce;
using domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPWinForm
{
    public partial class AddArticleFom : Form
    {
        private Article article = null;
        public AddArticleFom()
        {
            InitializeComponent();
        }
        public AddArticleFom(Article article)
        {
            InitializeComponent();
            this.article = article;
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AddArticle_Load(object sender, EventArgs e)
        {
            ListaDesplegables desplegables = new ListaDesplegables();
            CategoryConector categotyConector = new CategoryConector();

            try
            {


                cboCategory.DataSource = categotyConector.GetCategories();
                cboCategory.ValueMember = "Id";
                cboCategory.DisplayMember = "Description";

                cboBrand.DataSource = desplegables.Listar();
                cboBrand.ValueMember = "Id";
                cboBrand.DisplayMember = "Description";

                if (article != null)
                {
                    txtArticleCode.Text = article.ArticleCode;
                    txtArticleName.Text = article.Name;
                    txtArticleDescription.Text = article.Description;
                    txtUrlImage.Text = article.Image;
                    txtArticlePrice.Text = article.Price.ToString();
                    //cargarimagen(article.Image);
                    cboBrand.SelectedValue = article.ArticleBrand.Id;
                    cboCategory.SelectedValue = article.ArticleCategory.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelImage_Click(object sender, EventArgs e)
        {

        }

        private void btnCancellAddArticle(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Article newArt = new Article();
            ArticleConector ArticleListConector = new ArticleConector();

            try
            {
                if (article == null)
                    article = new Article();

                article.Name = txtArticleName.Text;
                article.Description = txtArticleDescription.Text;
                article.Image = txtUrlImage.Text;
                article.ArticleBrand = (Brand)cboBrand.SelectedItem;
                article.ArticleCategory = (Category)cboCategory.SelectedItem;
                article.Price = decimal.Parse(txtArticlePrice.Text);
                article.ArticleCode = txtArticleCode.Text;

                if (article.ArticleId != 0)
                {
                    ArticleListConector.Modifity(article);
                    MessageBox.Show("Se modifico el articulo");
                }
                else
                {
                    int newArtID = (int)ArticleListConector.CreateNewArticle(article);
                    MessageBox.Show("se agrego el id " + newArtID);
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void pbxImages_Click(object sender, EventArgs e)
        {

        }


        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArticleConector brand = new ArticleConector();
            try
            {
                //cboBrand.DataSource = Brand.FetchCategories();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ArticleConector categor;
        }

        private void txtUrlImage_Leave(object sender, EventArgs e)
        {
            cargarimagen(txtUrlImage.Text);
        }

        private void cargarimagen(string imagen)
        {
            try
            {
                pbxImages.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxImages.Load("https://static.wikia.nocookie.net/videojuego/images/9/9c/Imagen_no_disponible-0.png/revision/latest/thumbnail/width/360/height/360?cb=20170910134200");
            }
        }
    }
}
