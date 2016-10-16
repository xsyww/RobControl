namespace RobControl
{
    partial class CtrlDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlDocument));
            this.c1FlexGrid3 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.btnAddPrj = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid3
            // 
            this.c1FlexGrid3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexGrid3.ColumnInfo = resources.GetString("c1FlexGrid3.ColumnInfo");
            this.c1FlexGrid3.Location = new System.Drawing.Point(8, 55);
            this.c1FlexGrid3.Name = "c1FlexGrid3";
            this.c1FlexGrid3.Rows.DefaultSize = 20;
            this.c1FlexGrid3.Rows.MinSize = 25;
            this.c1FlexGrid3.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
            this.c1FlexGrid3.Size = new System.Drawing.Size(686, 469);
            this.c1FlexGrid3.StyleInfo = resources.GetString("c1FlexGrid3.StyleInfo");
            this.c1FlexGrid3.TabIndex = 3;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX1.Location = new System.Drawing.Point(709, 55);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(77, 54);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolSize = 20F;
            this.buttonX1.TabIndex = 9;
            this.buttonX1.Text = "关闭";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX2.Location = new System.Drawing.Point(709, 207);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(77, 54);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolSize = 20F;
            this.buttonX2.TabIndex = 8;
            this.buttonX2.Text = "删除点";
            // 
            // btnAddPrj
            // 
            this.btnAddPrj.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddPrj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPrj.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddPrj.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddPrj.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAddPrj.Location = new System.Drawing.Point(709, 147);
            this.btnAddPrj.Name = "btnAddPrj";
            this.btnAddPrj.Size = new System.Drawing.Size(77, 54);
            this.btnAddPrj.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddPrj.Symbol = "";
            this.btnAddPrj.SymbolSize = 20F;
            this.btnAddPrj.TabIndex = 7;
            this.btnAddPrj.Text = "导出信息";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(10, 10);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(129, 39);
            this.labelX5.TabIndex = 18;
            this.labelX5.Text = "导出报告：";
            // 
            // CtrlDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.btnAddPrj);
            this.Controls.Add(this.c1FlexGrid3);
            this.Name = "CtrlDocument";
            this.Size = new System.Drawing.Size(800, 537);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX btnAddPrj;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}
