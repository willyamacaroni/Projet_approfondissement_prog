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
            this.flwPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // flwPrincipal
            // 
            this.flwPrincipal.AutoScroll = true;
            this.flwPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwPrincipal.Location = new System.Drawing.Point(0, 0);
            this.flwPrincipal.Name = "flwPrincipal";
            this.flwPrincipal.Size = new System.Drawing.Size(973, 591);
            this.flwPrincipal.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBottom.Location = new System.Drawing.Point(875, 0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(98, 591);
            this.pnlBottom.TabIndex = 1;
            // 
            // FormProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 591);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.flwPrincipal);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.Name = "FormProduits";
            this.Text = "Produits";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwPrincipal;
        private System.Windows.Forms.Panel pnlBottom;
    }
}