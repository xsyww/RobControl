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
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelTitle = new DevComponents.DotNetBar.LabelItem();
            this.btnInfoSetting = new DevComponents.DotNetBar.ButtonItem();
            this.btnMin = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCancelCommand = new DevComponents.DotNetBar.ButtonX();
            this.itemPanel3 = new DevComponents.DotNetBar.ItemPanel();
            this.btnShowAll = new DevComponents.DotNetBar.ButtonItem();
            this.btnPan = new DevComponents.DotNetBar.ButtonItem();
            this.btnRotate = new DevComponents.DotNetBar.ButtonItem();
            this.btnZoomIn = new DevComponents.DotNetBar.ButtonItem();
            this.btnZoomOut = new DevComponents.DotNetBar.ButtonItem();
            this.btnPer = new DevComponents.DotNetBar.ButtonItem();
            this.btnWalkThrough = new DevComponents.DotNetBar.ButtonItem();
            this.vDraw = new VectorDraw.Professional.Control.VectorDrawBaseControl();
            this.gridPoints = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.itemPanel2 = new DevComponents.DotNetBar.ItemPanel();
            this.btnPre = new DevComponents.DotNetBar.ButtonItem();
            this.btnNext = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.btnSetupOriginPoint = new DevComponents.DotNetBar.ButtonItem();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.btnOpenProject = new DevComponents.DotNetBar.ButtonItem();
            this.btnReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnProjectSetting = new DevComponents.DotNetBar.ButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addPoint = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1});
            this.metroStatusBar1.Location = new System.Drawing.Point(1, 586);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(886, 22);
            this.metroStatusBar1.TabIndex = 0;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "READY...";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
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
            this.bar1.Location = new System.Drawing.Point(1, 1);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(886, 31);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 2;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Symbol = "";
            this.labelTitle.Text = "BIM放样控制软件";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // btnInfoSetting
            // 
            this.btnInfoSetting.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btnInfoSetting.Name = "btnInfoSetting";
            this.btnInfoSetting.Symbol = "";
            this.btnInfoSetting.Text = "buttonItem1";
            this.btnInfoSetting.Click += new System.EventHandler(this.btnInfoSetting_Click);
            // 
            // btnMin
            // 
            this.btnMin.Name = "btnMin";
            this.btnMin.Symbol = "";
            this.btnMin.Text = "buttonItem2";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Symbol = "";
            this.btnClose.Text = "buttonItem3";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Location = new System.Drawing.Point(1, 91);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelCommand);
            this.splitContainer1.Panel1.Controls.Add(this.itemPanel3);
            this.splitContainer1.Panel1.Controls.Add(this.vDraw);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.splitContainer1.Panel2.Controls.Add(this.gridPoints);
            this.splitContainer1.Panel2.Controls.Add(this.itemPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Size = new System.Drawing.Size(886, 495);
            this.splitContainer1.SplitterDistance = 611;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnCancelCommand
            // 
            this.btnCancelCommand.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelCommand.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelCommand.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCancelCommand.Location = new System.Drawing.Point(5, 5);
            this.btnCancelCommand.Name = "btnCancelCommand";
            this.btnCancelCommand.Size = new System.Drawing.Size(67, 54);
            this.btnCancelCommand.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelCommand.Symbol = "";
            this.btnCancelCommand.SymbolSize = 25F;
            this.btnCancelCommand.TabIndex = 3;
            this.btnCancelCommand.Text = "取消命令";
            this.btnCancelCommand.Click += new System.EventHandler(this.btnCancelCommand_Click);
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
            this.itemPanel3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnShowAll,
            this.btnPan,
            this.btnRotate,
            this.btnZoomIn,
            this.btnZoomOut,
            this.btnPer,
            this.btnWalkThrough});
            this.itemPanel3.Location = new System.Drawing.Point(164, 434);
            this.itemPanel3.Name = "itemPanel3";
            this.itemPanel3.Size = new System.Drawing.Size(342, 58);
            this.itemPanel3.TabIndex = 2;
            this.itemPanel3.Text = "itemPanel3";
            // 
            // btnShowAll
            // 
            this.btnShowAll.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnShowAll.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Symbol = "";
            this.btnShowAll.SymbolSize = 25F;
            this.btnShowAll.Text = "全显";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnPan
            // 
            this.btnPan.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnPan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPan.Name = "btnPan";
            this.btnPan.Symbol = "";
            this.btnPan.SymbolSize = 25F;
            this.btnPan.Text = "平移";
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnRotate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Symbol = "";
            this.btnRotate.SymbolSize = 25F;
            this.btnRotate.Text = "旋转";
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnZoomIn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Symbol = "";
            this.btnZoomIn.SymbolSize = 25F;
            this.btnZoomIn.Text = "放大";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnZoomOut.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Symbol = "";
            this.btnZoomOut.SymbolSize = 25F;
            this.btnZoomOut.Text = "缩小";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnPer
            // 
            this.btnPer.AutoCheckOnClick = true;
            this.btnPer.BeginGroup = true;
            this.btnPer.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnPer.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPer.Name = "btnPer";
            this.btnPer.Symbol = "";
            this.btnPer.SymbolSize = 25F;
            this.btnPer.Text = "透视";
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // btnWalkThrough
            // 
            this.btnWalkThrough.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnWalkThrough.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnWalkThrough.Name = "btnWalkThrough";
            this.btnWalkThrough.Symbol = "";
            this.btnWalkThrough.SymbolSize = 25F;
            this.btnWalkThrough.Text = "漫游";
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
            this.vDraw.Name = "vDraw";
            this.vDraw.Size = new System.Drawing.Size(611, 495);
            this.vDraw.TabIndex = 0;
            // 
            // gridPoints
            // 
            this.gridPoints.AllowEditing = false;
            this.gridPoints.BackColor = System.Drawing.Color.White;
            this.gridPoints.ColumnInfo = resources.GetString("gridPoints.ColumnInfo");
            this.gridPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPoints.ForeColor = System.Drawing.Color.Black;
            this.gridPoints.Location = new System.Drawing.Point(0, 160);
            this.gridPoints.Name = "gridPoints";
            this.gridPoints.Rows.DefaultSize = 20;
            this.gridPoints.Rows.MinSize = 25;
            this.gridPoints.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.gridPoints.Size = new System.Drawing.Size(271, 335);
            this.gridPoints.StyleInfo = resources.GetString("gridPoints.StyleInfo");
            this.gridPoints.TabIndex = 4;
            this.gridPoints.SelChange += new System.EventHandler(this.gridPoints_SelChange);
            // 
            // itemPanel2
            // 
            this.itemPanel2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.itemPanel2.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel2.ContainerControlProcessDialogKey = true;
            this.itemPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPanel2.ForeColor = System.Drawing.Color.Black;
            this.itemPanel2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPre,
            this.btnNext,
            this.buttonItem4,
            this.btnSetupOriginPoint,
            this.addPoint});
            this.itemPanel2.Location = new System.Drawing.Point(0, 116);
            this.itemPanel2.Name = "itemPanel2";
            this.itemPanel2.Size = new System.Drawing.Size(271, 44);
            this.itemPanel2.TabIndex = 5;
            this.itemPanel2.Text = "itemPanel2";
            // 
            // btnPre
            // 
            this.btnPre.Name = "btnPre";
            this.btnPre.Symbol = "";
            this.btnPre.SymbolSize = 30F;
            this.btnPre.Text = "buttonItem5";
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Name = "btnNext";
            this.btnNext.Symbol = "";
            this.btnNext.SymbolSize = 30F;
            this.btnNext.Text = "buttonItem6";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // buttonItem4
            // 
            this.buttonItem4.BeginGroup = true;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Symbol = "";
            this.buttonItem4.SymbolSize = 30F;
            this.buttonItem4.Text = "buttonItem4";
            // 
            // btnSetupOriginPoint
            // 
            this.btnSetupOriginPoint.Name = "btnSetupOriginPoint";
            this.btnSetupOriginPoint.Symbol = "";
            this.btnSetupOriginPoint.SymbolSize = 30F;
            this.btnSetupOriginPoint.Text = "buttonItem4";
            this.btnSetupOriginPoint.Click += new System.EventHandler(this.btnSetupOriginPoint_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
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
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 116);
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
            this.txtWz.Location = new System.Drawing.Point(250, 84);
            this.txtWz.Name = "txtWz";
            this.txtWz.Size = new System.Drawing.Size(87, 21);
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
            this.txtWy.Location = new System.Drawing.Point(157, 84);
            this.txtWy.Name = "txtWy";
            this.txtWy.Size = new System.Drawing.Size(87, 21);
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
            this.txtWx.Location = new System.Drawing.Point(64, 84);
            this.txtWx.Name = "txtWx";
            this.txtWx.Size = new System.Drawing.Size(87, 21);
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
            this.txtCz.Location = new System.Drawing.Point(250, 57);
            this.txtCz.Name = "txtCz";
            this.txtCz.Size = new System.Drawing.Size(87, 21);
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
            this.txtCy.Location = new System.Drawing.Point(157, 57);
            this.txtCy.Name = "txtCy";
            this.txtCy.Size = new System.Drawing.Size(87, 21);
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
            this.txtCx.Location = new System.Drawing.Point(64, 57);
            this.txtCx.Name = "txtCx";
            this.txtCx.Size = new System.Drawing.Size(87, 21);
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
            this.txtMz.Location = new System.Drawing.Point(250, 30);
            this.txtMz.Name = "txtMz";
            this.txtMz.Size = new System.Drawing.Size(87, 21);
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
            this.txtMy.Location = new System.Drawing.Point(157, 30);
            this.txtMy.Name = "txtMy";
            this.txtMy.Size = new System.Drawing.Size(87, 21);
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
            this.txtMx.Location = new System.Drawing.Point(64, 30);
            this.txtMx.Name = "txtMx";
            this.txtMx.Size = new System.Drawing.Size(87, 21);
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
            this.labelX6.Location = new System.Drawing.Point(281, 6);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(23, 23);
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
            this.labelX5.Location = new System.Drawing.Point(182, 6);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(23, 23);
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
            this.labelX4.Location = new System.Drawing.Point(96, 6);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(23, 23);
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
            this.labelX3.Location = new System.Drawing.Point(3, 84);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
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
            this.labelX2.Location = new System.Drawing.Point(3, 56);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
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
            this.labelX1.Location = new System.Drawing.Point(3, 28);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "模型点：";
            // 
            // itemPanel1
            // 
            this.itemPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.ForeColor = System.Drawing.Color.Black;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnOpenProject,
            this.btnReport,
            this.btnProjectSetting});
            this.itemPanel1.ItemSpacing = 20;
            this.itemPanel1.Location = new System.Drawing.Point(288, 2);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(260, 55);
            this.itemPanel1.TabIndex = 0;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Symbol = "";
            this.btnOpenProject.SymbolSize = 40F;
            this.btnOpenProject.Text = "buttonItem1";
            this.btnOpenProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnReport
            // 
            this.btnReport.Name = "btnReport";
            this.btnReport.Symbol = "";
            this.btnReport.SymbolSize = 40F;
            this.btnReport.Text = "buttonItem3";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnProjectSetting
            // 
            this.btnProjectSetting.Name = "btnProjectSetting";
            this.btnProjectSetting.Symbol = "";
            this.btnProjectSetting.SymbolSize = 40F;
            this.btnProjectSetting.Text = "buttonItem2";
            this.btnProjectSetting.Click += new System.EventHandler(this.btnProjectSetting_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.itemPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 59);
            this.panel1.TabIndex = 4;
            // 
            // addPoint
            // 
            this.addPoint.Name = "addPoint";
            this.addPoint.Symbol = "";
            this.addPoint.SymbolSize = 30F;
            this.addPoint.Text = "buttonItem4";
            this.addPoint.Click += new System.EventHandler(this.addPoint_Click);
            // 
            // FormMetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 609);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.metroStatusBar1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(888, 609);
            this.Name = "FormMetro";
            this.Text = "BIM放样控制软件";
            this.Load += new System.EventHandler(this.FormMetro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.LabelItem labelTitle;
        private DevComponents.DotNetBar.ButtonItem btnInfoSetting;
        private DevComponents.DotNetBar.ButtonItem btnMin;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private VectorDraw.Professional.Control.VectorDrawBaseControl vDraw;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ButtonItem btnOpenProject;
        private DevComponents.DotNetBar.ButtonItem btnProjectSetting;
        private DevComponents.DotNetBar.ButtonItem btnReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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
        private DevComponents.DotNetBar.ItemPanel itemPanel2;
        private DevComponents.DotNetBar.ButtonItem btnPre;
        private DevComponents.DotNetBar.ButtonItem btnNext;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ItemPanel itemPanel3;
        private DevComponents.DotNetBar.ButtonItem btnShowAll;
        private DevComponents.DotNetBar.ButtonItem btnPan;
        private DevComponents.DotNetBar.ButtonItem btnRotate;
        private DevComponents.DotNetBar.ButtonItem btnPer;
        private DevComponents.DotNetBar.ButtonItem btnWalkThrough;
        private DevComponents.DotNetBar.ButtonItem btnSetupOriginPoint;
        private DevComponents.DotNetBar.ButtonItem btnZoomIn;
        private DevComponents.DotNetBar.ButtonItem btnZoomOut;
        private DevComponents.DotNetBar.ButtonX btnCancelCommand;
        private DevComponents.DotNetBar.ButtonItem addPoint;
    }
}