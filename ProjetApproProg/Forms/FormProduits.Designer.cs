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
            this.panelOrdonner = new System.Windows.Forms.Panel();
            this.btnSiteDecroissant = new System.Windows.Forms.Button();
            this.btnSiteCroissant = new System.Windows.Forms.Button();
            this.btnTitreDecroissant = new System.Windows.Forms.Button();
            this.btnTitreCroissant = new System.Windows.Forms.Button();
            this.btnPrixDecroissant = new System.Windows.Forms.Button();
            this.btnPrixCroissant = new System.Windows.Forms.Button();
            this.btnOrdonner = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelOrdonner.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwPrincipal
            // 
            this.flwPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwPrincipal.Location = new System.Drawing.Point(0, 0);
            this.flwPrincipal.Name = "flwPrincipal";
            this.flwPrincipal.Size = new System.Drawing.Size(973, 591);
            this.flwPrincipal.TabIndex = 0;
            // 
            // panelOrdonner
            // 
            this.panelOrdonner.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelOrdonner.Controls.Add(this.btnSiteDecroissant);
            this.panelOrdonner.Controls.Add(this.btnSiteCroissant);
            this.panelOrdonner.Controls.Add(this.btnTitreDecroissant);
            this.panelOrdonner.Controls.Add(this.btnTitreCroissant);
            this.panelOrdonner.Controls.Add(this.btnPrixDecroissant);
            this.panelOrdonner.Controls.Add(this.btnPrixCroissant);
            this.panelOrdonner.Controls.Add(this.btnOrdonner);
            this.panelOrdonner.Location = new System.Drawing.Point(900, 1);
            this.panelOrdonner.MaximumSize = new System.Drawing.Size(72, 205);
            this.panelOrdonner.MinimumSize = new System.Drawing.Size(72, 43);
            this.panelOrdonner.Name = "panelOrdonner";
            this.panelOrdonner.Size = new System.Drawing.Size(72, 43);
            this.panelOrdonner.TabIndex = 0;
            // 
            // btnSiteDecroissant
            // 
            this.btnSiteDecroissant.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSiteDecroissant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSiteDecroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiteDecroissant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiteDecroissant.Location = new System.Drawing.Point(0, 180);
            this.btnSiteDecroissant.Name = "btnSiteDecroissant";
            this.btnSiteDecroissant.Size = new System.Drawing.Size(72, 25);
            this.btnSiteDecroissant.TabIndex = 13;
            this.btnSiteDecroissant.Text = "Trier par";
            this.btnSiteDecroissant.UseVisualStyleBackColor = false;
            // 
            // btnSiteCroissant
            // 
            this.btnSiteCroissant.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSiteCroissant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSiteCroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiteCroissant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiteCroissant.Location = new System.Drawing.Point(0, 156);
            this.btnSiteCroissant.Name = "btnSiteCroissant";
            this.btnSiteCroissant.Size = new System.Drawing.Size(72, 24);
            this.btnSiteCroissant.TabIndex = 12;
            this.btnSiteCroissant.Text = "Trier par";
            this.btnSiteCroissant.UseVisualStyleBackColor = false;
            // 
            // btnTitreDecroissant
            // 
            this.btnTitreDecroissant.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTitreDecroissant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTitreDecroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitreDecroissant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTitreDecroissant.Location = new System.Drawing.Point(0, 132);
            this.btnTitreDecroissant.Name = "btnTitreDecroissant";
            this.btnTitreDecroissant.Size = new System.Drawing.Size(72, 24);
            this.btnTitreDecroissant.TabIndex = 11;
            this.btnTitreDecroissant.Text = "Trier par";
            this.btnTitreDecroissant.UseVisualStyleBackColor = false;
            // 
            // btnTitreCroissant
            // 
            this.btnTitreCroissant.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTitreCroissant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTitreCroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitreCroissant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTitreCroissant.Location = new System.Drawing.Point(0, 107);
            this.btnTitreCroissant.Name = "btnTitreCroissant";
            this.btnTitreCroissant.Size = new System.Drawing.Size(72, 25);
            this.btnTitreCroissant.TabIndex = 10;
            this.btnTitreCroissant.Text = "Trier par";
            this.btnTitreCroissant.UseVisualStyleBackColor = false;
            // 
            // btnPrixDecroissant
            // 
            this.btnPrixDecroissant.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrixDecroissant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrixDecroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrixDecroissant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrixDecroissant.Location = new System.Drawing.Point(0, 64);
            this.btnPrixDecroissant.Name = "btnPrixDecroissant";
            this.btnPrixDecroissant.Size = new System.Drawing.Size(72, 43);
            this.btnPrixDecroissant.TabIndex = 9;
            this.btnPrixDecroissant.Text = "Prix decroissant";
            this.btnPrixDecroissant.UseVisualStyleBackColor = false;
            // 
            // btnPrixCroissant
            // 
            this.btnPrixCroissant.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrixCroissant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrixCroissant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrixCroissant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrixCroissant.Location = new System.Drawing.Point(0, 40);
            this.btnPrixCroissant.Name = "btnPrixCroissant";
            this.btnPrixCroissant.Size = new System.Drawing.Size(72, 24);
            this.btnPrixCroissant.TabIndex = 8;
            this.btnPrixCroissant.Text = "Prix croissant";
            this.btnPrixCroissant.UseVisualStyleBackColor = false;
            // 
            // btnOrdonner
            // 
            this.btnOrdonner.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOrdonner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdonner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdonner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrdonner.Location = new System.Drawing.Point(0, 0);
            this.btnOrdonner.Name = "btnOrdonner";
            this.btnOrdonner.Size = new System.Drawing.Size(72, 40);
            this.btnOrdonner.TabIndex = 7;
            this.btnOrdonner.Text = "Trier par";
            this.btnOrdonner.UseVisualStyleBackColor = false;
            this.btnOrdonner.Click += new System.EventHandler(this.btnOrdonner_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 591);
            this.Controls.Add(this.panelOrdonner);
            this.Controls.Add(this.flwPrincipal);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.Name = "FormProduits";
            this.Text = "Produits";
            this.panelOrdonner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwPrincipal;
        private System.Windows.Forms.Panel panelOrdonner;
        private System.Windows.Forms.Button btnSiteDecroissant;
        private System.Windows.Forms.Button btnSiteCroissant;
        private System.Windows.Forms.Button btnTitreDecroissant;
        private System.Windows.Forms.Button btnTitreCroissant;
        private System.Windows.Forms.Button btnPrixDecroissant;
        private System.Windows.Forms.Button btnPrixCroissant;
        private System.Windows.Forms.Button btnOrdonner;
        private System.Windows.Forms.Timer timer1;
    }
}