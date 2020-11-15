using System.Windows.Forms;

namespace ProjetApproProg.Affichage_Produit
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
            this.pctImagePoduit = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnOuvrirPage = new System.Windows.Forms.Button();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSupprProduit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagePoduit)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctImagePoduit
            // 
            this.pctImagePoduit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pctImagePoduit.Location = new System.Drawing.Point(3, 3);
            this.pctImagePoduit.Name = "pctImagePoduit";
            this.pctImagePoduit.Size = new System.Drawing.Size(198, 196);
            this.pctImagePoduit.TabIndex = 0;
            this.pctImagePoduit.TabStop = false;
            this.pctImagePoduit.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.btnOuvrirPage);
            this.pnlPrincipal.Controls.Add(this.lblPrix);
            this.pnlPrincipal.Controls.Add(this.lblTitre);
            this.pnlPrincipal.Controls.Add(this.tableLayoutPanel1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPrincipal.Location = new System.Drawing.Point(205, 0);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(5);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(591, 202);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // btnOuvrirPage
            // 
            this.btnOuvrirPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOuvrirPage.Location = new System.Drawing.Point(0, 162);
            this.btnOuvrirPage.Name = "btnOuvrirPage";
            this.btnOuvrirPage.Size = new System.Drawing.Size(391, 33);
            this.btnOuvrirPage.TabIndex = 3;
            this.btnOuvrirPage.Text = "Ouvrir la page du produit";
            this.btnOuvrirPage.UseVisualStyleBackColor = true;
            this.btnOuvrirPage.Click += new System.EventHandler(this.btnOuvrirPage_Click);
            // 
            // lblPrix
            // 
            this.lblPrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblPrix.Location = new System.Drawing.Point(5, 88);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(39, 22);
            this.lblPrix.TabIndex = 2;
            this.lblPrix.Text = "Prix";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblTitre.Location = new System.Drawing.Point(3, 3);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(68, 33);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Titre";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.07538F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.84924F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.07538F));
            this.tableLayoutPanel1.Controls.Add(this.btnSupprProduit, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(391, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 202);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSupprProduit
            // 
            this.btnSupprProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSupprProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprProduit.Image = global::ProjetApproProg.Resources.iconSupp;
            this.btnSupprProduit.Location = new System.Drawing.Point(33, 70);
            this.btnSupprProduit.Name = "btnSupprProduit";
            this.btnSupprProduit.Size = new System.Drawing.Size(133, 61);
            this.btnSupprProduit.TabIndex = 0;
            this.btnSupprProduit.Text = "Supprimer";
            this.btnSupprProduit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSupprProduit.UseVisualStyleBackColor = true;
            this.btnSupprProduit.Click += new System.EventHandler(this.btnSupprProduit_Click);
            // 
            // AffichageProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pctImagePoduit);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.Name = "AffichageProduit";
            this.Size = new System.Drawing.Size(825, 202);
            ((System.ComponentModel.ISupportInitialize)(this.pctImagePoduit)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImagePoduit;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnOuvrirPage;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSupprProduit;
    }
}
