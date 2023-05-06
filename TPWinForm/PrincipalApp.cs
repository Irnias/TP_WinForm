using System;
using System.Collections.Generic;
using System.Linq;
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
            cargar();
       
        }

        private void cargar()
        {
            ArticleConector listas = new ArticleConector();
            try
            {
                listArticle = listas.Listar();
                dgvPrincipal.DataSource = listArticle;
                hideColumns();
                cargarImagen(listArticle[0].Image);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void hideColumns()
        {
            dgvPrincipal.Columns["ArticleId"].Visible = false;
            dgvPrincipal.Columns["Image"].Visible = false;
        }

        private void dgvPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null)
            {
                Article seleccionado = (Article)dgvPrincipal.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Image);
            }
        }

        private void cargarImagen(string image)
        {
            try
            {
                List<string> lista = image.Split(',').Select(s => s.Trim()).ToList();
                pbxArticle.Load(lista[0]);
            }
            catch (Exception)
            {

                pbxArticle.Load("https://static.wikia.nocookie.net/videojuego/images/9/9c/Imagen_no_disponible-0.png/revision/latest/thumbnail/width/360/height/360?cb=20170910134200");
            }
           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbxArticle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnModArticle_Click(object sender, EventArgs e)
        {
            Article select;
            select = (Article)dgvPrincipal.CurrentRow.DataBoundItem;
            AddArticleFom mod = new AddArticleFom(select);
            mod.ShowDialog();
            cargar();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ArticleConector articulo = new ArticleConector();
            Article selected;
            try
            {
                selected = (Article)dgvPrincipal.CurrentRow.DataBoundItem;
                articulo.eliminar(selected.ArticleId);
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            //eliminar(true);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
       
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            List<Article> FilterList;
            string filter = txtFilter.Text;

            if (filter.Length >=3 )
            {
                FilterList = listArticle.FindAll(x => x.Name.ToUpper().Contains(filter.ToUpper()) || x.Description.ToUpper().Contains(filter.ToUpper()));
            }
            else
            {
                FilterList = listArticle;
            }

            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = FilterList;
            hideColumns();
        }
    }
}
