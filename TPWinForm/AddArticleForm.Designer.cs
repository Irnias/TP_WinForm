namespace TPWinForm
{
    partial class AddArticleFom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArticleFom));
            this.ArticleCode = new System.Windows.Forms.Label();
            this.txtArticleCode = new System.Windows.Forms.TextBox();
            this.txtArticleName = new System.Windows.Forms.TextBox();
            this.ArticleName = new System.Windows.Forms.Label();
            this.txtArticleDescription = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.txtArticlePrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pbxImages = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancelAddArticle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).BeginInit();
            this.SuspendLayout();
            // 
            // ArticleCode
            // 
            resources.ApplyResources(this.ArticleCode, "ArticleCode");
            this.ArticleCode.Name = "ArticleCode";
            this.ArticleCode.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtArticleCode
            // 
            resources.ApplyResources(this.txtArticleCode, "txtArticleCode");
            this.txtArticleCode.Name = "txtArticleCode";
            // 
            // txtArticleName
            // 
            resources.ApplyResources(this.txtArticleName, "txtArticleName");
            this.txtArticleName.Name = "txtArticleName";
            // 
            // ArticleName
            // 
            resources.ApplyResources(this.ArticleName, "ArticleName");
            this.ArticleName.Name = "ArticleName";
            // 
            // txtArticleDescription
            // 
            resources.ApplyResources(this.txtArticleDescription, "txtArticleDescription");
            this.txtArticleDescription.Name = "txtArticleDescription";
            // 
            // Description
            // 
            resources.ApplyResources(this.Description, "Description");
            this.Description.Name = "Description";
            // 
            // labelBrand
            // 
            resources.ApplyResources(this.labelBrand, "labelBrand");
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelImage
            // 
            resources.ApplyResources(this.labelImage, "labelImage");
            this.labelImage.Name = "labelImage";
            this.labelImage.Click += new System.EventHandler(this.labelImage_Click);
            // 
            // cboBrand
            // 
            this.cboBrand.FormattingEnabled = true;
            resources.ApplyResources(this.cboBrand, "cboBrand");
            this.cboBrand.Name = "cboBrand";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            resources.ApplyResources(this.cboCategory, "cboCategory");
            this.cboCategory.Name = "cboCategory";
            // 
            // labelCategory
            // 
            resources.ApplyResources(this.labelCategory, "labelCategory");
            this.labelCategory.Name = "labelCategory";
            // 
            // txtArticlePrice
            // 
            resources.ApplyResources(this.txtArticlePrice, "txtArticlePrice");
            this.txtArticlePrice.Name = "txtArticlePrice";
            // 
            // labelPrice
            // 
            resources.ApplyResources(this.labelPrice, "labelPrice");
            this.labelPrice.Name = "labelPrice";
            // 
            // pbxImages
            // 
            resources.ApplyResources(this.pbxImages, "pbxImages");
            this.pbxImages.Name = "pbxImages";
            this.pbxImages.TabStop = false;
            this.pbxImages.Click += new System.EventHandler(this.pbxImages_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelAddArticle
            // 
            resources.ApplyResources(this.btnCancelAddArticle, "btnCancelAddArticle");
            this.btnCancelAddArticle.Name = "btnCancelAddArticle";
            this.btnCancelAddArticle.UseVisualStyleBackColor = true;
            this.btnCancelAddArticle.Click += new System.EventHandler(this.btnCancellAddArticle);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // AddArticleFom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelAddArticle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbxImages);
            this.Controls.Add(this.txtArticlePrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.txtArticleDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.txtArticleName);
            this.Controls.Add(this.ArticleName);
            this.Controls.Add(this.txtArticleCode);
            this.Controls.Add(this.ArticleCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddArticleFom";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArticleCode;
        private System.Windows.Forms.TextBox txtArticleCode;
        private System.Windows.Forms.TextBox txtArticleName;
        private System.Windows.Forms.Label ArticleName;
        private System.Windows.Forms.TextBox txtArticleDescription;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox txtArticlePrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.PictureBox pbxImages;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancelAddArticle;
        private System.Windows.Forms.Label label1;
    }
}