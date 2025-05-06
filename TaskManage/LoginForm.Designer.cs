namespace TaskManage
{
    partial class LoginForm
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
            this.txtLogin = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(67, 386);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(251, 20);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Нет аккаунта? Зарегистрироваться";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtLogin
            // 
            this.txtLogin.AllowPromptAsInput = true;
            this.txtLogin.AnimateReadOnly = false;
            this.txtLogin.AsciiOnly = false;
            this.txtLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLogin.BeepOnError = false;
            this.txtLogin.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtLogin.Depth = 0;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogin.HidePromptOnLeave = false;
            this.txtLogin.HideSelection = true;
            this.txtLogin.Hint = "Имя пользователя";
            this.txtLogin.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtLogin.LeadingIcon = null;
            this.txtLogin.Location = new System.Drawing.Point(36, 132);
            this.txtLogin.Mask = "";
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.PrefixSuffixText = null;
            this.txtLogin.PromptChar = '_';
            this.txtLogin.ReadOnly = false;
            this.txtLogin.RejectInputOnFirstFailure = false;
            this.txtLogin.ResetOnPrompt = true;
            this.txtLogin.ResetOnSpace = true;
            this.txtLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.ShortcutsEnabled = true;
            this.txtLogin.Size = new System.Drawing.Size(312, 48);
            this.txtLogin.SkipLiterals = true;
            this.txtLogin.TabIndex = 13;
            this.txtLogin.TabStop = false;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLogin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtLogin.TrailingIcon = null;
            this.txtLogin.UseSystemPasswordChar = false;
            this.txtLogin.ValidatingType = null;
            // 
            // txtPassword
            // 
            this.txtPassword.AllowPromptAsInput = true;
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.AsciiOnly = false;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.BeepOnError = false;
            this.txtPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HidePromptOnLeave = false;
            this.txtPassword.HideSelection = true;
            this.txtPassword.Hint = "Пароль";
            this.txtPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(36, 216);
            this.txtPassword.Mask = "";
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.PromptChar = '_';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RejectInputOnFirstFailure = false;
            this.txtPassword.ResetOnPrompt = true;
            this.txtPassword.ResetOnSpace = true;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(312, 48);
            this.txtPassword.SkipLiterals = true;
            this.txtPassword.TabIndex = 14;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.ValidatingType = null;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(90, 335);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(198, 45);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Войти";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.linkLabel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtLogin;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
    }
}