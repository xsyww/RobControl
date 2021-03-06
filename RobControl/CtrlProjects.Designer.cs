﻿namespace RobControl
{
    partial class CtrlProjects
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeletePrj = new DevComponents.DotNetBar.ButtonX();
            this.btnAddPrj = new DevComponents.DotNetBar.ButtonX();
            this.tilePanel = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.prjItemContainer = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem2 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem3 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem4 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem5 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem6 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem7 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnDeletePrj
            // 
            this.btnDeletePrj.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeletePrj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePrj.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeletePrj.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeletePrj.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDeletePrj.Location = new System.Drawing.Point(1296, 188);
            this.btnDeletePrj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletePrj.Name = "btnDeletePrj";
            this.btnDeletePrj.Size = new System.Drawing.Size(116, 81);
            this.btnDeletePrj.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeletePrj.Symbol = "";
            this.btnDeletePrj.SymbolSize = 20F;
            this.btnDeletePrj.TabIndex = 5;
            this.btnDeletePrj.Text = "删除项目";
            this.btnDeletePrj.Click += new System.EventHandler(this.btnDeletePrj_Click);
            // 
            // btnAddPrj
            // 
            this.btnAddPrj.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddPrj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPrj.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddPrj.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddPrj.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAddPrj.Location = new System.Drawing.Point(1296, 99);
            this.btnAddPrj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPrj.Name = "btnAddPrj";
            this.btnAddPrj.Size = new System.Drawing.Size(116, 81);
            this.btnAddPrj.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddPrj.Symbol = "";
            this.btnAddPrj.SymbolSize = 20F;
            this.btnAddPrj.TabIndex = 4;
            this.btnAddPrj.Text = "新建项目";
            this.btnAddPrj.Click += new System.EventHandler(this.btnAddPrj_Click);
            // 
            // tilePanel
            // 
            this.tilePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tilePanel.BackgroundStyle.Class = "MetroTilePanel";
            this.tilePanel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tilePanel.ContainerControlProcessDialogKey = true;
            this.tilePanel.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.prjItemContainer});
            this.tilePanel.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.tilePanel.Location = new System.Drawing.Point(33, 82);
            this.tilePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tilePanel.Name = "tilePanel";
            this.tilePanel.Size = new System.Drawing.Size(1255, 631);
            this.tilePanel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tilePanel.TabIndex = 3;
            this.tilePanel.Text = "metroTilePanel1";
            // 
            // prjItemContainer
            // 
            // 
            // 
            // 
            this.prjItemContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prjItemContainer.MultiLine = true;
            this.prjItemContainer.Name = "prjItemContainer";
            this.prjItemContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem2,
            this.metroTileItem1,
            this.metroTileItem3,
            this.metroTileItem4,
            this.metroTileItem5,
            this.metroTileItem6,
            this.metroTileItem7});
            // 
            // 
            // 
            this.prjItemContainer.TitleStyle.Class = "MetroTileGroupTitle";
            this.prjItemContainer.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem2
            // 
            this.metroTileItem2.Image = global::RobControl.Properties.Resources._1;
            this.metroTileItem2.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem2.Name = "metroTileItem2";
            this.metroTileItem2.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem2.Text = "项目1";
            this.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItem2.TileSize = new System.Drawing.Size(360, 180);
            // 
            // 
            // 
            this.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem2.TitleText = "项目说明文本";
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.Image = global::RobControl.Properties.Resources._2;
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItem1.TileSize = new System.Drawing.Size(360, 180);
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem1.TitleText = "项目说明文本";
            // 
            // metroTileItem3
            // 
            this.metroTileItem3.Image = global::RobControl.Properties.Resources._3;
            this.metroTileItem3.Name = "metroTileItem3";
            this.metroTileItem3.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItem3.TileSize = new System.Drawing.Size(360, 180);
            // 
            // 
            // 
            this.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem3.TitleText = "项目说明文本";
            // 
            // metroTileItem4
            // 
            this.metroTileItem4.Image = global::RobControl.Properties.Resources._4;
            this.metroTileItem4.Name = "metroTileItem4";
            this.metroTileItem4.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItem4.TileSize = new System.Drawing.Size(360, 180);
            // 
            // 
            // 
            this.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem4.TitleText = "项目说明文本";
            // 
            // metroTileItem5
            // 
            this.metroTileItem5.Name = "metroTileItem5";
            this.metroTileItem5.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem5.Text = "metroTileItem5";
            this.metroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItem5.TileSize = new System.Drawing.Size(360, 180);
            // 
            // 
            // 
            this.metroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem6
            // 
            this.metroTileItem6.Name = "metroTileItem6";
            this.metroTileItem6.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem6.Text = "metroTileItem6";
            this.metroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItem6.TileSize = new System.Drawing.Size(360, 180);
            // 
            // 
            // 
            this.metroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem7
            // 
            this.metroTileItem7.Name = "metroTileItem7";
            this.metroTileItem7.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem7.Text = "metroTileItem7";
            this.metroTileItem7.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItem7.TileSize = new System.Drawing.Size(360, 180);
            // 
            // 
            // 
            this.metroTileItem7.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(15, 15);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(194, 58);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "选择项目：";
            // 
            // CtrlProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1425, 852);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tilePanel);
            this.Controls.Add(this.btnDeletePrj);
            this.Controls.Add(this.btnAddPrj);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CtrlProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CtrlProjects_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnDeletePrj;
        private DevComponents.DotNetBar.ButtonX btnAddPrj;
        private DevComponents.DotNetBar.Metro.MetroTilePanel tilePanel;
        private DevComponents.DotNetBar.ItemContainer prjItemContainer;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem3;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem4;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem5;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem6;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem7;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}
