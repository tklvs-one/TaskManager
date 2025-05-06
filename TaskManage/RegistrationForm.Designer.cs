namespace TaskManage
{
    partial class RegistrationForm
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtManagerLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.chkIsManager = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnRegister = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(100, 464);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(179, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Уже есть аккаунт? Войти";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtLogin
            // 
            this.txtLogin.AnimateReadOnly = false;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Depth = 0;
            this.txtLogin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogin.Hint = "Введите имя пользователя";
            this.txtLogin.LeadingIcon = null;
            this.txtLogin.Location = new System.Drawing.Point(66, 125);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLogin.Multiline = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(258, 50);
            this.txtLogin.TabIndex = 9;
            this.txtLogin.Text = "";
            this.txtLogin.TrailingIcon = null;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "Введите пароль";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(66, 189);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(258, 50);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // txtManagerLogin
            // 
            this.txtManagerLogin.AnimateReadOnly = false;
            this.txtManagerLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtManagerLogin.Depth = 0;
            this.txtManagerLogin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtManagerLogin.Hint = "Логин начальника";
            this.txtManagerLogin.LeadingIcon = null;
            this.txtManagerLogin.Location = new System.Drawing.Point(66, 255);
            this.txtManagerLogin.MaxLength = 50;
            this.txtManagerLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtManagerLogin.Multiline = false;
            this.txtManagerLogin.Name = "txtManagerLogin";
            this.txtManagerLogin.Size = new System.Drawing.Size(258, 50);
            this.txtManagerLogin.TabIndex = 11;
            this.txtManagerLogin.Text = "";
            this.txtManagerLogin.TrailingIcon = null;
            // 
            // chkIsManager
            // 
            this.chkIsManager.AutoSize = true;
            this.chkIsManager.Depth = 0;
            this.chkIsManager.Location = new System.Drawing.Point(110, 412);
            this.chkIsManager.Margin = new System.Windows.Forms.Padding(0);
            this.chkIsManager.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkIsManager.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkIsManager.Name = "chkIsManager";
            this.chkIsManager.ReadOnly = false;
            this.chkIsManager.Ripple = true;
            this.chkIsManager.Size = new System.Drawing.Size(155, 37);
            this.chkIsManager.TabIndex = 12;
            this.chkIsManager.Text = "Я руководитель";
            this.chkIsManager.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegister.Depth = 0;
            this.btnRegister.HighEmphasis = true;
            this.btnRegister.Icon = null;
            this.btnRegister.Location = new System.Drawing.Point(97, 357);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegister.Size = new System.Drawing.Size(191, 36);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegister.UseAccentColor = false;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chkIsManager);
            this.Controls.Add(this.txtManagerLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.linkLabel1);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtLogin;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtManagerLogin;
        private MaterialSkin.Controls.MaterialCheckbox chkIsManager;
        private MaterialSkin.Controls.MaterialButton btnRegister;
    }
}