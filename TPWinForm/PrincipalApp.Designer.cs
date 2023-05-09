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
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnModArticle = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.btnAdvancedSearch = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.btnPrevImage = new System.Windows.Forms.Button();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(155)))), ((int)(((byte)(102)))));
            this.btnAddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArticle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddArticle.Location = new System.Drawing.Point(95, 313);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(75, 23);
            this.btnAddArticle.TabIndex = 0;
            this.btnAddArticle.Text = "CreateNewArticle Article";
            this.btnAddArticle.UseVisualStyleBackColor = false;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(204)))));
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPrincipal.Location = new System.Drawing.Point(15, 69);
            this.dgvPrincipal.MultiSelect = false;
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(517, 172);
            this.dgvPrincipal.TabIndex = 1;
            this.dgvPrincipal.SelectionChanged += new System.EventHandler(this.dgvPrincipal_SelectionChanged);
            // 
            // pbxArticle
            // 
            this.pbxArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(204)))));
            this.pbxArticle.Location = new System.Drawing.Point(560, 69);
            this.pbxArticle.Name = "pbxArticle";
            this.pbxArticle.Size = new System.Drawing.Size(215, 175);
            this.pbxArticle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticle.TabIndex = 2;
            this.pbxArticle.TabStop = false;
            // 
            // btnNextImage
            // 
            this.btnNextImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(108)))), ((int)(((byte)(143)))));
            this.btnNextImage.Location = new System.Drawing.Point(769, 141);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(25, 22);
            this.btnNextImage.TabIndex = 3;
            this.btnNextImage.Text = ">";
            this.btnNextImage.UseVisualStyleBackColor = false;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // btnModArticle
            // 
            this.btnModArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(155)))), ((int)(((byte)(102)))));
            this.btnModArticle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModArticle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModArticle.Location = new System.Drawing.Point(247, 313);
            this.btnModArticle.Name = "btnModArticle";
            this.btnModArticle.Size = new System.Drawing.Size(75, 23);
            this.btnModArticle.TabIndex = 4;
            this.btnModArticle.Text = "Mod Article";
            this.btnModArticle.UseVisualStyleBackColor = false;
            this.btnModArticle.Click += new System.EventHandler(this.btnModArticle_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(155)))), ((int)(((byte)(102)))));
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Delete.Location = new System.Drawing.Point(396, 313);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(187)))));
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(12, 35);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(34, 15);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.Info;
            this.txtFilter.Location = new System.Drawing.Point(56, 32);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(93, 20);
            this.txtFilter.TabIndex = 8;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cboCampo
            // 
            this.cboCampo.BackColor = System.Drawing.SystemColors.Menu;
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(59, 267);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(100, 21);
            this.cboCampo.TabIndex = 11;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboBrand_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.BackColor = System.Drawing.SystemColors.Menu;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(238, 267);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(99, 21);
            this.cboCriterio.TabIndex = 12;
            // 
            // btnAdvancedSearch
            // 
            this.btnAdvancedSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(161)))));
            this.btnAdvancedSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdvancedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvancedSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdvancedSearch.Location = new System.Drawing.Point(548, 266);
            this.btnAdvancedSearch.Name = "btnAdvancedSearch";
            this.btnAdvancedSearch.Size = new System.Drawing.Size(75, 22);
            this.btnAdvancedSearch.TabIndex = 14;
            this.btnAdvancedSearch.Text = "Search";
            this.btnAdvancedSearch.UseVisualStyleBackColor = false;
            this.btnAdvancedSearch.Click += new System.EventHandler(this.btnAdvancedSearch_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(181)))));
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(6, 273);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(47, 15);
            this.lblCampo.TabIndex = 15;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(181)))));
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(180, 273);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(46, 15);
            this.lblCriterio.TabIndex = 16;
            this.lblCriterio.Text = "Criterio";
            // 
            // btnPrevImage
            // 
            this.btnPrevImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(108)))), ((int)(((byte)(143)))));
            this.btnPrevImage.Location = new System.Drawing.Point(548, 141);
            this.btnPrevImage.Name = "btnPrevImage";
            this.btnPrevImage.Size = new System.Drawing.Size(25, 22);
            this.btnPrevImage.TabIndex = 17;
            this.btnPrevImage.Text = "<";
            this.btnPrevImage.UseVisualStyleBackColor = false;
            this.btnPrevImage.Click += new System.EventHandler(this.btnPrevImage_Click);
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(187)))));
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.ForeColor = System.Drawing.Color.Black;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(360, 269);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(34, 15);
            this.lblFiltroAvanzado.TabIndex = 18;
            this.lblFiltroAvanzado.Text = "Filter\r\n";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(409, 268);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroAvanzado.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(638, 262);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // PrincipalApp
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(804, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.btnPrevImage);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnAdvancedSearch);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btnModArticle);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.pbxArticle);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.btnAddArticle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(820, 400);
            this.MinimumSize = new System.Drawing.Size(820, 400);
            this.Name = "PrincipalApp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Articulos";
            this.Load += new System.EventHandler(this.LoadPrincipalApp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.PictureBox pbxArticle;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnModArticle;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Button btnAdvancedSearch;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Button btnPrevImage;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

