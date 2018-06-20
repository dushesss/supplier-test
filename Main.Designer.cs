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
            this.components = new System.ComponentModel.Container();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.btnAddNSup = new System.Windows.Forms.Button();
            this.dgvSupl = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbCex1 = new System.Windows.Forms.CheckBox();
            this.cbCex2 = new System.Windows.Forms.CheckBox();
            this.cbCex3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.objInfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objInfBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxSearch.Location = new System.Drawing.Point(363, 27);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(414, 20);
            this.txtbxSearch.TabIndex = 14;
            this.txtbxSearch.TextChanged += new System.EventHandler(this.txtbxSearch_TextChanged);
            // 
            // btnAddApp
            // 
            this.btnAddApp.Location = new System.Drawing.Point(8, 95);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(81, 38);
            this.btnAddApp.TabIndex = 12;
            this.btnAddApp.Text = "Новый заказ";
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // btnAddNSup
            // 
            this.btnAddNSup.Location = new System.Drawing.Point(8, 51);
            this.btnAddNSup.Name = "btnAddNSup";
            this.btnAddNSup.Size = new System.Drawing.Size(81, 38);
            this.btnAddNSup.TabIndex = 11;
            this.btnAddNSup.Text = "Добавить поставщика";
            this.btnAddNSup.UseVisualStyleBackColor = true;
            this.btnAddNSup.Click += new System.EventHandler(this.btnAddNSup_Click);
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
            this.dgvSupl.Location = new System.Drawing.Point(95, 51);
            this.dgvSupl.MultiSelect = false;
            this.dgvSupl.Name = "dgvSupl";
            this.dgvSupl.ReadOnly = true;
            this.dgvSupl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupl.ShowEditingIcon = false;
            this.dgvSupl.Size = new System.Drawing.Size(682, 293);
            this.dgvSupl.TabIndex = 10;
            this.dgvSupl.DoubleClick += new System.EventHandler(this.dgvSupl_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 38);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Удалить строку";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
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
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuToolStripMenuItem.CheckOnClick = true;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptions,
            this.tsmiInfo,
            this.tsmiExit});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(180, 22);
            this.tsmiOptions.Text = "Настройки";
            // 
            // tsmiInfo
            // 
            this.tsmiInfo.Name = "tsmiInfo";
            this.tsmiInfo.Size = new System.Drawing.Size(180, 22);
            this.tsmiInfo.Text = "Информация";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(95, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(262, 13);
            this.lblSearch.TabIndex = 22;
            this.lblSearch.Text = "Введите в поле для поиска искомую информацию";
            // 
            // cbCex1
            // 
            this.cbCex1.AutoSize = true;
            this.cbCex1.Checked = true;
            this.cbCex1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCex1.Location = new System.Drawing.Point(14, 19);
            this.cbCex1.Name = "cbCex1";
            this.cbCex1.Size = new System.Drawing.Size(54, 17);
            this.cbCex1.TabIndex = 24;
            this.cbCex1.Text = "Цех 1";
            this.cbCex1.UseVisualStyleBackColor = true;
            this.cbCex1.CheckedChanged += new System.EventHandler(this.cbCex1_CheckedChanged);
            // 
            // cbCex2
            // 
            this.cbCex2.AutoSize = true;
            this.cbCex2.Checked = true;
            this.cbCex2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCex2.Location = new System.Drawing.Point(14, 42);
            this.cbCex2.Name = "cbCex2";
            this.cbCex2.Size = new System.Drawing.Size(54, 17);
            this.cbCex2.TabIndex = 25;
            this.cbCex2.Text = "Цех 2";
            this.cbCex2.UseVisualStyleBackColor = true;
            this.cbCex2.CheckedChanged += new System.EventHandler(this.cbCex1_CheckedChanged);
            // 
            // cbCex3
            // 
            this.cbCex3.AutoSize = true;
            this.cbCex3.Checked = true;
            this.cbCex3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCex3.Location = new System.Drawing.Point(14, 64);
            this.cbCex3.Name = "cbCex3";
            this.cbCex3.Size = new System.Drawing.Size(54, 17);
            this.cbCex3.TabIndex = 26;
            this.cbCex3.Text = "Цех 3";
            this.cbCex3.UseVisualStyleBackColor = true;
            this.cbCex3.CheckedChanged += new System.EventHandler(this.cbCex1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCex1);
            this.groupBox1.Controls.Add(this.cbCex3);
            this.groupBox1.Controls.Add(this.cbCex2);
            this.groupBox1.Location = new System.Drawing.Point(15, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(74, 161);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цеха";
            // 
            // objInfBindingSource
            // 
//            this.objInfBindingSource.DataSource = typeof(Supplier.ObjInf);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(789, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtbxSearch);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objInfBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.Button btnAddNSup;
        private System.Windows.Forms.DataGridView dgvSupl;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.CheckBox cbCex1;
        private System.Windows.Forms.CheckBox cbCex2;
        private System.Windows.Forms.CheckBox cbCex3;
        private System.Windows.Forms.BindingSource objInfBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}