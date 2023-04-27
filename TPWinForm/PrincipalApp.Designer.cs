namespace TPWinForm
{
    partial class PrincipalApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Location = new System.Drawing.Point(26, 436);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(75, 23);
            this.btnAddArticle.TabIndex = 0;
            this.btnAddArticle.Text = "Add Article";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // PrincipalApp
            // 
            this.ClientSize = new System.Drawing.Size(494, 471);
            this.Controls.Add(this.btnAddArticle);
            this.IsMdiContainer = true;
            this.Name = "PrincipalApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddArticle;
    }
}

