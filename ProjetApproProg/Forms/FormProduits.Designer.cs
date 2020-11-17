namespace ProjetApproProg.Forms
{
    partial class FormProduits
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
            this.components = new System.ComponentModel.Container();
            this.flwPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDroite = new System.Windows.Forms.Panel();
            this.lblNbProduits = new System.Windows.Forms.Label();
            this.btnExporterProduits = new System.Windows.Forms.Button();
            this.pnlOrdonner = new System.Windows.Forms.Panel();
            this.btnSiteDecroissant = new System.Windows.Forms.Button();
            this.btnSiteCroissant = new System.Windows.Forms.Button();
            this.btnTitreDecroissant = new System.Windows.Forms.Button();
            this.btnTitreCroissant = new System.Windows.Forms.Button();
            this.btnPrixDecroissant = new System.Windows.Forms.Button();
            this.btnPrixCroissant = new System.Windows.Forms.Button();
            this.btnTrier = new System.Windows.Forms.Button();
            this.pnlDroite.SuspendLayout();
            this.pnlOrdonner.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwPrincipal
            // 
            this.flwPrincipal.AutoScroll = true;
            this.flwPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwPrincipal.Location = new System.Drawing.Point(0, 0);
            this.flwPrincipal.Name = "flwPrincipal";
            this.flwPrincipal.Size = new System.Drawing.Size(856, 591);
            this.flwPrincipal.TabIndex = 0;
            this.flwPrincipal.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flwPrincipal_ControlRemoved);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlDroite
            // 
            this.pnlDroite.Controls.Add(this.lblNbProduits);
            this.pnlDroite.Controls.Add(this.btnExporterProduits);
            this.pnlDroite.Controls.Add(this.pnlOrdonner);
            this.pnlDroite.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDroite.Location = new System.Drawing.Point(862, 0);
            this.pnlDroite.Name = "pnlDroite";
            this.pnlDroite.Size = new System.Drawing.Size(111, 591);
            this.pnlDroite.TabIndex = 0;
            // 
            // lblNbProduits
            // 
            this.lblNbProduits.AutoSize = true;
            this.lblNbProduits.Location = new System.Drawing.Point(3, 494);
            this.lblNbProduits.Name = "lblNbProduits";
            this.lblNbProduits.Size = new System.Drawing.Size(56, 16);
            this.lblNbProduits.TabIndex = 2;
            this.lblNbProduits.Text = "Produits :";
            // 
            // btnExporterProduits
            // 
            this.btnExporterProduits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExporterProduits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExporterProduits.Location = new System.Drawing.Point(3, 530);
            this.btnExporterProduits.Name = "btnExporterProduits";
            this.btnExporterProduits.Size = new System.Drawing.Size(105, 49);
            this.btnExporterProduits.TabIndex = 1;
            this.btnExporterProduits.Text = "Exporter produits";
            this.btnExporterProduits.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExporterProduits.UseVisualStyleBackColor = true;
            this.btnExporterProduits.Click += new System.EventHandler(this.btnExporterProduits_Click);
            // 
            // pnlOrdonner
            // 
            this.pnlOrdonner.Controls.Add(this.btnSiteDecroissant);
            this.pnlOrdonner.Controls.Add(this.btnSiteCroissant);
            this.pnlOrdonner.Controls.Add(this.btnTitreDecroissant);
            this.pnlOrdonner.Controls.Add(this.btnTitreCroissant);
            this.pnlOrdonner.Controls.Add(this.btnPrixDecroissant);
            this.pnlOrdonner.Controls.Add(this.btnPrixCroissant);
            this.pnlOrdonner.Controls.Add(this.btnTrier);
            this.pnlOrdonner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrdonner.Location = new System.Drawing.Point(0, 0);
            this.pnlOrdonner.Name = "pnlOrdonner";
            this.pnlOrdonner.Size = new System.Drawing.Size(111, 450);
            this.pnlOrdonner.TabIndex = 0;
            // 
            // btnSiteDecroissant
            // 
            this.btnSiteDecroissant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiteDecroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiteDecroissant.Location = new System.Drawing.Point(3, 342);
            this.btnSiteDecroissant.Name = "btnSiteDecroissant";
            this.btnSiteDecroissant.Size = new System.Drawing.Size(105, 49);
            this.btnSiteDecroissant.TabIndex = 6;
            this.btnSiteDecroissant.Text = "Site Decroissant";
            this.btnSiteDecroissant.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSiteDecroissant.UseVisualStyleBackColor = true;
            this.btnSiteDecroissant.Click += new System.EventHandler(this.btnSiteDecroissant_Click);
            // 
            // btnSiteCroissant
            // 
            this.btnSiteCroissant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiteCroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiteCroissant.Location = new System.Drawing.Point(3, 287);
            this.btnSiteCroissant.Name = "btnSiteCroissant";
            this.btnSiteCroissant.Size = new System.Drawing.Size(105, 49);
            this.btnSiteCroissant.TabIndex = 5;
            this.btnSiteCroissant.Text = "Site Croissant";
            this.btnSiteCroissant.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSiteCroissant.UseVisualStyleBackColor = true;
            this.btnSiteCroissant.Click += new System.EventHandler(this.btnSiteCroissant_Click);
            // 
            // btnTitreDecroissant
            // 
            this.btnTitreDecroissant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTitreDecroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitreDecroissant.Location = new System.Drawing.Point(3, 232);
            this.btnTitreDecroissant.Name = "btnTitreDecroissant";
            this.btnTitreDecroissant.Size = new System.Drawing.Size(105, 49);
            this.btnTitreDecroissant.TabIndex = 4;
            this.btnTitreDecroissant.Text = "Titre Decroissant";
            this.btnTitreDecroissant.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTitreDecroissant.UseVisualStyleBackColor = true;
            this.btnTitreDecroissant.Click += new System.EventHandler(this.btnTitreDecroissant_Click);
            // 
            // btnTitreCroissant
            // 
            this.btnTitreCroissant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTitreCroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitreCroissant.Location = new System.Drawing.Point(3, 177);
            this.btnTitreCroissant.Name = "btnTitreCroissant";
            this.btnTitreCroissant.Size = new System.Drawing.Size(105, 49);
            this.btnTitreCroissant.TabIndex = 3;
            this.btnTitreCroissant.Text = "Titre Croissant";
            this.btnTitreCroissant.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTitreCroissant.UseVisualStyleBackColor = true;
            this.btnTitreCroissant.Click += new System.EventHandler(this.btnTitreCroissant_Click);
            // 
            // btnPrixDecroissant
            // 
            this.btnPrixDecroissant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrixDecroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrixDecroissant.Location = new System.Drawing.Point(3, 122);
            this.btnPrixDecroissant.Name = "btnPrixDecroissant";
            this.btnPrixDecroissant.Size = new System.Drawing.Size(105, 49);
            this.btnPrixDecroissant.TabIndex = 2;
            this.btnPrixDecroissant.Text = "Prix Decroissant";
            this.btnPrixDecroissant.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrixDecroissant.UseVisualStyleBackColor = true;
            this.btnPrixDecroissant.Click += new System.EventHandler(this.btnPrixDecroissant_Click);
            // 
            // btnPrixCroissant
            // 
            this.btnPrixCroissant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrixCroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrixCroissant.Location = new System.Drawing.Point(3, 67);
            this.btnPrixCroissant.Name = "btnPrixCroissant";
            this.btnPrixCroissant.Size = new System.Drawing.Size(105, 49);
            this.btnPrixCroissant.TabIndex = 1;
            this.btnPrixCroissant.Text = "Prix Croissant";
            this.btnPrixCroissant.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrixCroissant.UseVisualStyleBackColor = true;
            this.btnPrixCroissant.Click += new System.EventHandler(this.btnPrixCroissant_Click);
            // 
            // btnTrier
            // 
            this.btnTrier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrier.Image = global::ProjetApproProg.Resources.iconTrier;
            this.btnTrier.Location = new System.Drawing.Point(3, 12);
            this.btnTrier.Name = "btnTrier";
            this.btnTrier.Size = new System.Drawing.Size(105, 36);
            this.btnTrier.TabIndex = 0;
            this.btnTrier.Text = "Trier";
            this.btnTrier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTrier.UseVisualStyleBackColor = true;
            this.btnTrier.Click += new System.EventHandler(this.btnOrdonner_Click);
            // 
            // FormProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 591);
            this.Controls.Add(this.flwPrincipal);
            this.Controls.Add(this.pnlDroite);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.Name = "FormProduits";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produits";
            this.pnlDroite.ResumeLayout(false);
            this.pnlDroite.PerformLayout();
            this.pnlOrdonner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwPrincipal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlDroite;
        private System.Windows.Forms.Panel pnlOrdonner;
        private System.Windows.Forms.Button btnSiteDecroissant;
        private System.Windows.Forms.Button btnSiteCroissant;
        private System.Windows.Forms.Button btnTitreDecroissant;
        private System.Windows.Forms.Button btnTitreCroissant;
        private System.Windows.Forms.Button btnPrixDecroissant;
        private System.Windows.Forms.Button btnPrixCroissant;
        private System.Windows.Forms.Button btnTrier;
        private System.Windows.Forms.Button btnExporterProduits;
        private System.Windows.Forms.Label lblNbProduits;
    }
}