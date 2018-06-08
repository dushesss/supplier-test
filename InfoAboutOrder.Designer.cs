namespace Supplier
{
    partial class InfoAboutOrder
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxCeh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxAmount = new System.Windows.Forms.TextBox();
            this.txtbxOrder = new System.Windows.Forms.TextBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDOfZ = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.cmbxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxTextEm = new System.Windows.Forms.TextBox();
            this.lblTextEm = new System.Windows.Forms.Label();
            this.lblEmSupl = new System.Windows.Forms.Label();
            this.txtbxEmSpl = new System.Windows.Forms.TextBox();
            this.txtbxSupl = new System.Windows.Forms.TextBox();
            this.lblSupl = new System.Windows.Forms.Label();
            this.txtbxHowMuch = new System.Windows.Forms.TextBox();
            this.txtbxCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblHowMuch = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Цех";
            // 
            // txtbxCeh
            // 
            this.txtbxCeh.Location = new System.Drawing.Point(166, 389);
            this.txtbxCeh.Name = "txtbxCeh";
            this.txtbxCeh.ReadOnly = true;
            this.txtbxCeh.Size = new System.Drawing.Size(162, 20);
            this.txtbxCeh.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Количество";
            // 
            // txtbxAmount
            // 
            this.txtbxAmount.Location = new System.Drawing.Point(166, 280);
            this.txtbxAmount.Name = "txtbxAmount";
            this.txtbxAmount.ReadOnly = true;
            this.txtbxAmount.Size = new System.Drawing.Size(162, 20);
            this.txtbxAmount.TabIndex = 37;
            // 
            // txtbxOrder
            // 
            this.txtbxOrder.Location = new System.Drawing.Point(166, 250);
            this.txtbxOrder.Name = "txtbxOrder";
            this.txtbxOrder.ReadOnly = true;
            this.txtbxOrder.Size = new System.Drawing.Size(162, 20);
            this.txtbxOrder.TabIndex = 36;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(122, 253);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(38, 13);
            this.lblOrder.TabIndex = 35;
            this.lblOrder.Text = "Товар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Дата заказа";
            // 
            // dtpDOfZ
            // 
            this.dtpDOfZ.Enabled = false;
            this.dtpDOfZ.Location = new System.Drawing.Point(166, 220);
            this.dtpDOfZ.Name = "dtpDOfZ";
            this.dtpDOfZ.Size = new System.Drawing.Size(162, 20);
            this.dtpDOfZ.TabIndex = 32;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(168, 447);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 28);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(166, 415);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(162, 26);
            this.btnAccept.TabIndex = 30;
            this.btnAccept.Text = "Сохранить изменения";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // cmbxStatus
            // 
            this.cmbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxStatus.FormattingEnabled = true;
            this.cmbxStatus.Items.AddRange(new object[] {
            "Заявка принята",
            "Ожидается",
            "На складе"});
            this.cmbxStatus.Location = new System.Drawing.Point(166, 310);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(162, 21);
            this.cmbxStatus.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Статус";
            // 
            // txtbxTextEm
            // 
            this.txtbxTextEm.Location = new System.Drawing.Point(12, 97);
            this.txtbxTextEm.Multiline = true;
            this.txtbxTextEm.Name = "txtbxTextEm";
            this.txtbxTextEm.ReadOnly = true;
            this.txtbxTextEm.Size = new System.Drawing.Size(316, 117);
            this.txtbxTextEm.TabIndex = 26;
            // 
            // lblTextEm
            // 
            this.lblTextEm.AutoSize = true;
            this.lblTextEm.Location = new System.Drawing.Point(123, 74);
            this.lblTextEm.Name = "lblTextEm";
            this.lblTextEm.Size = new System.Drawing.Size(97, 13);
            this.lblTextEm.TabIndex = 25;
            this.lblTextEm.Text = "Текст сообщения";
            // 
            // lblEmSupl
            // 
            this.lblEmSupl.AutoSize = true;
            this.lblEmSupl.Location = new System.Drawing.Point(8, 41);
            this.lblEmSupl.Name = "lblEmSupl";
            this.lblEmSupl.Size = new System.Drawing.Size(152, 13);
            this.lblEmSupl.TabIndex = 24;
            this.lblEmSupl.Text = "Почтовый ящик поставщика";
            // 
            // txtbxEmSpl
            // 
            this.txtbxEmSpl.Location = new System.Drawing.Point(166, 38);
            this.txtbxEmSpl.Name = "txtbxEmSpl";
            this.txtbxEmSpl.ReadOnly = true;
            this.txtbxEmSpl.Size = new System.Drawing.Size(162, 20);
            this.txtbxEmSpl.TabIndex = 23;
            // 
            // txtbxSupl
            // 
            this.txtbxSupl.Location = new System.Drawing.Point(166, 11);
            this.txtbxSupl.Name = "txtbxSupl";
            this.txtbxSupl.ReadOnly = true;
            this.txtbxSupl.Size = new System.Drawing.Size(162, 20);
            this.txtbxSupl.TabIndex = 22;
            // 
            // lblSupl
            // 
            this.lblSupl.AutoSize = true;
            this.lblSupl.Location = new System.Drawing.Point(95, 14);
            this.lblSupl.Name = "lblSupl";
            this.lblSupl.Size = new System.Drawing.Size(65, 13);
            this.lblSupl.TabIndex = 21;
            this.lblSupl.Text = "Поставщик";
            // 
            // txtbxHowMuch
            // 
            this.txtbxHowMuch.Location = new System.Drawing.Point(166, 363);
            this.txtbxHowMuch.Name = "txtbxHowMuch";
            this.txtbxHowMuch.Size = new System.Drawing.Size(162, 20);
            this.txtbxHowMuch.TabIndex = 44;
            // 
            // txtbxCost
            // 
            this.txtbxCost.Location = new System.Drawing.Point(166, 337);
            this.txtbxCost.Name = "txtbxCost";
            this.txtbxCost.Size = new System.Drawing.Size(162, 20);
            this.txtbxCost.TabIndex = 43;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(98, 340);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(62, 13);
            this.lblCost.TabIndex = 42;
            this.lblCost.Text = "Стоимость";
            // 
            // lblHowMuch
            // 
            this.lblHowMuch.AutoSize = true;
            this.lblHowMuch.Location = new System.Drawing.Point(104, 366);
            this.lblHowMuch.Name = "lblHowMuch";
            this.lblHowMuch.Size = new System.Drawing.Size(56, 13);
            this.lblHowMuch.TabIndex = 41;
            this.lblHowMuch.Text = "Оплачено";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 45;
            this.button1.Text = "Новый заказ на основе этого";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InfoAboutOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbxHowMuch);
            this.Controls.Add(this.txtbxCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblHowMuch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxCeh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxAmount);
            this.Controls.Add(this.txtbxOrder);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDOfZ);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cmbxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxTextEm);
            this.Controls.Add(this.lblTextEm);
            this.Controls.Add(this.lblEmSupl);
            this.Controls.Add(this.txtbxEmSpl);
            this.Controls.Add(this.txtbxSupl);
            this.Controls.Add(this.lblSupl);
            this.Name = "InfoAboutOrder";
            this.Text = "InfoAboutOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxCeh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxAmount;
        private System.Windows.Forms.TextBox txtbxOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDOfZ;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cmbxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxTextEm;
        private System.Windows.Forms.Label lblTextEm;
        private System.Windows.Forms.Label lblEmSupl;
        private System.Windows.Forms.TextBox txtbxEmSpl;
        private System.Windows.Forms.TextBox txtbxSupl;
        private System.Windows.Forms.Label lblSupl;
        private System.Windows.Forms.TextBox txtbxHowMuch;
        private System.Windows.Forms.TextBox txtbxCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblHowMuch;
        private System.Windows.Forms.Button button1;
    }
}