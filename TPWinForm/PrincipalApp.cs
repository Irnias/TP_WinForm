using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm
{
    public partial class PrincipalApp : Form
    {
        public PrincipalApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
           /* foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(AddArticleFom))
                {
                    return;
                }
            }*/
            
            AddArticleFom newForm = new AddArticleFom();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
