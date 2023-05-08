﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using domain;
using commerce;

namespace TPWinForm
{
    public partial class PrincipalApp : Form
    {
        private List<Article> listArticle;
        ImageConector imageConector = new ImageConector();

        public PrincipalApp()
        {
            InitializeComponent();
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            AddArticleFom newForm = new AddArticleFom();
            newForm.ShowDialog();
            load();
        }

        private void LoadPrincipalApp(object sender, EventArgs e)
        {
            load();
            cboBrand.Items.Add("Sony");
            cboBrand.Items.Add("Apple");
            cboBrand.Items.Add("Samsung");
            cboBrand.Items.Add("Huawei");
            cboBrand.Items.Add("Motorola");
            cboCategory.Items.Add("Televisores");
            cboCategory.Items.Add("Media");
            cboCategory.Items.Add("Celulares");
        }

        private void load()
        {
            ArticleConector listas = new ArticleConector();
            try
            {
                listArticle = listas.Listar();
                dgvPrincipal.DataSource = listArticle;
                hideColumns();
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
                imageConector.FindImageById(seleccionado.ArticleId);
                showImage(imageConector.GetCurremtImg());
            }
        }

        private void showImage(string image)
        {
            try
            {
                pbxArticle.Load(image);
            }
            catch (Exception)
            {
                pbxArticle.Load("https://static.wikia.nocookie.net/videojuego/images/9/9c/Imagen_no_disponible-0.png/revision/latest/thumbnail/width/360/height/360?cb=20170910134200");
            }

        }

        private void pbxArticle_Click(object sender, EventArgs e)
        {

        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            imageConector.Next();
            showImage(imageConector.GetCurremtImg());
        }

        private void btnPrevImage_Click(object sender, EventArgs e)
        {
            imageConector.Previous();
            showImage(imageConector.GetCurremtImg());
        }


        private void btnModArticle_Click(object sender, EventArgs e)
        {
            try
            {
                Article select;
                if (dgvPrincipal.CurrentRow == null)
                {
                    MessageBox.Show("Eliga un articulo para continuar");
                }
                else { 
                    select = (Article)dgvPrincipal.CurrentRow.DataBoundItem;
                    AddArticleFom mod = new AddArticleFom(select);
                    mod.ShowDialog();
                    load();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Eliga un articulo para continuar");
               
            }
        }

        
        

        private void Delete_Click(object sender, EventArgs e)
        {
            ArticleConector articulo = new ArticleConector();
            Article selected;
            try
            {
                DialogResult mensaje = MessageBox.Show("Se borrará el articulo seleccionado ¿Deseas continuar?", "Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mensaje == DialogResult.Yes)
                {
                    selected = (Article)dgvPrincipal.CurrentRow.DataBoundItem;
                    articulo.eliminar(selected.ArticleId);
                    load();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

       
        private bool validarFiltro()
        {
            if (cboBrand.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una marca");
                return true;
            }
            if (cboCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una categoria");
                return true;
            }
            return false;
        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            ArticleConector art = new ArticleConector();
            try
            {
                if (validarFiltro())
                    return;
                string brand = cboBrand.SelectedItem.ToString();
                string category = cboCategory.SelectedItem.ToString();
                //string filter = txtFilter.Text;
                dgvPrincipal.DataSource = art.filtrar(brand, category);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
