namespace Supplier
{
    partial class NewOrder
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
            this.lblEdIzm = new System.Windows.Forms.Label();
            this.txtbxEdIzm = new System.Windows.Forms.TextBox();
            this.txtbxAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtbxHowMuch = new System.Windows.Forms.TextBox();
            this.txtbxCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblHowMuch = new System.Windows.Forms.Label();
            this.lblCeh = new System.Windows.Forms.Label();
            this.cmbxCeh = new System.Windows.Forms.ComboBox();
            this.lblDOZ = new System.Windows.Forms.Label();
            this.dtpDateOfApp = new System.Windows.Forms.DateTimePicker();
            this.lblStuff = new System.Windows.Forms.Label();
            this.txtbxStuff = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.txtbxEmailText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblEmailSpl = new System.Windows.Forms.Label();
            this.txtbxEmailSup = new System.Windows.Forms.TextBox();
            this.cmbxSupl = new System.Windows.Forms.ComboBox();
            this.lblSupl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEdIzm
            // 
            this.lblEdIzm.AutoSize = true;
            this.lblEdIzm.Location = new System.Drawing.Point(188, 360);
            this.lblEdIzm.Name = "lblEdIzm";
            this.lblEdIzm.Size = new System.Drawing.Size(37, 13);
            this.lblEdIzm.TabIndex = 42;
            this.lblEdIzm.Text = "ед.из.";
            // 
            // txtbxEdIzm
            // 
            this.txtbxEdIzm.Location = new System.Drawing.Point(231, 357);
            this.txtbxEdIzm.Name = "txtbxEdIzm";
            this.txtbxEdIzm.Size = new System.Drawing.Size(41, 20);
            this.txtbxEdIzm.TabIndex = 41;
            // 
            // txtbxAmount
            // 
            this.txtbxAmount.Location = new System.Drawing.Point(106, 357);
            this.txtbxAmount.Name = "txtbxAmount";
            this.txtbxAmount.Size = new System.Drawing.Size(76, 20);
            this.txtbxAmount.TabIndex = 40;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(34, 360);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(66, 13);
            this.lblAmount.TabIndex = 39;
            this.lblAmount.Text = "Количество";
            // 
            // txtbxHowMuch
            // 
            this.txtbxHowMuch.Location = new System.Drawing.Point(106, 306);
            this.txtbxHowMuch.Name = "txtbxHowMuch";
            this.txtbxHowMuch.Size = new System.Drawing.Size(166, 20);
            this.txtbxHowMuch.TabIndex = 38;
            // 
            // txtbxCost
            // 
            this.txtbxCost.Location = new System.Drawing.Point(106, 280);
            this.txtbxCost.Name = "txtbxCost";
            this.txtbxCost.Size = new System.Drawing.Size(166, 20);
            this.txtbxCost.TabIndex = 37;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(38, 283);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(62, 13);
            this.lblCost.TabIndex = 36;
            this.lblCost.Text = "Стоимость";
            // 
            // lblHowMuch
            // 
            this.lblHowMuch.AutoSize = true;
            this.lblHowMuch.Location = new System.Drawing.Point(43, 309);
            this.lblHowMuch.Name = "lblHowMuch";
            this.lblHowMuch.Size = new System.Drawing.Size(56, 13);
            this.lblHowMuch.TabIndex = 35;
            this.lblHowMuch.Text = "Оплачено";
            // 
            // lblCeh
            // 
            this.lblCeh.AutoSize = true;
            this.lblCeh.Location = new System.Drawing.Point(74, 386);
            this.lblCeh.Name = "lblCeh";
            this.lblCeh.Size = new System.Drawing.Size(26, 13);
            this.lblCeh.TabIndex = 34;
            this.lblCeh.Text = "Цех";
            // 
            // cmbxCeh
            // 
            this.cmbxCeh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCeh.FormattingEnabled = true;
            this.cmbxCeh.Items.AddRange(new object[] {
            "Цех 1",
            "Цех 2",
            "Цех 3"});
            this.cmbxCeh.Location = new System.Drawing.Point(106, 383);
            this.cmbxCeh.Name = "cmbxCeh";
            this.cmbxCeh.Size = new System.Drawing.Size(166, 21);
            this.cmbxCeh.TabIndex = 33;
            // 
            // lblDOZ
            // 
            this.lblDOZ.AutoSize = true;
            this.lblDOZ.Location = new System.Drawing.Point(27, 72);
            this.lblDOZ.Name = "lblDOZ";
            this.lblDOZ.Size = new System.Drawing.Size(72, 13);
            this.lblDOZ.TabIndex = 32;
            this.lblDOZ.Text = "Дата заказа";
            // 
            // dtpDateOfApp
            // 
            this.dtpDateOfApp.Location = new System.Drawing.Point(106, 67);
            this.dtpDateOfApp.Name = "dtpDateOfApp";
            this.dtpDateOfApp.Size = new System.Drawing.Size(166, 20);
            this.dtpDateOfApp.TabIndex = 31;
            // 
            // lblStuff
            // 
            this.lblStuff.AutoSize = true;
            this.lblStuff.Location = new System.Drawing.Point(65, 335);
            this.lblStuff.Name = "lblStuff";
            this.lblStuff.Size = new System.Drawing.Size(35, 13);
            this.lblStuff.TabIndex = 30;
            this.lblStuff.Text = "Вещь";
            // 
            // txtbxStuff
            // 
            this.txtbxStuff.Location = new System.Drawing.Point(106, 332);
            this.txtbxStuff.Name = "txtbxStuff";
            this.txtbxStuff.Size = new System.Drawing.Size(166, 20);
            this.txtbxStuff.TabIndex = 29;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(184, 410);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(88, 55);
            this.btnSendEmail.TabIndex = 28;
            this.btnSendEmail.Text = "Отправить поставщику";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            // 
            // txtbxEmailText
            // 
            this.txtbxEmailText.Location = new System.Drawing.Point(12, 115);
            this.txtbxEmailText.Multiline = true;
            this.txtbxEmailText.Name = "txtbxEmailText";
            this.txtbxEmailText.Size = new System.Drawing.Size(260, 158);
            this.txtbxEmailText.TabIndex = 27;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(93, 99);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(97, 13);
            this.lblText.TabIndex = 26;
            this.lblText.Text = "Текст сообщения";
            // 
            // lblEmailSpl
            // 
            this.lblEmailSpl.AutoSize = true;
            this.lblEmailSpl.Location = new System.Drawing.Point(12, 44);
            this.lblEmailSpl.Name = "lblEmailSpl";
            this.lblEmailSpl.Size = new System.Drawing.Size(87, 13);
            this.lblEmailSpl.TabIndex = 25;
            this.lblEmailSpl.Text = "Почтовый ящик";
            // 
            // txtbxEmailSup
            // 
            this.txtbxEmailSup.Location = new System.Drawing.Point(106, 40);
            this.txtbxEmailSup.Name = "txtbxEmailSup";
            this.txtbxEmailSup.ReadOnly = true;
            this.txtbxEmailSup.Size = new System.Drawing.Size(166, 20);
            this.txtbxEmailSup.TabIndex = 24;
            // 
            // cmbxSupl
            // 
            this.cmbxSupl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSupl.FormattingEnabled = true;
            this.cmbxSupl.Location = new System.Drawing.Point(106, 13);
            this.cmbxSupl.Name = "cmbxSupl";
            this.cmbxSupl.Size = new System.Drawing.Size(166, 21);
            this.cmbxSupl.TabIndex = 23;
            // 
            // lblSupl
            // 
            this.lblSupl.AutoSize = true;
            this.lblSupl.Location = new System.Drawing.Point(34, 16);
            this.lblSupl.Name = "lblSupl";
            this.lblSupl.Size = new System.Drawing.Size(65, 13);
            this.lblSupl.TabIndex = 22;
            this.lblSupl.Text = "Поставщик";
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 477);
            this.Controls.Add(this.lblEdIzm);
            this.Controls.Add(this.txtbxEdIzm);
            this.Controls.Add(this.txtbxAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtbxHowMuch);
            this.Controls.Add(this.txtbxCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblHowMuch);
            this.Controls.Add(this.lblCeh);
            this.Controls.Add(this.cmbxCeh);
            this.Controls.Add(this.lblDOZ);
            this.Controls.Add(this.dtpDateOfApp);
            this.Controls.Add(this.lblStuff);
            this.Controls.Add(this.txtbxStuff);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.txtbxEmailText);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblEmailSpl);
            this.Controls.Add(this.txtbxEmailSup);
            this.Controls.Add(this.cmbxSupl);
            this.Controls.Add(this.lblSupl);
            this.Name = "NewOrder";
            this.Text = "Новый заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdIzm;
        private System.Windows.Forms.TextBox txtbxEdIzm;
        private System.Windows.Forms.TextBox txtbxAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtbxHowMuch;
        private System.Windows.Forms.TextBox txtbxCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblHowMuch;
        private System.Windows.Forms.Label lblCeh;
        private System.Windows.Forms.ComboBox cmbxCeh;
        private System.Windows.Forms.Label lblDOZ;
        private System.Windows.Forms.DateTimePicker dtpDateOfApp;
        private System.Windows.Forms.Label lblStuff;
        private System.Windows.Forms.TextBox txtbxStuff;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.TextBox txtbxEmailText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblEmailSpl;
        private System.Windows.Forms.TextBox txtbxEmailSup;
        private System.Windows.Forms.ComboBox cmbxSupl;
        private System.Windows.Forms.Label lblSupl;
    }
}