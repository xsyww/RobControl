namespace RobControl
{
    partial class FormMakeStation
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
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.stiBackVision = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtPrjName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtVisionPoint = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtControlPoint = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtMirrorHeight = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtRobHeight = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.btnSelectControlPoint = new DevComponents.DotNetBar.ButtonX();
            this.btnSelectBackVisionPoint = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // superTabControl1
            // 
            this.superTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superTabControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.ForeColor = System.Drawing.Color.Black;
            this.superTabControl1.Location = new System.Drawing.Point(12, 12);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(423, 332);
            this.superTabControl1.TabFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.TabIndex = 0;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stiBackVision,
            this.superTabItem1});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // stiBackVision
            // 
            this.stiBackVision.AttachedControl = this.superTabControlPanel1;
            this.stiBackVision.GlobalItem = false;
            this.stiBackVision.Name = "stiBackVision";
            this.stiBackVision.Text = "后视法";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.btnSelectBackVisionPoint);
            this.superTabControlPanel1.Controls.Add(this.btnSelectControlPoint);
            this.superTabControlPanel1.Controls.Add(this.txtVisionPoint);
            this.superTabControlPanel1.Controls.Add(this.labelX5);
            this.superTabControlPanel1.Controls.Add(this.txtControlPoint);
            this.superTabControlPanel1.Controls.Add(this.labelX6);
            this.superTabControlPanel1.Controls.Add(this.txtMirrorHeight);
            this.superTabControlPanel1.Controls.Add(this.labelX7);
            this.superTabControlPanel1.Controls.Add(this.txtRobHeight);
            this.superTabControlPanel1.Controls.Add(this.labelX8);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 36);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(423, 296);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.stiBackVision;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX1.Location = new System.Drawing.Point(281, 354);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 29);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "确定";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX2.Location = new System.Drawing.Point(362, 354);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 29);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 2;
            this.buttonX2.Text = "取消";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel2;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "后方交汇法";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.textBoxX3);
            this.superTabControlPanel2.Controls.Add(this.labelX4);
            this.superTabControlPanel2.Controls.Add(this.textBoxX2);
            this.superTabControlPanel2.Controls.Add(this.labelX3);
            this.superTabControlPanel2.Controls.Add(this.textBoxX1);
            this.superTabControlPanel2.Controls.Add(this.labelX2);
            this.superTabControlPanel2.Controls.Add(this.txtPrjName);
            this.superTabControlPanel2.Controls.Add(this.labelX1);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 36);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(423, 296);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem1;
            // 
            // txtPrjName
            // 
            this.txtPrjName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPrjName.Border.Class = "TextBoxBorder";
            this.txtPrjName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPrjName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrjName.ForeColor = System.Drawing.Color.Black;
            this.txtPrjName.Location = new System.Drawing.Point(21, 48);
            this.txtPrjName.Name = "txtPrjName";
            this.txtPrjName.Size = new System.Drawing.Size(362, 29);
            this.txtPrjName.TabIndex = 3;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(20, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(101, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "仪器高：";
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxX1.ForeColor = System.Drawing.Color.Black;
            this.textBoxX1.Location = new System.Drawing.Point(22, 112);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(362, 29);
            this.textBoxX1.TabIndex = 5;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(21, 83);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(101, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "棱镜高：";
            // 
            // textBoxX2
            // 
            this.textBoxX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxX2.ForeColor = System.Drawing.Color.Black;
            this.textBoxX2.Location = new System.Drawing.Point(23, 176);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(362, 29);
            this.textBoxX2.TabIndex = 7;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(22, 147);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(101, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "控制点：";
            // 
            // textBoxX3
            // 
            this.textBoxX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxX3.ForeColor = System.Drawing.Color.Black;
            this.textBoxX3.Location = new System.Drawing.Point(23, 240);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(362, 29);
            this.textBoxX3.TabIndex = 9;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(22, 211);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(101, 23);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "后视点：";
            // 
            // txtVisionPoint
            // 
            this.txtVisionPoint.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtVisionPoint.Border.Class = "TextBoxBorder";
            this.txtVisionPoint.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVisionPoint.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVisionPoint.ForeColor = System.Drawing.Color.Black;
            this.txtVisionPoint.Location = new System.Drawing.Point(23, 240);
            this.txtVisionPoint.Name = "txtVisionPoint";
            this.txtVisionPoint.Size = new System.Drawing.Size(316, 29);
            this.txtVisionPoint.TabIndex = 17;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(22, 211);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(101, 23);
            this.labelX5.TabIndex = 16;
            this.labelX5.Text = "后视点：";
            // 
            // txtControlPoint
            // 
            this.txtControlPoint.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtControlPoint.Border.Class = "TextBoxBorder";
            this.txtControlPoint.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtControlPoint.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtControlPoint.ForeColor = System.Drawing.Color.Black;
            this.txtControlPoint.Location = new System.Drawing.Point(23, 176);
            this.txtControlPoint.Name = "txtControlPoint";
            this.txtControlPoint.Size = new System.Drawing.Size(316, 29);
            this.txtControlPoint.TabIndex = 15;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(22, 147);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(101, 23);
            this.labelX6.TabIndex = 14;
            this.labelX6.Text = "控制点：";
            // 
            // txtMirrorHeight
            // 
            this.txtMirrorHeight.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMirrorHeight.Border.Class = "TextBoxBorder";
            this.txtMirrorHeight.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMirrorHeight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMirrorHeight.ForeColor = System.Drawing.Color.Black;
            this.txtMirrorHeight.Location = new System.Drawing.Point(22, 112);
            this.txtMirrorHeight.Name = "txtMirrorHeight";
            this.txtMirrorHeight.Size = new System.Drawing.Size(316, 29);
            this.txtMirrorHeight.TabIndex = 13;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.Location = new System.Drawing.Point(21, 83);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(101, 23);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "棱镜高：";
            // 
            // txtRobHeight
            // 
            this.txtRobHeight.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtRobHeight.Border.Class = "TextBoxBorder";
            this.txtRobHeight.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRobHeight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobHeight.ForeColor = System.Drawing.Color.Black;
            this.txtRobHeight.Location = new System.Drawing.Point(21, 48);
            this.txtRobHeight.Name = "txtRobHeight";
            this.txtRobHeight.Size = new System.Drawing.Size(316, 29);
            this.txtRobHeight.TabIndex = 11;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX8.Location = new System.Drawing.Point(20, 19);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(101, 23);
            this.labelX8.TabIndex = 10;
            this.labelX8.Text = "仪器高：";
            // 
            // btnSelectControlPoint
            // 
            this.btnSelectControlPoint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSelectControlPoint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSelectControlPoint.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectControlPoint.Location = new System.Drawing.Point(345, 176);
            this.btnSelectControlPoint.Name = "btnSelectControlPoint";
            this.btnSelectControlPoint.Size = new System.Drawing.Size(58, 29);
            this.btnSelectControlPoint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSelectControlPoint.TabIndex = 18;
            this.btnSelectControlPoint.Text = "选择";
            this.btnSelectControlPoint.Click += new System.EventHandler(this.btnSelectControlPoint_Click);
            // 
            // btnSelectBackVisionPoint
            // 
            this.btnSelectBackVisionPoint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSelectBackVisionPoint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSelectBackVisionPoint.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectBackVisionPoint.Location = new System.Drawing.Point(345, 240);
            this.btnSelectBackVisionPoint.Name = "btnSelectBackVisionPoint";
            this.btnSelectBackVisionPoint.Size = new System.Drawing.Size(58, 29);
            this.btnSelectBackVisionPoint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSelectBackVisionPoint.TabIndex = 19;
            this.btnSelectBackVisionPoint.Text = "选择";
            this.btnSelectBackVisionPoint.Click += new System.EventHandler(this.btnSelectBackVisionPoint_Click);
            // 
            // FormMakeStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 395);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.superTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMakeStation";
            this.Text = "设站";
            this.Load += new System.EventHandler(this.FormMakeStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem stiBackVision;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.ButtonX btnSelectBackVisionPoint;
        private DevComponents.DotNetBar.ButtonX btnSelectControlPoint;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVisionPoint;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtControlPoint;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMirrorHeight;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRobHeight;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrjName;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}