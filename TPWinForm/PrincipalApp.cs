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
            AddArticleFom newForm = new AddArticleFom();
            newForm.ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
