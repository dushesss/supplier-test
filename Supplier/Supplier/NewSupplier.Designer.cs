namespace Supplier
{
    partial class NewSupplier
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
            this.btnAddSpl = new System.Windows.Forms.Button();
            this.txtbxEmailSup = new System.Windows.Forms.TextBox();
            this.txtbxNSup = new System.Windows.Forms.TextBox();
            this.lblEmailSup = new System.Windows.Forms.Label();
            this.lblNameSup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddSpl
            // 
            this.btnAddSpl.Location = new System.Drawing.Point(87, 66);
            this.btnAddSpl.Name = "btnAddSpl";
            this.btnAddSpl.Size = new System.Drawing.Size(157, 23);
            this.btnAddSpl.TabIndex = 9;
            this.btnAddSpl.Text = "Добавить поставщика";
            this.btnAddSpl.UseVisualStyleBackColor = true;
            // 
            // txtbxEmailSup
            // 
            this.txtbxEmailSup.Location = new System.Drawing.Point(140, 36);
            this.txtbxEmailSup.Name = "txtbxEmailSup";
            this.txtbxEmailSup.Size = new System.Drawing.Size(174, 20);
            this.txtbxEmailSup.TabIndex = 8;
            // 
            // txtbxNSup
            // 
            this.txtbxNSup.Location = new System.Drawing.Point(140, 12);
            this.txtbxNSup.Name = "txtbxNSup";
            this.txtbxNSup.Size = new System.Drawing.Size(174, 20);
            this.txtbxNSup.TabIndex = 7;
            // 
            // lblEmailSup
            // 
            this.lblEmailSup.AutoSize = true;
            this.lblEmailSup.Location = new System.Drawing.Point(8, 39);
            this.lblEmailSup.Name = "lblEmailSup";
            this.lblEmailSup.Size = new System.Drawing.Size(126, 13);
            this.lblEmailSup.TabIndex = 6;
            this.lblEmailSup.Text = "Почтовый ящик фирмы";
            // 
            // lblNameSup
            // 
            this.lblNameSup.AutoSize = true;
            this.lblNameSup.Location = new System.Drawing.Point(38, 15);
            this.lblNameSup.Name = "lblNameSup";
            this.lblNameSup.Size = new System.Drawing.Size(96, 13);
            this.lblNameSup.TabIndex = 5;
            this.lblNameSup.Text = "Название фирмы";
            // 
            // NewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 99);
            this.Controls.Add(this.btnAddSpl);
            this.Controls.Add(this.txtbxEmailSup);
            this.Controls.Add(this.txtbxNSup);
            this.Controls.Add(this.lblEmailSup);
            this.Controls.Add(this.lblNameSup);
            this.Name = "NewSupplier";
            this.Text = "Добавление нового поставщика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSpl;
        private System.Windows.Forms.TextBox txtbxEmailSup;
        private System.Windows.Forms.TextBox txtbxNSup;
        private System.Windows.Forms.Label lblEmailSup;
        private System.Windows.Forms.Label lblNameSup;
    }
}