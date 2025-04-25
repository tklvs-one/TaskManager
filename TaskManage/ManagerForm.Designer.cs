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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.CreateTab = new System.Windows.Forms.TabPage();
            this.cmbPriority = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbAssignee = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtTitle = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.ViewTab = new System.Windows.Forms.TabPage();
            this.cmbAssigneS = new MaterialSkin.Controls.MaterialComboBox();
            this.DisableFilters = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ApplyFilters = new System.Windows.Forms.Button();
            this.cmbPriorityS = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.CreateTab.SuspendLayout();
            this.ViewTab.SuspendLayout();
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
            this.materialTabControl1.Size = new System.Drawing.Size(849, 509);
            this.materialTabControl1.TabIndex = 0;
            // 
            // CreateTab
            // 
            this.CreateTab.BackColor = System.Drawing.Color.White;
            this.CreateTab.Controls.Add(this.cmbPriority);
            this.CreateTab.Controls.Add(this.cmbAssignee);
            this.CreateTab.Controls.Add(this.txtDescription);
            this.CreateTab.Controls.Add(this.txtTitle);
            this.CreateTab.Controls.Add(this.materialButton1);
            this.CreateTab.ImageKey = "icons8-добавить-32.png";
            this.CreateTab.Location = new System.Drawing.Point(4, 39);
            this.CreateTab.Name = "CreateTab";
            this.CreateTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreateTab.Size = new System.Drawing.Size(841, 466);
            this.CreateTab.TabIndex = 0;
            this.CreateTab.Text = "Создание";
            // 
            // cmbPriority
            // 
            this.cmbPriority.AutoResize = false;
            this.cmbPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPriority.Depth = 0;
            this.cmbPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPriority.DropDownHeight = 174;
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.DropDownWidth = 121;
            this.cmbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Hint = "Выберите уровень задачи";
            this.cmbPriority.IntegralHeight = false;
            this.cmbPriority.ItemHeight = 43;
            this.cmbPriority.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbPriority.Location = new System.Drawing.Point(19, 253);
            this.cmbPriority.MaxDropDownItems = 4;
            this.cmbPriority.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(763, 49);
            this.cmbPriority.StartIndex = 0;
            this.cmbPriority.TabIndex = 4;
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
            this.cmbAssignee.Location = new System.Drawing.Point(19, 314);
            this.cmbAssignee.MaxDropDownItems = 4;
            this.cmbAssignee.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbAssignee.Name = "cmbAssignee";
            this.cmbAssignee.Size = new System.Drawing.Size(763, 49);
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
            this.txtDescription.Size = new System.Drawing.Size(763, 158);
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
            this.txtTitle.Size = new System.Drawing.Size(763, 48);
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
            this.materialButton1.Location = new System.Drawing.Point(334, 414);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(151, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Создать задачу";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ViewTab
            // 
            this.ViewTab.Controls.Add(this.cmbAssigneS);
            this.ViewTab.Controls.Add(this.DisableFilters);
            this.ViewTab.Controls.Add(this.ApplyFilters);
            this.ViewTab.Controls.Add(this.cmbPriorityS);
            this.ViewTab.Controls.Add(this.cmbStatus);
            this.ViewTab.Controls.Add(this.materialButton2);
            this.ViewTab.Controls.Add(this.flowLayoutPanel1);
            this.ViewTab.ImageKey = "icons8-задания-32.png";
            this.ViewTab.Location = new System.Drawing.Point(4, 39);
            this.ViewTab.Name = "ViewTab";
            this.ViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewTab.Size = new System.Drawing.Size(841, 466);
            this.ViewTab.TabIndex = 1;
            this.ViewTab.Text = "Задачи";
            this.ViewTab.UseVisualStyleBackColor = true;
            // 
            // cmbAssigneS
            // 
            this.cmbAssigneS.AutoResize = false;
            this.cmbAssigneS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbAssigneS.Depth = 0;
            this.cmbAssigneS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbAssigneS.DropDownHeight = 174;
            this.cmbAssigneS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssigneS.DropDownWidth = 121;
            this.cmbAssigneS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbAssigneS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbAssigneS.FormattingEnabled = true;
            this.cmbAssigneS.IntegralHeight = false;
            this.cmbAssigneS.ItemHeight = 43;
            this.cmbAssigneS.Location = new System.Drawing.Point(422, 6);
            this.cmbAssigneS.MaxDropDownItems = 4;
            this.cmbAssigneS.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbAssigneS.Name = "cmbAssigneS";
            this.cmbAssigneS.Size = new System.Drawing.Size(207, 49);
            this.cmbAssigneS.StartIndex = 0;
            this.cmbAssigneS.TabIndex = 6;
            // 
            // DisableFilters
            // 
            this.DisableFilters.FlatAppearance.BorderSize = 0;
            this.DisableFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisableFilters.ImageIndex = 3;
            this.DisableFilters.ImageList = this.imageList1;
            this.DisableFilters.Location = new System.Drawing.Point(743, 11);
            this.DisableFilters.Name = "DisableFilters";
            this.DisableFilters.Size = new System.Drawing.Size(32, 32);
            this.DisableFilters.TabIndex = 5;
            this.DisableFilters.UseVisualStyleBackColor = true;
            this.DisableFilters.Click += new System.EventHandler(this.DisableFilters_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "icons8-добавить-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-задания-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-настройки-32.png");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "icons8-поиск-32.png");
            // 
            // ApplyFilters
            // 
            this.ApplyFilters.FlatAppearance.BorderSize = 0;
            this.ApplyFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyFilters.ImageIndex = 4;
            this.ApplyFilters.ImageList = this.imageList1;
            this.ApplyFilters.Location = new System.Drawing.Point(692, 11);
            this.ApplyFilters.Name = "ApplyFilters";
            this.ApplyFilters.Size = new System.Drawing.Size(32, 32);
            this.ApplyFilters.TabIndex = 4;
            this.ApplyFilters.UseVisualStyleBackColor = true;
            this.ApplyFilters.Click += new System.EventHandler(this.ApplyFilters_Click);
            // 
            // cmbPriorityS
            // 
            this.cmbPriorityS.AutoResize = false;
            this.cmbPriorityS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPriorityS.Depth = 0;
            this.cmbPriorityS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPriorityS.DropDownHeight = 174;
            this.cmbPriorityS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriorityS.DropDownWidth = 121;
            this.cmbPriorityS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPriorityS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPriorityS.FormattingEnabled = true;
            this.cmbPriorityS.Hint = "Приоритет работы";
            this.cmbPriorityS.IntegralHeight = false;
            this.cmbPriorityS.ItemHeight = 43;
            this.cmbPriorityS.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbPriorityS.Location = new System.Drawing.Point(213, 6);
            this.cmbPriorityS.MaxDropDownItems = 4;
            this.cmbPriorityS.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPriorityS.Name = "cmbPriorityS";
            this.cmbPriorityS.Size = new System.Drawing.Size(203, 49);
            this.cmbPriorityS.StartIndex = 0;
            this.cmbPriorityS.TabIndex = 3;
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoResize = false;
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbStatus.Depth = 0;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStatus.DropDownHeight = 174;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.DropDownWidth = 121;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Hint = "Статус работы";
            this.cmbStatus.IntegralHeight = false;
            this.cmbStatus.ItemHeight = 43;
            this.cmbStatus.Items.AddRange(new object[] {
            "В работе",
            "Выполнено",
            "Провалено",
            "Отказано"});
            this.cmbStatus.Location = new System.Drawing.Point(4, 6);
            this.cmbStatus.MaxDropDownItems = 4;
            this.cmbStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(199, 49);
            this.cmbStatus.StartIndex = 0;
            this.cmbStatus.TabIndex = 2;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(309, 435);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(157, 36);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "Загрузить новое";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(835, 362);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // SettingsTab
            // 
            this.SettingsTab.ImageKey = "icons8-настройки-32.png";
            this.SettingsTab.Location = new System.Drawing.Point(4, 39);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(841, 466);
            this.SettingsTab.TabIndex = 2;
            this.SettingsTab.Text = "Настройки";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(855, 576);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма руководителя";
            this.materialTabControl1.ResumeLayout(false);
            this.CreateTab.ResumeLayout(false);
            this.CreateTab.PerformLayout();
            this.ViewTab.ResumeLayout(false);
            this.ViewTab.PerformLayout();
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
        private MaterialSkin.Controls.MaterialComboBox cmbPriority;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialComboBox cmbPriorityS;
        private MaterialSkin.Controls.MaterialComboBox cmbStatus;
        private Button ApplyFilters;
        private Button DisableFilters;
        private MaterialSkin.Controls.MaterialComboBox cmbAssigneS;
    }
}