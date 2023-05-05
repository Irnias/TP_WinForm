using System;
using System.Collections.Generic;
using System.Windows.Forms;
using domain;

namespace TPWinForm
{
    public partial class PrincipalApp : Form
    {
        private List<Article> listArticle;
    

        public PrincipalApp()
        {
            InitializeComponent();
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            AddArticleFom newForm = new AddArticleFom();
            newForm.ShowDialog();
        }

        private void LoadPrincipalApp(object sender, EventArgs e)
        {
            Lista listas = new Lista();
            listArticle = listas.Listar();
            dgvPrincipal.DataSource = listArticle;
            //dgvPrincipal.Columns["Image"].Visible=false;
            pbxArticle.Load(listArticle[0].Image);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbxArticle_Click(object sender, EventArgs e)
        {

        }
    }
}
