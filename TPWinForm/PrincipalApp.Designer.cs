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
            this.dgvArticle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArticle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddArticle.Location = new System.Drawing.Point(26, 436);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(75, 23);
            this.btnAddArticle.TabIndex = 0;
            this.btnAddArticle.Text = "Add Article";
            this.btnAddArticle.UseVisualStyleBackColor = false;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // dgvArticle
            // 
            this.dgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticle.Location = new System.Drawing.Point(66, 43);
            this.dgvArticle.Name = "dgvArticle";
            this.dgvArticle.Size = new System.Drawing.Size(351, 347);
            this.dgvArticle.TabIndex = 2;
            this.dgvArticle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticle_CellContentClick);
            // 
            // PrincipalApp
            // 
            this.ClientSize = new System.Drawing.Size(494, 471);
            this.Controls.Add(this.dgvArticle);
            this.Controls.Add(this.btnAddArticle);
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(510, 510);
            this.MinimumSize = new System.Drawing.Size(510, 510);
            this.Name = "PrincipalApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.DataGridView dgvArticle;
    }
}

