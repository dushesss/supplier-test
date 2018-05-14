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
            this.dgvSupl = new System.Windows.Forms.DataGridView();
            this.btnAddNSup = new System.Windows.Forms.Button();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.chlbxCeh = new System.Windows.Forms.CheckedListBox();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.firm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfZakaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.upDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.how_much = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupl
            // 
            this.dgvSupl.AllowUserToAddRows = false;
            this.dgvSupl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSupl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firm,
            this.stuff,
            this.amount,
            this.dateOfZakaz,
            this.status,
            this.upDate,
            this.how_much,
            this.ceh});
            this.dgvSupl.Location = new System.Drawing.Point(12, 165);
            this.dgvSupl.Name = "dgvSupl";
            this.dgvSupl.ShowEditingIcon = false;
            this.dgvSupl.Size = new System.Drawing.Size(768, 273);
            this.dgvSupl.TabIndex = 0;
            this.dgvSupl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupl_CellDoubleClick);
            // 
            // btnAddNSup
            // 
            this.btnAddNSup.Location = new System.Drawing.Point(12, 121);
            this.btnAddNSup.Name = "btnAddNSup";
            this.btnAddNSup.Size = new System.Drawing.Size(81, 38);
            this.btnAddNSup.TabIndex = 1;
            this.btnAddNSup.Text = "Добавить поставщика";
            this.btnAddNSup.UseVisualStyleBackColor = true;
            this.btnAddNSup.Click += new System.EventHandler(this.btnAddNSup_Click);
            // 
            // btnAddApp
            // 
            this.btnAddApp.Location = new System.Drawing.Point(95, 121);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(81, 38);
            this.btnAddApp.TabIndex = 2;
            this.btnAddApp.Text = "Новый заказ";
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // chlbxCeh
            // 
            this.chlbxCeh.FormattingEnabled = true;
            this.chlbxCeh.Items.AddRange(new object[] {
            "Цех 1",
            "Цех 2",
            "Цех 3"});
            this.chlbxCeh.Location = new System.Drawing.Point(12, 41);
            this.chlbxCeh.Name = "chlbxCeh";
            this.chlbxCeh.Size = new System.Drawing.Size(244, 79);
            this.chlbxCeh.TabIndex = 3;
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(12, 15);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(161, 20);
            this.txtbxSearch.TabIndex = 4;
            this.txtbxSearch.Text = " ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(180, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 20);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(180, 121);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Выйти";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(262, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 38);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(350, 121);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 38);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Обновить таблицу";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // firm
            // 
            this.firm.HeaderText = "Поставщик";
            this.firm.Name = "firm";
            this.firm.ReadOnly = true;
            // 
            // stuff
            // 
            this.stuff.HeaderText = "Заказ";
            this.stuff.Name = "stuff";
            // 
            // amount
            // 
            this.amount.HeaderText = "Количество";
            this.amount.Name = "amount";
            // 
            // dateOfZakaz
            // 
            this.dateOfZakaz.HeaderText = "День заказа";
            this.dateOfZakaz.Name = "dateOfZakaz";
            this.dateOfZakaz.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Статус";
            this.status.Items.AddRange(new object[] {
            "Заявка принята",
            "Ожидается",
            "На складе"});
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // upDate
            // 
            this.upDate.HeaderText = "Дата нового статуса";
            this.upDate.Name = "upDate";
            // 
            // how_much
            // 
            this.how_much.HeaderText = "Процент оплаченного";
            this.how_much.Name = "how_much";
            // 
            // ceh
            // 
            this.ceh.HeaderText = "Цех";
            this.ceh.Name = "ceh";
            this.ceh.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.chlbxCeh);
            this.Controls.Add(this.btnAddApp);
            this.Controls.Add(this.btnAddNSup);
            this.Controls.Add(this.dgvSupl);
            this.Name = "Main";
            this.Text = "Колхозный снабженец";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupl;
        private System.Windows.Forms.Button btnAddNSup;
        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.CheckedListBox chlbxCeh;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn firm;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuff;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfZakaz;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn upDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn how_much;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceh;
    }
}