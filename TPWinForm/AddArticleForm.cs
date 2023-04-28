using System;
using System.Windows.Forms;
using core;
using domain;

namespace TPWinForm
{
    public partial class AddArticleFom : Form
    {
        public AddArticleFom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddArticle_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelImage_Click(object sender, EventArgs e)
        {

        }

        private void btnCancellAddArticle(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string codArticle = txtArticleCode.Text;
            string nameArticle = txtArticleName.Text;
            string descArticle = txtArticleDescription.Text;
            // string branArticle = comboBox1.SelectedItem.ToString();
            // string catArticle = comboBox2.SelectedItem.ToString();
            string priceArticle = txtArticlePrice.Text;

            string datos = codArticle + "  " + nameArticle + "  " + descArticle + "  " +  priceArticle;

            MessageBox.Show(datos);

            DataHandler dataHandler = new DataHandler();
            Article newArticle = new Article();

            newArticle.Name = nameArticle;
            newArticle.ArticleCode = codArticle;

            dataHandler.addArticle()

        }
    }
}
