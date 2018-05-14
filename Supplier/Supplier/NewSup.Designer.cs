namespace Supplier
{
    partial class NewSup
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
            this.lblNameSup = new System.Windows.Forms.Label();
            this.lblEmailSup = new System.Windows.Forms.Label();
            this.txtbxNSup = new System.Windows.Forms.TextBox();
            this.txtbxEmailSup = new System.Windows.Forms.TextBox();
            this.btnAddSpl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameSup
            // 
            this.lblNameSup.AutoSize = true;
            this.lblNameSup.Location = new System.Drawing.Point(43, 9);
            this.lblNameSup.Name = "lblNameSup";
            this.lblNameSup.Size = new System.Drawing.Size(96, 13);
            this.lblNameSup.TabIndex = 0;
            this.lblNameSup.Text = "Название фирмы";
            // 
            // lblEmailSup
            // 
            this.lblEmailSup.AutoSize = true;
            this.lblEmailSup.Location = new System.Drawing.Point(13, 33);
            this.lblEmailSup.Name = "lblEmailSup";
            this.lblEmailSup.Size = new System.Drawing.Size(126, 13);
            this.lblEmailSup.TabIndex = 1;
            this.lblEmailSup.Text = "Почтовый ящик фирмы";
            // 
            // txtbxNSup
            // 
            this.txtbxNSup.Location = new System.Drawing.Point(145, 6);
            this.txtbxNSup.Name = "txtbxNSup";
            this.txtbxNSup.Size = new System.Drawing.Size(174, 20);
            this.txtbxNSup.TabIndex = 2;
            // 
            // txtbxEmailSup
            // 
            this.txtbxEmailSup.Location = new System.Drawing.Point(145, 30);
            this.txtbxEmailSup.Name = "txtbxEmailSup";
            this.txtbxEmailSup.Size = new System.Drawing.Size(174, 20);
            this.txtbxEmailSup.TabIndex = 3;
            // 
            // btnAddSpl
            // 
            this.btnAddSpl.Location = new System.Drawing.Point(92, 60);
            this.btnAddSpl.Name = "btnAddSpl";
            this.btnAddSpl.Size = new System.Drawing.Size(157, 23);
            this.btnAddSpl.TabIndex = 4;
            this.btnAddSpl.Text = "Добавить поставщика";
            this.btnAddSpl.UseVisualStyleBackColor = true;
            this.btnAddSpl.Click += new System.EventHandler(this.btnAddSpl_Click);
            // 
            // NewSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 95);
            this.Controls.Add(this.btnAddSpl);
            this.Controls.Add(this.txtbxEmailSup);
            this.Controls.Add(this.txtbxNSup);
            this.Controls.Add(this.lblEmailSup);
            this.Controls.Add(this.lblNameSup);
            this.Name = "NewSup";
            this.Text = "Новый поставщик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameSup;
        private System.Windows.Forms.Label lblEmailSup;
        private System.Windows.Forms.TextBox txtbxNSup;
        private System.Windows.Forms.TextBox txtbxEmailSup;
        private System.Windows.Forms.Button btnAddSpl;
    }
}