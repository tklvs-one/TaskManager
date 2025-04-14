namespace TaskManage
{
    partial class ManagerForm
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.CreateTab = new System.Windows.Forms.TabPage();
            this.cmbAssignee = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtTitle = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.ViewTab = new System.Windows.Forms.TabPage();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.CreateTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.CreateTab);
            this.materialTabControl1.Controls.Add(this.ViewTab);
            this.materialTabControl1.Controls.Add(this.SettingsTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(819, 421);
            this.materialTabControl1.TabIndex = 0;
            // 
            // CreateTab
            // 
            this.CreateTab.Controls.Add(this.cmbAssignee);
            this.CreateTab.Controls.Add(this.txtDescription);
            this.CreateTab.Controls.Add(this.txtTitle);
            this.CreateTab.Controls.Add(this.materialButton1);
            this.CreateTab.ImageIndex = 1;
            this.CreateTab.Location = new System.Drawing.Point(4, 29);
            this.CreateTab.Name = "CreateTab";
            this.CreateTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreateTab.Size = new System.Drawing.Size(811, 388);
            this.CreateTab.TabIndex = 0;
            this.CreateTab.Text = "Создание";
            this.CreateTab.UseVisualStyleBackColor = true;
            // 
            // cmbAssignee
            // 
            this.cmbAssignee.AutoResize = false;
            this.cmbAssignee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbAssignee.Depth = 0;
            this.cmbAssignee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbAssignee.DropDownHeight = 174;
            this.cmbAssignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignee.DropDownWidth = 121;
            this.cmbAssignee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbAssignee.ForeColor = System.Drawing.Color.White;
            this.cmbAssignee.FormattingEnabled = true;
            this.cmbAssignee.Hint = "Выберите ответственного";
            this.cmbAssignee.IntegralHeight = false;
            this.cmbAssignee.ItemHeight = 43;
            this.cmbAssignee.Location = new System.Drawing.Point(19, 253);
            this.cmbAssignee.MaxDropDownItems = 4;
            this.cmbAssignee.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbAssignee.Name = "cmbAssignee";
            this.cmbAssignee.Size = new System.Drawing.Size(374, 49);
            this.cmbAssignee.StartIndex = 0;
            this.cmbAssignee.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.AnimateReadOnly = false;
            this.txtDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescription.Depth = 0;
            this.txtDescription.HideSelection = true;
            this.txtDescription.Hint = "Текст задачи";
            this.txtDescription.Location = new System.Drawing.Point(19, 80);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ReadOnly = false;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(374, 158);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TabStop = false;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.UseSystemPasswordChar = false;
            // 
            // txtTitle
            // 
            this.txtTitle.AllowPromptAsInput = false;
            this.txtTitle.AnimateReadOnly = false;
            this.txtTitle.AsciiOnly = false;
            this.txtTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTitle.BeepOnError = false;
            this.txtTitle.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTitle.Depth = 0;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitle.HidePromptOnLeave = false;
            this.txtTitle.HideSelection = true;
            this.txtTitle.Hint = "Заголовок задачи";
            this.txtTitle.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtTitle.LeadingIcon = null;
            this.txtTitle.Location = new System.Drawing.Point(19, 15);
            this.txtTitle.Mask = "";
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PrefixSuffixText = null;
            this.txtTitle.PromptChar = '_';
            this.txtTitle.ReadOnly = false;
            this.txtTitle.RejectInputOnFirstFailure = false;
            this.txtTitle.ResetOnPrompt = true;
            this.txtTitle.ResetOnSpace = true;
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(374, 48);
            this.txtTitle.SkipLiterals = true;
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TabStop = false;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitle.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTitle.TrailingIcon = null;
            this.txtTitle.UseSystemPasswordChar = false;
            this.txtTitle.ValidatingType = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(124, 311);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ViewTab
            // 
            this.ViewTab.ImageIndex = 0;
            this.ViewTab.Location = new System.Drawing.Point(4, 29);
            this.ViewTab.Name = "ViewTab";
            this.ViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewTab.Size = new System.Drawing.Size(811, 388);
            this.ViewTab.TabIndex = 1;
            this.ViewTab.Text = "Задачи";
            this.ViewTab.UseVisualStyleBackColor = true;
            // 
            // SettingsTab
            // 
            this.SettingsTab.ImageIndex = 2;
            this.SettingsTab.Location = new System.Drawing.Point(4, 29);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(811, 388);
            this.SettingsTab.TabIndex = 2;
            this.SettingsTab.Text = "Настройки";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(825, 488);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.materialTabControl1.ResumeLayout(false);
            this.CreateTab.ResumeLayout(false);
            this.CreateTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage CreateTab;
        private TabPage ViewTab;
        private TabPage SettingsTab;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtTitle;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescription;
        private MaterialSkin.Controls.MaterialComboBox cmbAssignee;
    }
}