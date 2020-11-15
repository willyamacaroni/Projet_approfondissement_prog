namespace AffichageProduits
{
    partial class AffichageProduit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnOuvrirPage = new System.Windows.Forms.Button();
            this.tblBtnSupprimer = new System.Windows.Forms.TableLayoutPanel();
            this.btnSupprimerProd = new System.Windows.Forms.Button();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal.SuspendLayout();
            this.tblBtnSupprimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblTitre.Location = new System.Drawing.Point(10, 7);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(68, 33);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Titre";
            // 
            // lblPrix
            // 
            this.lblPrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(13, 71);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(31, 17);
            this.lblPrix.TabIndex = 2;
            this.lblPrix.Text = "Prix";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrincipal.Controls.Add(this.btnOuvrirPage);
            this.pnlPrincipal.Controls.Add(this.lblPrix);
            this.pnlPrincipal.Controls.Add(this.lblTitre);
            this.pnlPrincipal.Controls.Add(this.tblBtnSupprimer);
            this.pnlPrincipal.Location = new System.Drawing.Point(197, 5);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(598, 182);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // btnOuvrirPage
            // 
            this.btnOuvrirPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOuvrirPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOuvrirPage.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btnOuvrirPage.Location = new System.Drawing.Point(0, 150);
            this.btnOuvrirPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnOuvrirPage.Name = "btnOuvrirPage";
            this.btnOuvrirPage.Size = new System.Drawing.Size(398, 32);
            this.btnOuvrirPage.TabIndex = 3;
            this.btnOuvrirPage.Text = "Ouvrir la page";
            this.btnOuvrirPage.UseVisualStyleBackColor = true;
            this.btnOuvrirPage.Click += new System.EventHandler(this.btnOuvrirPage_Click);
            // 
            // tblBtnSupprimer
            // 
            this.tblBtnSupprimer.ColumnCount = 3;
            this.tblBtnSupprimer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblBtnSupprimer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblBtnSupprimer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tblBtnSupprimer.Controls.Add(this.btnSupprimerProd, 1, 1);
            this.tblBtnSupprimer.Dock = System.Windows.Forms.DockStyle.Right;
            this.tblBtnSupprimer.Location = new System.Drawing.Point(398, 0);
            this.tblBtnSupprimer.Name = "tblBtnSupprimer";
            this.tblBtnSupprimer.RowCount = 3;
            this.tblBtnSupprimer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblBtnSupprimer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblBtnSupprimer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblBtnSupprimer.Size = new System.Drawing.Size(200, 182);
            this.tblBtnSupprimer.TabIndex = 5;
            // 
            // btnSupprimerProd
            // 
            this.btnSupprimerProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupprimerProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSupprimerProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerProd.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btnSupprimerProd.Image = global::AffichageProduits.Properties.Resources.delete;
            this.btnSupprimerProd.Location = new System.Drawing.Point(27, 63);
            this.btnSupprimerProd.Name = "btnSupprimerProd";
            this.btnSupprimerProd.Size = new System.Drawing.Size(144, 54);
            this.btnSupprimerProd.TabIndex = 4;
            this.btnSupprimerProd.Text = "Supprimer";
            this.btnSupprimerProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSupprimerProd.UseVisualStyleBackColor = true;
            this.btnSupprimerProd.Click += new System.EventHandler(this.btnSupprimerProd_Click);
            // 
            // pctImage
            // 
            this.pctImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pctImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctImage.Location = new System.Drawing.Point(3, 3);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(185, 185);
            this.pctImage.TabIndex = 0;
            this.pctImage.TabStop = false;
            // 
            // AffichageProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pctImage);
            this.Name = "AffichageProduit";
            this.Size = new System.Drawing.Size(798, 192);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.tblBtnSupprimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnOuvrirPage;
        private System.Windows.Forms.TableLayoutPanel tblBtnSupprimer;
        private System.Windows.Forms.Button btnSupprimerProd;
    }
}
