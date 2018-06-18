namespace Supplier
{
    partial class Entry
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtbxPass = new System.Windows.Forms.TextBox();
            this.txtbxLogin = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuest
            // 
            this.btnGuest.Location = new System.Drawing.Point(137, 152);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(107, 28);
            this.btnGuest.TabIndex = 13;
            this.btnGuest.Text = "Войти как гость";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(12, 152);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(107, 28);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtbxPass
            // 
            this.txtbxPass.Location = new System.Drawing.Point(54, 112);
            this.txtbxPass.Name = "txtbxPass";
            this.txtbxPass.Size = new System.Drawing.Size(189, 20);
            this.txtbxPass.TabIndex = 11;
            this.txtbxPass.UseSystemPasswordChar = true;
            this.txtbxPass.TextChanged += new System.EventHandler(this.txtbxPass_TextChanged);
            // 
            // txtbxLogin
            // 
            this.txtbxLogin.Location = new System.Drawing.Point(54, 79);
            this.txtbxLogin.Name = "txtbxLogin";
            this.txtbxLogin.Size = new System.Drawing.Size(189, 20);
            this.txtbxLogin.TabIndex = 10;
            this.txtbxLogin.TextChanged += new System.EventHandler(this.txtbxLogin_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(232, 56);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Для того, чтобы отсылать сообщения, необходимо войти в учетную запись почтового я" +
    "щика, с которого будут отсылаться письма закупок";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 115);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Пароль";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(10, 82);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Логин";
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 196);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtbxPass);
            this.Controls.Add(this.txtbxLogin);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Name = "Entry";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtbxPass;
        private System.Windows.Forms.TextBox txtbxLogin;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
    }
}

