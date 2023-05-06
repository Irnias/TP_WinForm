using domain;
using System;
using System.Windows.Forms;

namespace TPWinForm
{
    public partial class AddArticleFom : Form
    {
        public AddArticleFom()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void AddArticle_Load(object sender, EventArgs e)
        {
            ListaDesplegables desplegables = new ListaDesplegables();

            try
            {
                cboBrand.DataSource = desplegables.Listar();
           
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
            Article newArt = new Article();
            ArticleConector ArticleListConector = new ArticleConector();

            try
            {
                newArt.Name = txtArticleName.Text;
                newArt.Description = txtArticleDescription.Text;
                newArt.Image = txtUrlImage.Text;
                newArt.ArticleBrand = (Brand)cboBrand.SelectedItem;
                newArt.ArticleCategory = (Category)cboCategory.SelectedItem;
                newArt.Price = decimal.Parse(txtArticlePrice.Text);
                newArt.ArticleCode = txtArticleCode.Text;

                int newArtID = (int) ArticleListConector.CreateNewArticle(newArt);
                MessageBox.Show("se agrego el id " + newArtID);
                Close();
            }
            catch (Exception ex)
            {

                throw ex;
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
                //cboBrand.DataSource = Brand.Listar();
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
