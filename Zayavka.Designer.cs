namespace Supplier
{
    partial class Zayavka
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
            this.lblSupl = new System.Windows.Forms.Label();
            this.cmbxSupl = new System.Windows.Forms.ComboBox();
            this.txtbxEmailSup = new System.Windows.Forms.TextBox();
            this.lblEmailSpl = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.txtbxEmailText = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.txtbxStuff = new System.Windows.Forms.TextBox();
            this.lblStuff = new System.Windows.Forms.Label();
            this.dtpDateOfApp = new System.Windows.Forms.DateTimePicker();
            this.lblDOZ = new System.Windows.Forms.Label();
            this.cmbxCeh = new System.Windows.Forms.ComboBox();
            this.lblCeh = new System.Windows.Forms.Label();
            this.lblHowMuch = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtbxCost = new System.Windows.Forms.TextBox();
            this.txtbxHowMuch = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtbxAmount = new System.Windows.Forms.TextBox();
            this.txtbxEdIzm = new System.Windows.Forms.TextBox();
            this.lblEdIzm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSupl
            // 
            this.lblSupl.AutoSize = true;
            this.lblSupl.Location = new System.Drawing.Point(34, 14);
            this.lblSupl.Name = "lblSupl";
            this.lblSupl.Size = new System.Drawing.Size(65, 13);
            this.lblSupl.TabIndex = 0;
            this.lblSupl.Text = "Поставщик";
            // 
            // cmbxSupl
            // 
            this.cmbxSupl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSupl.FormattingEnabled = true;
            this.cmbxSupl.Location = new System.Drawing.Point(106, 11);
            this.cmbxSupl.Name = "cmbxSupl";
            this.cmbxSupl.Size = new System.Drawing.Size(166, 21);
            this.cmbxSupl.TabIndex = 1;
            this.cmbxSupl.SelectedIndexChanged += new System.EventHandler(this.cmbxSupl_SelectedIndexChanged);
            // 
            // txtbxEmailSup
            // 
            this.txtbxEmailSup.Location = new System.Drawing.Point(106, 38);
            this.txtbxEmailSup.Name = "txtbxEmailSup";
            this.txtbxEmailSup.ReadOnly = true;
            this.txtbxEmailSup.Size = new System.Drawing.Size(166, 20);
            this.txtbxEmailSup.TabIndex = 2;
            // 
            // lblEmailSpl
            // 
            this.lblEmailSpl.AutoSize = true;
            this.lblEmailSpl.Location = new System.Drawing.Point(12, 42);
            this.lblEmailSpl.Name = "lblEmailSpl";
            this.lblEmailSpl.Size = new System.Drawing.Size(87, 13);
            this.lblEmailSpl.TabIndex = 3;
            this.lblEmailSpl.Text = "Почтовый ящик";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(93, 97);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(97, 13);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Текст сообщения";
            // 
            // txtbxEmailText
            // 
            this.txtbxEmailText.Location = new System.Drawing.Point(12, 113);
            this.txtbxEmailText.Multiline = true;
            this.txtbxEmailText.Name = "txtbxEmailText";
            this.txtbxEmailText.Size = new System.Drawing.Size(260, 158);
            this.txtbxEmailText.TabIndex = 5;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(184, 408);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(88, 55);
            this.btnSendEmail.TabIndex = 6;
            this.btnSendEmail.Text = "Отправить поставщику";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // txtbxStuff
            // 
            this.txtbxStuff.Location = new System.Drawing.Point(106, 330);
            this.txtbxStuff.Name = "txtbxStuff";
            this.txtbxStuff.Size = new System.Drawing.Size(166, 20);
            this.txtbxStuff.TabIndex = 7;
            // 
            // lblStuff
            // 
            this.lblStuff.AutoSize = true;
            this.lblStuff.Location = new System.Drawing.Point(65, 333);
            this.lblStuff.Name = "lblStuff";
            this.lblStuff.Size = new System.Drawing.Size(35, 13);
            this.lblStuff.TabIndex = 8;
            this.lblStuff.Text = "Вещь";
            // 
            // dtpDateOfApp
            // 
            this.dtpDateOfApp.Location = new System.Drawing.Point(106, 65);
            this.dtpDateOfApp.Name = "dtpDateOfApp";
            this.dtpDateOfApp.Size = new System.Drawing.Size(166, 20);
            this.dtpDateOfApp.TabIndex = 9;
            // 
            // lblDOZ
            // 
            this.lblDOZ.AutoSize = true;
            this.lblDOZ.Location = new System.Drawing.Point(27, 70);
            this.lblDOZ.Name = "lblDOZ";
            this.lblDOZ.Size = new System.Drawing.Size(72, 13);
            this.lblDOZ.TabIndex = 10;
            this.lblDOZ.Text = "Дата заказа";
            // 
            // cmbxCeh
            // 
            this.cmbxCeh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCeh.FormattingEnabled = true;
            this.cmbxCeh.Items.AddRange(new object[] {
            "Цех 1",
            "Цех 2",
            "Цех 3"});
            this.cmbxCeh.Location = new System.Drawing.Point(106, 381);
            this.cmbxCeh.Name = "cmbxCeh";
            this.cmbxCeh.Size = new System.Drawing.Size(166, 21);
            this.cmbxCeh.TabIndex = 11;
            // 
            // lblCeh
            // 
            this.lblCeh.AutoSize = true;
            this.lblCeh.Location = new System.Drawing.Point(74, 384);
            this.lblCeh.Name = "lblCeh";
            this.lblCeh.Size = new System.Drawing.Size(26, 13);
            this.lblCeh.TabIndex = 12;
            this.lblCeh.Text = "Цех";
            // 
            // lblHowMuch
            // 
            this.lblHowMuch.AutoSize = true;
            this.lblHowMuch.Location = new System.Drawing.Point(43, 307);
            this.lblHowMuch.Name = "lblHowMuch";
            this.lblHowMuch.Size = new System.Drawing.Size(56, 13);
            this.lblHowMuch.TabIndex = 14;
            this.lblHowMuch.Text = "Оплачено";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(38, 281);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(62, 13);
            this.lblCost.TabIndex = 15;
            this.lblCost.Text = "Стоимость";
            // 
            // txtbxCost
            // 
            this.txtbxCost.Location = new System.Drawing.Point(106, 278);
            this.txtbxCost.Name = "txtbxCost";
            this.txtbxCost.Size = new System.Drawing.Size(166, 20);
            this.txtbxCost.TabIndex = 16;
            this.txtbxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxCost_KeyPress);
            // 
            // txtbxHowMuch
            // 
            this.txtbxHowMuch.Location = new System.Drawing.Point(106, 304);
            this.txtbxHowMuch.Name = "txtbxHowMuch";
            this.txtbxHowMuch.Size = new System.Drawing.Size(166, 20);
            this.txtbxHowMuch.TabIndex = 17;
            this.txtbxHowMuch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxCost_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(34, 358);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(66, 13);
            this.lblAmount.TabIndex = 18;
            this.lblAmount.Text = "Количество";
            // 
            // txtbxAmount
            // 
            this.txtbxAmount.Location = new System.Drawing.Point(106, 355);
            this.txtbxAmount.Name = "txtbxAmount";
            this.txtbxAmount.Size = new System.Drawing.Size(76, 20);
            this.txtbxAmount.TabIndex = 19;
            this.txtbxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxCost_KeyPress);
            // 
            // txtbxEdIzm
            // 
            this.txtbxEdIzm.Location = new System.Drawing.Point(231, 355);
            this.txtbxEdIzm.Name = "txtbxEdIzm";
            this.txtbxEdIzm.Size = new System.Drawing.Size(41, 20);
            this.txtbxEdIzm.TabIndex = 20;
            // 
            // lblEdIzm
            // 
            this.lblEdIzm.AutoSize = true;
            this.lblEdIzm.Location = new System.Drawing.Point(188, 358);
            this.lblEdIzm.Name = "lblEdIzm";
            this.lblEdIzm.Size = new System.Drawing.Size(37, 13);
            this.lblEdIzm.TabIndex = 21;
            this.lblEdIzm.Text = "ед.из.";
            // 
            // Zayavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 471);
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
            this.Name = "Zayavka";
            this.Text = "Новый заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupl;
        private System.Windows.Forms.ComboBox cmbxSupl;
        private System.Windows.Forms.TextBox txtbxEmailSup;
        private System.Windows.Forms.Label lblEmailSpl;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtbxEmailText;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.TextBox txtbxStuff;
        private System.Windows.Forms.Label lblStuff;
        private System.Windows.Forms.DateTimePicker dtpDateOfApp;
        private System.Windows.Forms.Label lblDOZ;
        private System.Windows.Forms.ComboBox cmbxCeh;
        private System.Windows.Forms.Label lblCeh;
        private System.Windows.Forms.Label lblHowMuch;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtbxCost;
        private System.Windows.Forms.TextBox txtbxHowMuch;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtbxAmount;
        private System.Windows.Forms.TextBox txtbxEdIzm;
        private System.Windows.Forms.Label lblEdIzm;
    }
}