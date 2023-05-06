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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalApp));
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.pbxArticle = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModArticle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticle)).BeginInit();
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
            this.btnAddArticle.Text = "CreateNewArticle Article";
            this.btnAddArticle.UseVisualStyleBackColor = false;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Location = new System.Drawing.Point(26, 24);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.Size = new System.Drawing.Size(427, 172);
            this.dgvPrincipal.TabIndex = 1;
            this.dgvPrincipal.SelectionChanged += new System.EventHandler(this.dgvPrincipal_SelectionChanged);
            // 
            // pbxArticle
            // 
            this.pbxArticle.BackColor = System.Drawing.Color.White;
            this.pbxArticle.Location = new System.Drawing.Point(127, 227);
            this.pbxArticle.Name = "pbxArticle";
            this.pbxArticle.Size = new System.Drawing.Size(215, 175);
            this.pbxArticle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticle.TabIndex = 2;
            this.pbxArticle.TabStop = false;
            this.pbxArticle.Click += new System.EventHandler(this.pbxArticle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModArticle
            // 
            this.btnModArticle.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModArticle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModArticle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModArticle.Location = new System.Drawing.Point(144, 436);
            this.btnModArticle.Name = "btnModArticle";
            this.btnModArticle.Size = new System.Drawing.Size(75, 23);
            this.btnModArticle.TabIndex = 4;
            this.btnModArticle.Text = "Mod Article";
            this.btnModArticle.UseVisualStyleBackColor = false;
            this.btnModArticle.Click += new System.EventHandler(this.btnModArticle_Click);
            // 
            // PrincipalApp
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(494, 471);
            this.Controls.Add(this.btnModArticle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbxArticle);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.btnAddArticle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(510, 510);
            this.MinimumSize = new System.Drawing.Size(510, 510);
            this.Name = "PrincipalApp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Articulos";
            this.Load += new System.EventHandler(this.LoadPrincipalApp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.PictureBox pbxArticle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModArticle;
    }
}

