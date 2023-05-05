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
            Lista newList = new Lista();

            try
            {
                newArt.Name = txtArticleName.Text;
                newArt.Description = txtArticleDescription.Text;

                newList.Add(newArt);
                MessageBox.Show("se agrego");
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
            Lista brand = new Lista();
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
            //Lista categor;
        }
    }
}
