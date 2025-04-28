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
            this.flowLayoutPanelCompleted = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.materialButton1.Location = new System.Drawing.Point(351, 415);
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
            this.flowLayoutPanelInProgress.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelInProgress.Name = "flowLayoutPanelInProgress";
            this.flowLayoutPanelInProgress.Size = new System.Drawing.Size(838, 406);
            this.flowLayoutPanelInProgress.TabIndex = 0;
            this.flowLayoutPanelInProgress.WrapContents = false;
            // 
            // tabPageCompletedTasks
            // 
            this.tabPageCompletedTasks.BackColor = System.Drawing.Color.White;
            this.tabPageCompletedTasks.Controls.Add(this.flowLayoutPanelCompleted);
            this.tabPageCompletedTasks.ImageKey = "icons8-галочка-32.png";
            this.tabPageCompletedTasks.Location = new System.Drawing.Point(4, 39);
            this.tabPageCompletedTasks.Name = "tabPageCompletedTasks";
            this.tabPageCompletedTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompletedTasks.Size = new System.Drawing.Size(841, 466);
            this.tabPageCompletedTasks.TabIndex = 1;
            this.tabPageCompletedTasks.Text = "Выполнено";
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
    }
}