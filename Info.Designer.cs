namespace Supplier
{
    partial class Info
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
            this.txtbxSupl = new System.Windows.Forms.TextBox();
            this.txtbxEmSpl = new System.Windows.Forms.TextBox();
            this.lblEmSupl = new System.Windows.Forms.Label();
            this.lblTextEm = new System.Windows.Forms.Label();
            this.txtbxTextEm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpDOfZ = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxPer = new System.Windows.Forms.TextBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.txtbxOrder = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSupl
            // 
            this.lblSupl.AutoSize = true;
            this.lblSupl.Location = new System.Drawing.Point(95, 9);
            this.lblSupl.Name = "lblSupl";
            this.lblSupl.Size = new System.Drawing.Size(65, 13);
            this.lblSupl.TabIndex = 0;
            this.lblSupl.Text = "Поставщик";
            // 
            // txtbxSupl
            // 
            this.txtbxSupl.Location = new System.Drawing.Point(166, 6);
            this.txtbxSupl.Name = "txtbxSupl";
            this.txtbxSupl.ReadOnly = true;
            this.txtbxSupl.Size = new System.Drawing.Size(162, 20);
            this.txtbxSupl.TabIndex = 1;
            // 
            // txtbxEmSpl
            // 
            this.txtbxEmSpl.Location = new System.Drawing.Point(166, 33);
            this.txtbxEmSpl.Name = "txtbxEmSpl";
            this.txtbxEmSpl.ReadOnly = true;
            this.txtbxEmSpl.Size = new System.Drawing.Size(162, 20);
            this.txtbxEmSpl.TabIndex = 2;
            // 
            // lblEmSupl
            // 
            this.lblEmSupl.AutoSize = true;
            this.lblEmSupl.Location = new System.Drawing.Point(8, 36);
            this.lblEmSupl.Name = "lblEmSupl";
            this.lblEmSupl.Size = new System.Drawing.Size(152, 13);
            this.lblEmSupl.TabIndex = 3;
            this.lblEmSupl.Text = "Почтовый ящик поставщика";
            // 
            // lblTextEm
            // 
            this.lblTextEm.AutoSize = true;
            this.lblTextEm.Location = new System.Drawing.Point(123, 69);
            this.lblTextEm.Name = "lblTextEm";
            this.lblTextEm.Size = new System.Drawing.Size(97, 13);
            this.lblTextEm.TabIndex = 4;
            this.lblTextEm.Text = "Текст сообщения";
            // 
            // txtbxTextEm
            // 
            this.txtbxTextEm.Location = new System.Drawing.Point(12, 92);
            this.txtbxTextEm.Multiline = true;
            this.txtbxTextEm.Name = "txtbxTextEm";
            this.txtbxTextEm.ReadOnly = true;
            this.txtbxTextEm.Size = new System.Drawing.Size(316, 117);
            this.txtbxTextEm.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Статус";
            // 
            // cmbxStatus
            // 
            this.cmbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxStatus.FormattingEnabled = true;
            this.cmbxStatus.Items.AddRange(new object[] {
            "Заявка принята",
            "Ожидается",
            "На складе"});
            this.cmbxStatus.Location = new System.Drawing.Point(166, 305);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(162, 21);
            this.cmbxStatus.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Оплачено";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(12, 392);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(150, 23);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Сохранить изменения";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(166, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtpDOfZ
            // 
            this.dtpDOfZ.Enabled = false;
            this.dtpDOfZ.Location = new System.Drawing.Point(166, 215);
            this.dtpDOfZ.Name = "dtpDOfZ";
            this.dtpDOfZ.Size = new System.Drawing.Size(162, 20);
            this.dtpDOfZ.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата заказа";
            // 
            // txtbxPer
            // 
            this.txtbxPer.Location = new System.Drawing.Point(166, 336);
            this.txtbxPer.Name = "txtbxPer";
            this.txtbxPer.Size = new System.Drawing.Size(162, 20);
            this.txtbxPer.TabIndex = 14;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(122, 248);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(38, 13);
            this.lblOrder.TabIndex = 15;
            this.lblOrder.Text = "Заказ";
            // 
            // txtbxOrder
            // 
            this.txtbxOrder.Location = new System.Drawing.Point(166, 245);
            this.txtbxOrder.Name = "txtbxOrder";
            this.txtbxOrder.ReadOnly = true;
            this.txtbxOrder.Size = new System.Drawing.Size(162, 20);
            this.txtbxOrder.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Количество";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 366);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Цех";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 433);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtbxOrder);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.txtbxPer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDOfZ);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxTextEm);
            this.Controls.Add(this.lblTextEm);
            this.Controls.Add(this.lblEmSupl);
            this.Controls.Add(this.txtbxEmSpl);
            this.Controls.Add(this.txtbxSupl);
            this.Controls.Add(this.lblSupl);
            this.Name = "Info";
            this.Text = "Информация о заказе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupl;
        private System.Windows.Forms.TextBox txtbxSupl;
        private System.Windows.Forms.TextBox txtbxEmSpl;
        private System.Windows.Forms.Label lblEmSupl;
        private System.Windows.Forms.Label lblTextEm;
        private System.Windows.Forms.TextBox txtbxTextEm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpDOfZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxPer;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.TextBox txtbxOrder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}