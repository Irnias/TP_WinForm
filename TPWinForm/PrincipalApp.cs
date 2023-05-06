﻿using System;
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
            ArticleConector listas = new ArticleConector();
            listArticle = listas.Listar();
            dgvPrincipal.DataSource = listArticle;
            //dgvPrincipal.Columns["Image"].Visible=false;
            cargarImagen(listArticle[0].Image);

        }
        private void dgvPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            Article seleccionado = (Article)dgvPrincipal.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Image);
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
        }
    }
}
