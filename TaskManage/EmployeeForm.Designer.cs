namespace TaskManage
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageTasks = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanelInProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageCompletedTasks = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.DisableFilters = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ApplyFilters = new System.Windows.Forms.Button();
            this.cmbStatusFilter = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbPriorityFilter = new MaterialSkin.Controls.MaterialComboBox();
            this.flowLayoutPanelCompleted = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbPriorityNotMade = new MaterialSkin.Controls.MaterialComboBox();
            this.ApplyFiltersInWork = new System.Windows.Forms.Button();
            this.DisableFiltersNoMade = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.tabPageTasks.SuspendLayout();
            this.tabPageCompletedTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageTasks);
            this.materialTabControl1.Controls.Add(this.tabPageCompletedTasks);
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
            // tabPageTasks
            // 
            this.tabPageTasks.BackColor = System.Drawing.Color.White;
            this.tabPageTasks.Controls.Add(this.DisableFiltersNoMade);
            this.tabPageTasks.Controls.Add(this.ApplyFiltersInWork);
            this.tabPageTasks.Controls.Add(this.cmbPriorityNotMade);
            this.tabPageTasks.Controls.Add(this.materialButton1);
            this.tabPageTasks.Controls.Add(this.flowLayoutPanelInProgress);
            this.tabPageTasks.ImageKey = "icons8-задания-32.png";
            this.tabPageTasks.Location = new System.Drawing.Point(4, 39);
            this.tabPageTasks.Name = "tabPageTasks";
            this.tabPageTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTasks.Size = new System.Drawing.Size(841, 466);
            this.tabPageTasks.TabIndex = 0;
            this.tabPageTasks.Text = "Задачи";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(332, 415);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(157, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Загрузить новое";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // flowLayoutPanelInProgress
            // 
            this.flowLayoutPanelInProgress.AutoScroll = true;
            this.flowLayoutPanelInProgress.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelInProgress.Location = new System.Drawing.Point(0, 58);
            this.flowLayoutPanelInProgress.Name = "flowLayoutPanelInProgress";
            this.flowLayoutPanelInProgress.Size = new System.Drawing.Size(838, 348);
            this.flowLayoutPanelInProgress.TabIndex = 0;
            this.flowLayoutPanelInProgress.WrapContents = false;
            // 
            // tabPageCompletedTasks
            // 
            this.tabPageCompletedTasks.BackColor = System.Drawing.Color.White;
            this.tabPageCompletedTasks.Controls.Add(this.materialButton2);
            this.tabPageCompletedTasks.Controls.Add(this.DisableFilters);
            this.tabPageCompletedTasks.Controls.Add(this.ApplyFilters);
            this.tabPageCompletedTasks.Controls.Add(this.cmbStatusFilter);
            this.tabPageCompletedTasks.Controls.Add(this.cmbPriorityFilter);
            this.tabPageCompletedTasks.Controls.Add(this.flowLayoutPanelCompleted);
            this.tabPageCompletedTasks.ImageKey = "icons8-галочка-32.png";
            this.tabPageCompletedTasks.Location = new System.Drawing.Point(4, 39);
            this.tabPageCompletedTasks.Name = "tabPageCompletedTasks";
            this.tabPageCompletedTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompletedTasks.Size = new System.Drawing.Size(841, 466);
            this.tabPageCompletedTasks.TabIndex = 1;
            this.tabPageCompletedTasks.Text = "Выполнено";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(321, 424);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(157, 36);
            this.materialButton2.TabIndex = 5;
            this.materialButton2.Text = "Загрузить новое";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // DisableFilters
            // 
            this.DisableFilters.FlatAppearance.BorderSize = 0;
            this.DisableFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisableFilters.ImageKey = "closeIcon.png";
            this.DisableFilters.ImageList = this.imageList1;
            this.DisableFilters.Location = new System.Drawing.Point(609, 13);
            this.DisableFilters.Name = "DisableFilters";
            this.DisableFilters.Size = new System.Drawing.Size(32, 32);
            this.DisableFilters.TabIndex = 4;
            this.DisableFilters.UseVisualStyleBackColor = true;
            this.DisableFilters.Click += new System.EventHandler(this.DisableFilters_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "icons8-задания-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-галочка-32.png");
            this.imageList1.Images.SetKeyName(2, "closeIcon.png");
            this.imageList1.Images.SetKeyName(3, "icons8-восклицательный-знак-32.png");
            this.imageList1.Images.SetKeyName(4, "icons8-поиск-32.png");
            // 
            // ApplyFilters
            // 
            this.ApplyFilters.FlatAppearance.BorderSize = 0;
            this.ApplyFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyFilters.ImageKey = "icons8-поиск-32.png";
            this.ApplyFilters.ImageList = this.imageList1;
            this.ApplyFilters.Location = new System.Drawing.Point(543, 13);
            this.ApplyFilters.Name = "ApplyFilters";
            this.ApplyFilters.Size = new System.Drawing.Size(32, 32);
            this.ApplyFilters.TabIndex = 3;
            this.ApplyFilters.UseVisualStyleBackColor = true;
            this.ApplyFilters.Click += new System.EventHandler(this.ApplyFilters_Click);
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.AutoResize = false;
            this.cmbStatusFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbStatusFilter.Depth = 0;
            this.cmbStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStatusFilter.DropDownHeight = 174;
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.DropDownWidth = 121;
            this.cmbStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.IntegralHeight = false;
            this.cmbStatusFilter.ItemHeight = 43;
            this.cmbStatusFilter.Items.AddRange(new object[] {
            "Выполнено",
            "Провалено",
            "Отказано"});
            this.cmbStatusFilter.Location = new System.Drawing.Point(255, 6);
            this.cmbStatusFilter.MaxDropDownItems = 4;
            this.cmbStatusFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(245, 49);
            this.cmbStatusFilter.StartIndex = 0;
            this.cmbStatusFilter.TabIndex = 2;
            // 
            // cmbPriorityFilter
            // 
            this.cmbPriorityFilter.AutoResize = false;
            this.cmbPriorityFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPriorityFilter.Depth = 0;
            this.cmbPriorityFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPriorityFilter.DropDownHeight = 174;
            this.cmbPriorityFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriorityFilter.DropDownWidth = 121;
            this.cmbPriorityFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPriorityFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPriorityFilter.FormattingEnabled = true;
            this.cmbPriorityFilter.IntegralHeight = false;
            this.cmbPriorityFilter.ItemHeight = 43;
            this.cmbPriorityFilter.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbPriorityFilter.Location = new System.Drawing.Point(16, 6);
            this.cmbPriorityFilter.MaxDropDownItems = 4;
            this.cmbPriorityFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPriorityFilter.Name = "cmbPriorityFilter";
            this.cmbPriorityFilter.Size = new System.Drawing.Size(233, 49);
            this.cmbPriorityFilter.StartIndex = 0;
            this.cmbPriorityFilter.TabIndex = 1;
            // 
            // flowLayoutPanelCompleted
            // 
            this.flowLayoutPanelCompleted.AutoScroll = true;
            this.flowLayoutPanelCompleted.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCompleted.Location = new System.Drawing.Point(-1, 59);
            this.flowLayoutPanelCompleted.Name = "flowLayoutPanelCompleted";
            this.flowLayoutPanelCompleted.Size = new System.Drawing.Size(842, 358);
            this.flowLayoutPanelCompleted.TabIndex = 0;
            this.flowLayoutPanelCompleted.WrapContents = false;
            this.flowLayoutPanelCompleted.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelCompleted_Paint);
            // 
            // cmbPriorityNotMade
            // 
            this.cmbPriorityNotMade.AutoResize = false;
            this.cmbPriorityNotMade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPriorityNotMade.Depth = 0;
            this.cmbPriorityNotMade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPriorityNotMade.DropDownHeight = 174;
            this.cmbPriorityNotMade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriorityNotMade.DropDownWidth = 121;
            this.cmbPriorityNotMade.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPriorityNotMade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPriorityNotMade.FormattingEnabled = true;
            this.cmbPriorityNotMade.IntegralHeight = false;
            this.cmbPriorityNotMade.ItemHeight = 43;
            this.cmbPriorityNotMade.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbPriorityNotMade.Location = new System.Drawing.Point(19, 6);
            this.cmbPriorityNotMade.MaxDropDownItems = 4;
            this.cmbPriorityNotMade.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPriorityNotMade.Name = "cmbPriorityNotMade";
            this.cmbPriorityNotMade.Size = new System.Drawing.Size(228, 49);
            this.cmbPriorityNotMade.StartIndex = 0;
            this.cmbPriorityNotMade.TabIndex = 2;
            // 
            // ApplyFiltersInWork
            // 
            this.ApplyFiltersInWork.FlatAppearance.BorderSize = 0;
            this.ApplyFiltersInWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyFiltersInWork.ImageKey = "icons8-поиск-32.png";
            this.ApplyFiltersInWork.ImageList = this.imageList1;
            this.ApplyFiltersInWork.Location = new System.Drawing.Point(506, 15);
            this.ApplyFiltersInWork.Name = "ApplyFiltersInWork";
            this.ApplyFiltersInWork.Size = new System.Drawing.Size(32, 32);
            this.ApplyFiltersInWork.TabIndex = 4;
            this.ApplyFiltersInWork.UseVisualStyleBackColor = true;
            this.ApplyFiltersInWork.Click += new System.EventHandler(this.ApplyFiltersInWork_Click);
            // 
            // DisableFiltersNoMade
            // 
            this.DisableFiltersNoMade.FlatAppearance.BorderSize = 0;
            this.DisableFiltersNoMade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisableFiltersNoMade.ImageKey = "closeIcon.png";
            this.DisableFiltersNoMade.ImageList = this.imageList1;
            this.DisableFiltersNoMade.Location = new System.Drawing.Point(556, 15);
            this.DisableFiltersNoMade.Name = "DisableFiltersNoMade";
            this.DisableFiltersNoMade.Size = new System.Drawing.Size(32, 32);
            this.DisableFiltersNoMade.TabIndex = 5;
            this.DisableFiltersNoMade.UseVisualStyleBackColor = true;
            this.DisableFiltersNoMade.Click += new System.EventHandler(this.DisableFiltersNoMade_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(855, 576);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма работника";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageTasks.ResumeLayout(false);
            this.tabPageTasks.PerformLayout();
            this.tabPageCompletedTasks.ResumeLayout(false);
            this.tabPageCompletedTasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPageTasks;
        private TabPage tabPageCompletedTasks;
        private ImageList imageList1;
        private FlowLayoutPanel flowLayoutPanelInProgress;
        private FlowLayoutPanel flowLayoutPanelCompleted;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialComboBox cmbStatusFilter;
        private MaterialSkin.Controls.MaterialComboBox cmbPriorityFilter;
        private Button ApplyFilters;
        private Button DisableFilters;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private Button DisableFiltersNoMade;
        private Button ApplyFiltersInWork;
        private MaterialSkin.Controls.MaterialComboBox cmbPriorityNotMade;
    }
}