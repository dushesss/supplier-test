namespace Supplier
{
    partial class Main
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
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.chlbxCeh = new System.Windows.Forms.CheckedListBox();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.btnAddNSup = new System.Windows.Forms.Button();
            this.dgvSupl = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxSearch.Location = new System.Drawing.Point(95, 79);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(682, 20);
            this.txtbxSearch.TabIndex = 14;
            this.txtbxSearch.TextChanged += new System.EventHandler(this.txtbxSearch_TextChanged);
            // 
            // chlbxCeh
            // 
            this.chlbxCeh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chlbxCeh.FormattingEnabled = true;
            this.chlbxCeh.Items.AddRange(new object[] {
            "Цех 1",
            "Цех 2",
            "Цех 3"});
            this.chlbxCeh.Location = new System.Drawing.Point(8, 79);
            this.chlbxCeh.Name = "chlbxCeh";
            this.chlbxCeh.Size = new System.Drawing.Size(81, 319);
            this.chlbxCeh.TabIndex = 13;
            // 
            // btnAddApp
            // 
            this.btnAddApp.Location = new System.Drawing.Point(182, 35);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(81, 38);
            this.btnAddApp.TabIndex = 12;
            this.btnAddApp.Text = "Новый заказ";
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // btnAddNSup
            // 
            this.btnAddNSup.Location = new System.Drawing.Point(95, 35);
            this.btnAddNSup.Name = "btnAddNSup";
            this.btnAddNSup.Size = new System.Drawing.Size(81, 38);
            this.btnAddNSup.TabIndex = 11;
            this.btnAddNSup.Text = "Добавить поставщика";
            this.btnAddNSup.UseVisualStyleBackColor = true;
            // 
            // dgvSupl
            // 
            this.dgvSupl.AllowUserToAddRows = false;
            this.dgvSupl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSupl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupl.Location = new System.Drawing.Point(95, 105);
            this.dgvSupl.Name = "dgvSupl";
            this.dgvSupl.ShowEditingIcon = false;
            this.dgvSupl.Size = new System.Drawing.Size(682, 293);
            this.dgvSupl.TabIndex = 10;
            this.dgvSupl.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSupl_RowPostPaint);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(269, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 38);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Удалить строку";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 405);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.chlbxCeh);
            this.Controls.Add(this.btnAddApp);
            this.Controls.Add(this.btnAddNSup);
            this.Controls.Add(this.dgvSupl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.CheckedListBox chlbxCeh;
        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.Button btnAddNSup;
        private System.Windows.Forms.DataGridView dgvSupl;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}