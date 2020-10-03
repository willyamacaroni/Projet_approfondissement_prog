namespace ProjetApproProg
{
    partial class FormFiltres
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
            this.lytPrincipale = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.chkPrix = new System.Windows.Forms.CheckBox();
            this.chkNote = new System.Windows.Forms.CheckBox();
            this.chkCondition = new System.Windows.Forms.CheckBox();
            this.lytBtnCancel = new System.Windows.Forms.TableLayoutPanel();
            this.lytBtnOK = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPrixDe = new System.Windows.Forms.TextBox();
            this.txtPrixA = new System.Windows.Forms.TextBox();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.lytPrincipale.SuspendLayout();
            this.lytBtnCancel.SuspendLayout();
            this.lytBtnOK.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lytPrincipale
            // 
            this.lytPrincipale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lytPrincipale.BackColor = System.Drawing.Color.Transparent;
            this.lytPrincipale.ColumnCount = 6;
            this.lytPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lytPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lytPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lytPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lytPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lytPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.lytPrincipale.Controls.Add(this.lytBtnOK, 4, 7);
            this.lytPrincipale.Controls.Add(this.lytBtnCancel, 0, 7);
            this.lytPrincipale.Controls.Add(this.chkCondition, 1, 6);
            this.lytPrincipale.Controls.Add(this.chkNote, 1, 5);
            this.lytPrincipale.Controls.Add(this.lblTitre, 2, 1);
            this.lytPrincipale.Controls.Add(this.chkPrix, 1, 4);
            this.lytPrincipale.Controls.Add(this.tableLayoutPanel1, 3, 4);
            this.lytPrincipale.Controls.Add(this.cmbCondition, 3, 6);
            this.lytPrincipale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lytPrincipale.ForeColor = System.Drawing.Color.Transparent;
            this.lytPrincipale.Location = new System.Drawing.Point(0, 0);
            this.lytPrincipale.Name = "lytPrincipale";
            this.lytPrincipale.RowCount = 9;
            this.lytPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.lytPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.lytPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.lytPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.lytPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.lytPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.lytPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.lytPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.lytPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.lytPrincipale.Size = new System.Drawing.Size(882, 523);
            this.lytPrincipale.TabIndex = 0;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lytPrincipale.SetColumnSpan(this.lblTitre, 2);
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 32F);
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(297, 58);
            this.lblTitre.Name = "lblTitre";
            this.lytPrincipale.SetRowSpan(this.lblTitre, 2);
            this.lblTitre.Size = new System.Drawing.Size(288, 116);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "FILTRES";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkPrix
            // 
            this.chkPrix.AutoSize = true;
            this.lytPrincipale.SetColumnSpan(this.chkPrix, 2);
            this.chkPrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrix.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.chkPrix.ForeColor = System.Drawing.Color.White;
            this.chkPrix.Location = new System.Drawing.Point(150, 235);
            this.chkPrix.Name = "chkPrix";
            this.chkPrix.Size = new System.Drawing.Size(288, 52);
            this.chkPrix.TabIndex = 1;
            this.chkPrix.Text = "Prix:";
            this.chkPrix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrix.UseVisualStyleBackColor = true;
            // 
            // chkNote
            // 
            this.chkNote.AutoSize = true;
            this.lytPrincipale.SetColumnSpan(this.chkNote, 2);
            this.chkNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNote.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.chkNote.ForeColor = System.Drawing.Color.White;
            this.chkNote.Location = new System.Drawing.Point(150, 293);
            this.chkNote.Name = "chkNote";
            this.chkNote.Size = new System.Drawing.Size(288, 52);
            this.chkNote.TabIndex = 2;
            this.chkNote.Text = "Note:";
            this.chkNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNote.UseVisualStyleBackColor = true;
            // 
            // chkCondition
            // 
            this.chkCondition.AutoSize = true;
            this.lytPrincipale.SetColumnSpan(this.chkCondition, 2);
            this.chkCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCondition.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.chkCondition.ForeColor = System.Drawing.Color.White;
            this.chkCondition.Location = new System.Drawing.Point(150, 351);
            this.chkCondition.Name = "chkCondition";
            this.chkCondition.Size = new System.Drawing.Size(288, 52);
            this.chkCondition.TabIndex = 3;
            this.chkCondition.Text = "Condition:";
            this.chkCondition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCondition.UseVisualStyleBackColor = true;
            // 
            // lytBtnCancel
            // 
            this.lytBtnCancel.ColumnCount = 3;
            this.lytPrincipale.SetColumnSpan(this.lytBtnCancel, 2);
            this.lytBtnCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lytBtnCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.lytBtnCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lytBtnCancel.Controls.Add(this.btnCancel, 1, 1);
            this.lytBtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lytBtnCancel.Location = new System.Drawing.Point(3, 409);
            this.lytBtnCancel.Name = "lytBtnCancel";
            this.lytBtnCancel.RowCount = 3;
            this.lytPrincipale.SetRowSpan(this.lytBtnCancel, 2);
            this.lytBtnCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lytBtnCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.lytBtnCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lytBtnCancel.Size = new System.Drawing.Size(288, 111);
            this.lytBtnCancel.TabIndex = 5;
            // 
            // lytBtnOK
            // 
            this.lytBtnOK.ColumnCount = 3;
            this.lytPrincipale.SetColumnSpan(this.lytBtnOK, 2);
            this.lytBtnOK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lytBtnOK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.lytBtnOK.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lytBtnOK.Controls.Add(this.btnOK, 1, 1);
            this.lytBtnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lytBtnOK.Location = new System.Drawing.Point(591, 409);
            this.lytBtnOK.Name = "lytBtnOK";
            this.lytBtnOK.RowCount = 3;
            this.lytPrincipale.SetRowSpan(this.lytBtnOK, 2);
            this.lytBtnOK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lytBtnOK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.lytBtnOK.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.lytBtnOK.Size = new System.Drawing.Size(288, 111);
            this.lytBtnOK.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(31, 14);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(224, 82);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(31, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(224, 82);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.lytPrincipale.SetColumnSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtPrixA, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPrixDe, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(444, 235);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 52);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // txtPrixDe
            // 
            this.txtPrixDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrixDe.BackColor = System.Drawing.Color.White;
            this.txtPrixDe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrixDe.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txtPrixDe.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrixDe.Location = new System.Drawing.Point(3, 9);
            this.txtPrixDe.Name = "txtPrixDe";
            this.txtPrixDe.Size = new System.Drawing.Size(209, 33);
            this.txtPrixDe.TabIndex = 0;
            this.txtPrixDe.Text = "De:";
            // 
            // txtPrixA
            // 
            this.txtPrixA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrixA.BackColor = System.Drawing.Color.White;
            this.txtPrixA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrixA.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txtPrixA.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrixA.Location = new System.Drawing.Point(218, 9);
            this.txtPrixA.Name = "txtPrixA";
            this.txtPrixA.Size = new System.Drawing.Size(209, 33);
            this.txtPrixA.TabIndex = 1;
            this.txtPrixA.Text = "À:";
            // 
            // cmbCondition
            // 
            this.cmbCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lytPrincipale.SetColumnSpan(this.cmbCondition, 2);
            this.cmbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondition.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Items.AddRange(new object[] {
            "Neuf",
            "Remis à neuf",
            "Usagé"});
            this.cmbCondition.Location = new System.Drawing.Point(444, 356);
            this.cmbCondition.MaxDropDownItems = 3;
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(288, 41);
            this.cmbCondition.TabIndex = 8;
            // 
            // FormFiltres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(882, 523);
            this.Controls.Add(this.lytPrincipale);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormFiltres";
            this.ShowIcon = false;
            this.Text = "FILTRES";
            this.lytPrincipale.ResumeLayout(false);
            this.lytPrincipale.PerformLayout();
            this.lytBtnCancel.ResumeLayout(false);
            this.lytBtnOK.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lytPrincipale;
        private System.Windows.Forms.TableLayoutPanel lytBtnOK;
        private System.Windows.Forms.TableLayoutPanel lytBtnCancel;
        private System.Windows.Forms.CheckBox chkCondition;
        private System.Windows.Forms.CheckBox chkNote;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.CheckBox chkPrix;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPrixA;
        private System.Windows.Forms.TextBox txtPrixDe;
        private System.Windows.Forms.ComboBox cmbCondition;
    }
}