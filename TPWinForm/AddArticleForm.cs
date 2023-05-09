using commerce;
using domain;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace TPWinForm
{
    public partial class AddArticleFom : Form
    {
        private Article article = null;
        private OpenFileDialog file = null;

        public AddArticleFom()
        {
            InitializeComponent();
        }
        public AddArticleFom(Article article)
        {
            InitializeComponent();
            this.article = article;
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
                    cboBrand.SelectedValue = article.ArticleBrand.Id;
                    cboCategory.SelectedValue = article.ArticleCategory.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancellAddArticle(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ArticleConector ArticleListConector = new ArticleConector();

            try
            {
                if (article == null)
                    article = new Article();

                if (string.IsNullOrEmpty(txtArticleName.Text))
                {
                    MessageBox.Show("Ingrese Nombre");
                    return;
                }
                if (string.IsNullOrEmpty(txtArticleCode.Text))
                {
                    MessageBox.Show("Ingrese Codigo");
                    return;
                }
                if (string.IsNullOrEmpty(txtArticleDescription.Text))
                {
                    MessageBox.Show("Ingrese Descripcion");
                    return;
                }
                if (soloNumeros(txtArticlePrice.Text))
                {
                    MessageBox.Show("Ingrese Precio");
                    return;
                }

                article.Name = txtArticleName.Text;
                article.Description = txtArticleDescription.Text;
                article.Image = txtUrlImage.Text;
                article.ArticleBrand = (Brand)cboBrand.SelectedItem;
                article.ArticleCategory = (Category)cboCategory.SelectedItem;
                article.Price = decimal.Parse(txtArticlePrice.Text);
                article.ArticleCode = txtArticleCode.Text;

                if (article.ArticleId != 0)
                {
                    ArticleListConector.Modify(article);
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
            if (file != null && !(txtUrlImage.Text.ToUpper().Contains("HTTP")))
                imagenLocal();
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

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg;|png|*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtUrlImage.Text = file.FileName;
                cargarimagen(file.FileName);
            }
        }

        private void imagenLocal()
        {
            File.Copy(file.FileName, ConfigurationManager.AppSettings["ArticuloApp"] + file.SafeFileName);
        }


        private bool Validaciones()
        {
            if (txtArticleName.SelectedText == "")
            {
                MessageBox.Show("Porfavor, agregue un nombre para su articulo");
                return true;
            }

            if (txtArticleCode.SelectedText == "")
            {
                MessageBox.Show("Porfavor, agruegue un codigo para su articulo");
                return true;
            }
            return false;
        }
        private bool validacionesPrecio(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private bool soloNumeros(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsNumber(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
