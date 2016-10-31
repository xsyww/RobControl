namespace RobControl
{
    partial class FormMetro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMetro));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelTitle = new DevComponents.DotNetBar.LabelItem();
            this.btnInfoSetting = new DevComponents.DotNetBar.ButtonItem();
            this.btnMin = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnShowAll = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelCommand = new DevComponents.DotNetBar.ButtonX();
            this.btnPan = new DevComponents.DotNetBar.ButtonX();
            this.btnRotate = new DevComponents.DotNetBar.ButtonX();
            this.btnZoomIn = new DevComponents.DotNetBar.ButtonX();
            this.btnZoomOut = new DevComponents.DotNetBar.ButtonX();
            this.btnPer = new DevComponents.DotNetBar.ButtonX();
            this.btnWalkThrough = new DevComponents.DotNetBar.ButtonX();
            this.vDraw = new VectorDraw.Professional.Control.VectorDrawBaseControl();
            this.gridPoints = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel2 = new DevComponents.DotNetBar.PanelEx();
            this.txtWz = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtWy = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtWx = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCz = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCy = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCx = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMz = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMy = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMx = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.itemPanel3 = new DevComponents.DotNetBar.ItemPanel();
            this.barOper = new DevComponents.DotNetBar.Bar();
            this.btnSetupOriginPoint = new DevComponents.DotNetBar.ButtonItem();
            this.btnPre = new DevComponents.DotNetBar.ButtonItem();
            this.btnNext = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.btnShowPoint = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnStake = new DevComponents.DotNetBar.ButtonItem();
            this.buttonMeasure = new DevComponents.DotNetBar.ButtonItem();
            this.barMain = new DevComponents.DotNetBar.Bar();
            this.btnOpenProject = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreateData = new DevComponents.DotNetBar.ButtonItem();
            this.btnLayout = new DevComponents.DotNetBar.ButtonItem();
            this.btnMeasure = new DevComponents.DotNetBar.ButtonItem();
            this.btnReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnProjectSetting = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barOper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelTitle,
            this.btnInfoSetting,
            this.btnMin,
            this.btnClose});
            this.bar1.Location = new System.Drawing.Point(0, 2);
            this.bar1.Margin = new System.Windows.Forms.Padding(4);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(1546, 70);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 2;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Symbol = "";
            this.labelTitle.SymbolSize = 30F;
            this.labelTitle.Text = "BIM放样控制软件";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // btnInfoSetting
            // 
            this.btnInfoSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnInfoSetting.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btnInfoSetting.Name = "btnInfoSetting";
            this.btnInfoSetting.Symbol = "";
            this.btnInfoSetting.SymbolSize = 30F;
            this.btnInfoSetting.Text = "buttonItem1";
            this.btnInfoSetting.Click += new System.EventHandler(this.btnInfoSetting_Click);
            // 
            // btnMin
            // 
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnMin.Name = "btnMin";
            this.btnMin.Symbol = "";
            this.btnMin.SymbolSize = 30F;
            this.btnMin.Text = "buttonItem2";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnClose.Name = "btnClose";
            this.btnClose.Symbol = "";
            this.btnClose.SymbolSize = 30F;
            this.btnClose.Text = "buttonItem3";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Location = new System.Drawing.Point(0, 188);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.splitContainer1.Panel1.Controls.Add(this.btnShowAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnPan);
            this.splitContainer1.Panel1.Controls.Add(this.btnRotate);
            this.splitContainer1.Panel1.Controls.Add(this.btnZoomIn);
            this.splitContainer1.Panel1.Controls.Add(this.btnZoomOut);
            this.splitContainer1.Panel1.Controls.Add(this.btnPer);
            this.splitContainer1.Panel1.Controls.Add(this.btnWalkThrough);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelCommand);
            this.splitContainer1.Panel1.Controls.Add(this.vDraw);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.splitContainer1.Panel2.Controls.Add(this.gridPoints);
            this.splitContainer1.Panel2.Controls.Add(this.barOper);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Size = new System.Drawing.Size(1546, 696);
            this.splitContainer1.SplitterDistance = 822;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnShowAll
            // 
            this.btnShowAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowAll.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnShowAll.Location = new System.Drawing.Point(8, 613);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(70, 80);
            this.btnShowAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowAll.Symbol = "";
            this.btnShowAll.SymbolSize = 25F;
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.TabStop = false;
            this.btnShowAll.Text = "全显";
            this.btnShowAll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnCancelCommand
            // 
            this.btnCancelCommand.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelCommand.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelCommand.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCancelCommand.Location = new System.Drawing.Point(8, 8);
            this.btnCancelCommand.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelCommand.Name = "btnCancelCommand";
            this.btnCancelCommand.Size = new System.Drawing.Size(100, 81);
            this.btnCancelCommand.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelCommand.Symbol = "";
            this.btnCancelCommand.SymbolSize = 25F;
            this.btnCancelCommand.TabIndex = 3;
            this.btnCancelCommand.Text = "取消命令";
            this.btnCancelCommand.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnCancelCommand.Click += new System.EventHandler(this.btnCancelCommand_Click);
            // 
            // btnPan
            // 
            this.btnPan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPan.Location = new System.Drawing.Point(84, 613);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(70, 80);
            this.btnPan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPan.Symbol = "";
            this.btnPan.SymbolSize = 25F;
            this.btnPan.TabIndex = 5;
            this.btnPan.TabStop = false;
            this.btnPan.Text = "平移";
            this.btnPan.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRotate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRotate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRotate.Location = new System.Drawing.Point(160, 613);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(70, 80);
            this.btnRotate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRotate.Symbol = "";
            this.btnRotate.SymbolSize = 25F;
            this.btnRotate.TabIndex = 6;
            this.btnRotate.TabStop = false;
            this.btnRotate.Text = "旋转";
            this.btnRotate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnZoomIn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnZoomIn.Location = new System.Drawing.Point(236, 613);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(70, 80);
            this.btnZoomIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnZoomIn.Symbol = "";
            this.btnZoomIn.SymbolSize = 25F;
            this.btnZoomIn.TabIndex = 7;
            this.btnZoomIn.TabStop = false;
            this.btnZoomIn.Text = "放大";
            this.btnZoomIn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomOut.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnZoomOut.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnZoomOut.Location = new System.Drawing.Point(312, 613);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(70, 80);
            this.btnZoomOut.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnZoomOut.Symbol = "";
            this.btnZoomOut.SymbolSize = 25F;
            this.btnZoomOut.TabIndex = 8;
            this.btnZoomOut.TabStop = false;
            this.btnZoomOut.Text = "缩小";
            this.btnZoomOut.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnPer
            // 
            this.btnPer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPer.AutoCheckOnClick = true;
            this.btnPer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPer.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPer.Location = new System.Drawing.Point(388, 613);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(70, 80);
            this.btnPer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPer.Symbol = "";
            this.btnPer.SymbolSize = 25F;
            this.btnPer.TabIndex = 9;
            this.btnPer.TabStop = false;
            this.btnPer.Text = "透视";
            this.btnPer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // btnWalkThrough
            // 
            this.btnWalkThrough.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnWalkThrough.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWalkThrough.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWalkThrough.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnWalkThrough.Location = new System.Drawing.Point(464, 613);
            this.btnWalkThrough.Name = "btnWalkThrough";
            this.btnWalkThrough.Size = new System.Drawing.Size(70, 80);
            this.btnWalkThrough.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnWalkThrough.Symbol = "";
            this.btnWalkThrough.SymbolSize = 25F;
            this.btnWalkThrough.TabIndex = 10;
            this.btnWalkThrough.TabStop = false;
            this.btnWalkThrough.Text = "漫游";
            this.btnWalkThrough.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnWalkThrough.Click += new System.EventHandler(this.btnWalkThrough_Click);
            // 
            // vDraw
            // 
            this.vDraw.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.vDraw.AllowDrop = true;
            this.vDraw.BackColor = System.Drawing.Color.White;
            this.vDraw.Cursor = System.Windows.Forms.Cursors.Default;
            this.vDraw.DisableVdrawDxf = false;
            this.vDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vDraw.EnableAutoGripOn = true;
            this.vDraw.ForeColor = System.Drawing.Color.Black;
            this.vDraw.Location = new System.Drawing.Point(0, 0);
            this.vDraw.Margin = new System.Windows.Forms.Padding(4);
            this.vDraw.Name = "vDraw";
            this.vDraw.Size = new System.Drawing.Size(822, 696);
            this.vDraw.TabIndex = 0;
            this.vDraw.MouseEnter += new System.EventHandler(this.vDraw_MouseEnter);
            // 
            // gridPoints
            // 
            this.gridPoints.AllowEditing = false;
            this.gridPoints.BackColor = System.Drawing.Color.White;
            this.gridPoints.ColumnInfo = resources.GetString("gridPoints.ColumnInfo");
            this.gridPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPoints.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridPoints.ForeColor = System.Drawing.Color.Black;
            this.gridPoints.Location = new System.Drawing.Point(0, 244);
            this.gridPoints.Margin = new System.Windows.Forms.Padding(4);
            this.gridPoints.Name = "gridPoints";
            this.gridPoints.Rows.DefaultSize = 34;
            this.gridPoints.Rows.MinSize = 25;
            this.gridPoints.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridPoints.Size = new System.Drawing.Size(718, 452);
            this.gridPoints.StyleInfo = resources.GetString("gridPoints.StyleInfo");
            this.gridPoints.TabIndex = 4;
            this.gridPoints.SelChange += new System.EventHandler(this.gridPoints_SelChange);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtWz);
            this.panel2.Controls.Add(this.txtWy);
            this.panel2.Controls.Add(this.txtWx);
            this.panel2.Controls.Add(this.txtCz);
            this.panel2.Controls.Add(this.txtCy);
            this.panel2.Controls.Add(this.txtCx);
            this.panel2.Controls.Add(this.txtMz);
            this.panel2.Controls.Add(this.txtMy);
            this.panel2.Controls.Add(this.txtMx);
            this.panel2.Controls.Add(this.labelX6);
            this.panel2.Controls.Add(this.labelX5);
            this.panel2.Controls.Add(this.labelX4);
            this.panel2.Controls.Add(this.labelX3);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.MinimumSize = new System.Drawing.Size(520, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 174);
            this.panel2.TabIndex = 1;
            // 
            // txtWz
            // 
            this.txtWz.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtWz.Border.Class = "TextBoxBorder";
            this.txtWz.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtWz.ForeColor = System.Drawing.Color.Black;
            this.txtWz.Location = new System.Drawing.Point(375, 126);
            this.txtWz.Margin = new System.Windows.Forms.Padding(4);
            this.txtWz.Name = "txtWz";
            this.txtWz.Size = new System.Drawing.Size(130, 39);
            this.txtWz.TabIndex = 14;
            // 
            // txtWy
            // 
            this.txtWy.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtWy.Border.Class = "TextBoxBorder";
            this.txtWy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtWy.ForeColor = System.Drawing.Color.Black;
            this.txtWy.Location = new System.Drawing.Point(236, 126);
            this.txtWy.Margin = new System.Windows.Forms.Padding(4);
            this.txtWy.Name = "txtWy";
            this.txtWy.Size = new System.Drawing.Size(130, 39);
            this.txtWy.TabIndex = 13;
            // 
            // txtWx
            // 
            this.txtWx.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtWx.Border.Class = "TextBoxBorder";
            this.txtWx.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtWx.ForeColor = System.Drawing.Color.Black;
            this.txtWx.Location = new System.Drawing.Point(96, 126);
            this.txtWx.Margin = new System.Windows.Forms.Padding(4);
            this.txtWx.Name = "txtWx";
            this.txtWx.Size = new System.Drawing.Size(130, 39);
            this.txtWx.TabIndex = 12;
            // 
            // txtCz
            // 
            this.txtCz.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCz.Border.Class = "TextBoxBorder";
            this.txtCz.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCz.ForeColor = System.Drawing.Color.Black;
            this.txtCz.Location = new System.Drawing.Point(375, 86);
            this.txtCz.Margin = new System.Windows.Forms.Padding(4);
            this.txtCz.Name = "txtCz";
            this.txtCz.Size = new System.Drawing.Size(130, 39);
            this.txtCz.TabIndex = 11;
            // 
            // txtCy
            // 
            this.txtCy.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCy.Border.Class = "TextBoxBorder";
            this.txtCy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCy.ForeColor = System.Drawing.Color.Black;
            this.txtCy.Location = new System.Drawing.Point(236, 86);
            this.txtCy.Margin = new System.Windows.Forms.Padding(4);
            this.txtCy.Name = "txtCy";
            this.txtCy.Size = new System.Drawing.Size(130, 39);
            this.txtCy.TabIndex = 10;
            // 
            // txtCx
            // 
            this.txtCx.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCx.Border.Class = "TextBoxBorder";
            this.txtCx.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCx.ForeColor = System.Drawing.Color.Black;
            this.txtCx.Location = new System.Drawing.Point(96, 86);
            this.txtCx.Margin = new System.Windows.Forms.Padding(4);
            this.txtCx.Name = "txtCx";
            this.txtCx.Size = new System.Drawing.Size(130, 39);
            this.txtCx.TabIndex = 9;
            // 
            // txtMz
            // 
            this.txtMz.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMz.Border.Class = "TextBoxBorder";
            this.txtMz.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMz.ForeColor = System.Drawing.Color.Black;
            this.txtMz.Location = new System.Drawing.Point(375, 45);
            this.txtMz.Margin = new System.Windows.Forms.Padding(4);
            this.txtMz.Name = "txtMz";
            this.txtMz.Size = new System.Drawing.Size(130, 39);
            this.txtMz.TabIndex = 8;
            // 
            // txtMy
            // 
            this.txtMy.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMy.Border.Class = "TextBoxBorder";
            this.txtMy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMy.ForeColor = System.Drawing.Color.Black;
            this.txtMy.Location = new System.Drawing.Point(236, 45);
            this.txtMy.Margin = new System.Windows.Forms.Padding(4);
            this.txtMy.Name = "txtMy";
            this.txtMy.Size = new System.Drawing.Size(130, 39);
            this.txtMy.TabIndex = 7;
            // 
            // txtMx
            // 
            this.txtMx.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMx.Border.Class = "TextBoxBorder";
            this.txtMx.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMx.ForeColor = System.Drawing.Color.Black;
            this.txtMx.Location = new System.Drawing.Point(96, 45);
            this.txtMx.Margin = new System.Windows.Forms.Padding(4);
            this.txtMx.Name = "txtMx";
            this.txtMx.Size = new System.Drawing.Size(130, 39);
            this.txtMx.TabIndex = 6;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(422, 9);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(34, 34);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "Z";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(273, 9);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(34, 34);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Y";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(144, 9);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(34, 34);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "X";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(4, 126);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(112, 34);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "误差值：";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(4, 84);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(112, 34);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "测量点：";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(4, 42);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(112, 34);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "模型点：";
            // 
            // itemPanel3
            // 
            this.itemPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.itemPanel3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.itemPanel3.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.itemPanel3.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel3.ContainerControlProcessDialogKey = true;
            this.itemPanel3.ForeColor = System.Drawing.Color.Black;
            this.itemPanel3.Location = new System.Drawing.Point(415, 601);
            this.itemPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.itemPanel3.Name = "itemPanel3";
            this.itemPanel3.Size = new System.Drawing.Size(513, 87);
            this.itemPanel3.TabIndex = 2;
            this.itemPanel3.Text = "itemPanel3";
            // 
            // barOper
            // 
            this.barOper.AntiAlias = true;
            this.barOper.Dock = System.Windows.Forms.DockStyle.Top;
            this.barOper.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.barOper.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSetupOriginPoint,
            this.btnPre,
            this.btnNext,
            this.buttonItem4,
            this.btnShowPoint,
            this.buttonItem1,
            this.btnStake,
            this.buttonMeasure});
            this.barOper.Location = new System.Drawing.Point(0, 174);
            this.barOper.Margin = new System.Windows.Forms.Padding(4);
            this.barOper.Name = "barOper";
            this.barOper.RoundCorners = false;
            this.barOper.Size = new System.Drawing.Size(718, 70);
            this.barOper.Stretch = true;
            this.barOper.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barOper.TabIndex = 6;
            this.barOper.TabStop = false;
            this.barOper.Text = "bar2";
            // 
            // btnSetupOriginPoint
            // 
            this.btnSetupOriginPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnSetupOriginPoint.Name = "btnSetupOriginPoint";
            this.btnSetupOriginPoint.Symbol = "";
            this.btnSetupOriginPoint.SymbolSize = 30F;
            this.btnSetupOriginPoint.Text = "buttonItem4";
            this.btnSetupOriginPoint.Click += new System.EventHandler(this.btnSetupOriginPoint_Click);
            // 
            // btnPre
            // 
            this.btnPre.BeginGroup = true;
            this.btnPre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnPre.Name = "btnPre";
            this.btnPre.Symbol = "";
            this.btnPre.SymbolSize = 30F;
            this.btnPre.Text = "buttonItem5";
            this.btnPre.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // btnNext
            // 
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnNext.Name = "btnNext";
            this.btnNext.Symbol = "";
            this.btnNext.SymbolSize = 30F;
            this.btnNext.Text = "buttonItem6";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // buttonItem4
            // 
            this.buttonItem4.BeginGroup = true;
            this.buttonItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Symbol = "";
            this.buttonItem4.SymbolSize = 30F;
            this.buttonItem4.Text = "buttonItem4";
            // 
            // btnShowPoint
            // 
            this.btnShowPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnShowPoint.Name = "btnShowPoint";
            this.btnShowPoint.Symbol = "";
            this.btnShowPoint.SymbolSize = 30F;
            this.btnShowPoint.Text = "buttonItem4";
            this.btnShowPoint.Click += new System.EventHandler(this.btnShowPoint_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.BeginGroup = true;
            this.buttonItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Symbol = "";
            this.buttonItem1.SymbolSize = 30F;
            this.buttonItem1.Text = "buttonItem4";
            // 
            // btnStake
            // 
            this.btnStake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnStake.Name = "btnStake";
            this.btnStake.Symbol = "";
            this.btnStake.SymbolSize = 30F;
            this.btnStake.Text = "buttonItem4";
            // 
            // buttonMeasure
            // 
            this.buttonMeasure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.buttonMeasure.Name = "buttonMeasure";
            this.buttonMeasure.Symbol = "";
            this.buttonMeasure.SymbolSize = 30F;
            this.buttonMeasure.Text = "buttonItem4";
            // 
            // barMain
            // 
            this.barMain.AntiAlias = true;
            this.barMain.BackColor = System.Drawing.Color.White;
            this.barMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.barMain.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.barMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnOpenProject,
            this.btnCreateData,
            this.btnLayout,
            this.btnMeasure,
            this.btnReport,
            this.btnProjectSetting});
            this.barMain.Location = new System.Drawing.Point(0, 72);
            this.barMain.Margin = new System.Windows.Forms.Padding(4);
            this.barMain.Name = "barMain";
            this.barMain.RoundCorners = false;
            this.barMain.Size = new System.Drawing.Size(1546, 116);
            this.barMain.Stretch = true;
            this.barMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barMain.TabIndex = 5;
            this.barMain.TabStop = false;
            this.barMain.Text = "bar3";
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnOpenProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnOpenProject.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Symbol = "";
            this.btnOpenProject.SymbolSize = 40F;
            this.btnOpenProject.Text = "项目";
            this.btnOpenProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnCreateData
            // 
            this.btnCreateData.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnCreateData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnCreateData.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Symbol = "";
            this.btnCreateData.SymbolSize = 40F;
            this.btnCreateData.Text = "创建数据";
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // btnLayout
            // 
            this.btnLayout.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnLayout.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLayout.Name = "btnLayout";
            this.btnLayout.Symbol = "";
            this.btnLayout.SymbolSize = 40F;
            this.btnLayout.Text = "放样";
            this.btnLayout.Click += new System.EventHandler(this.btnLayout_Click);
            // 
            // btnMeasure
            // 
            this.btnMeasure.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnMeasure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnMeasure.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Symbol = "";
            this.btnMeasure.SymbolSize = 40F;
            this.btnMeasure.Text = "测量";
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // btnReport
            // 
            this.btnReport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReport.Name = "btnReport";
            this.btnReport.Symbol = "";
            this.btnReport.SymbolSize = 40F;
            this.btnReport.Text = "报告";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnProjectSetting
            // 
            this.btnProjectSetting.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnProjectSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(150)))));
            this.btnProjectSetting.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnProjectSetting.Name = "btnProjectSetting";
            this.btnProjectSetting.Symbol = "";
            this.btnProjectSetting.SymbolSize = 40F;
            this.btnProjectSetting.Text = "设置";
            this.btnProjectSetting.Click += new System.EventHandler(this.btnProjectSetting_Click_1);
            // 
            // FormMetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 886);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barMain);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1321, 886);
            this.Name = "FormMetro";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.Text = "BIM放样控制软件";
            this.Load += new System.EventHandler(this.FormMetro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barOper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.LabelItem labelTitle;
        private DevComponents.DotNetBar.ButtonItem btnInfoSetting;
        private DevComponents.DotNetBar.ButtonItem btnMin;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private VectorDraw.Professional.Control.VectorDrawBaseControl vDraw;
        private DevComponents.DotNetBar.PanelEx panel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWz;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWy;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWx;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCz;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCy;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCx;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMz;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMy;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMx;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private C1.Win.C1FlexGrid.C1FlexGrid gridPoints;
        private DevComponents.DotNetBar.ItemPanel itemPanel3;
        private DevComponents.DotNetBar.ButtonX btnShowAll;
        private DevComponents.DotNetBar.ButtonX btnPan;
        private DevComponents.DotNetBar.ButtonX btnRotate;
        private DevComponents.DotNetBar.ButtonX btnPer;
        private DevComponents.DotNetBar.ButtonX btnWalkThrough;
        private DevComponents.DotNetBar.ButtonX btnZoomIn;
        private DevComponents.DotNetBar.ButtonX btnZoomOut;
        private DevComponents.DotNetBar.ButtonX btnCancelCommand;
        private DevComponents.DotNetBar.Bar barOper;
        private DevComponents.DotNetBar.ButtonItem btnSetupOriginPoint;
        private DevComponents.DotNetBar.ButtonItem btnPre;
        private DevComponents.DotNetBar.ButtonItem btnNext;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem btnShowPoint;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnStake;
        private DevComponents.DotNetBar.ButtonItem buttonMeasure;
        private DevComponents.DotNetBar.Bar barMain;
        private DevComponents.DotNetBar.ButtonItem btnOpenProject;
        private DevComponents.DotNetBar.ButtonItem btnCreateData;
        private DevComponents.DotNetBar.ButtonItem btnLayout;
        private DevComponents.DotNetBar.ButtonItem btnMeasure;
        private DevComponents.DotNetBar.ButtonItem btnReport;
        private DevComponents.DotNetBar.ButtonItem btnProjectSetting;
    }
}