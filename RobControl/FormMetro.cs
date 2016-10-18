using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using VectorDraw.Actions;
using VectorDraw.Geometry;
using VectorDraw.Professional.vdFigures;
using VectorDraw.Professional.vdObjects;
using VectorDraw.Professional.vdPrimaries;
using VectorDraw.Render;

namespace RobControl
{
    public partial class FormMetro : MetroAppForm
    {
        private CtrlProjects _ctrlProjects = null;
        private CtrlDocument _ctrlReport = null;
        private CtrlRobSetting _ctrlRobSetting = null;
        private CtrlPrjInfo _ctrlPrjInfo = null;
        private ProjectInfo _currentProject = null;
        private FormMakeStation _formStation = null;

        public FormMetro()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            vDraw.GripSelectionModified += VDraw_GripSelectionModified;
        }


        private void FormMetro_Load(object sender, EventArgs e)
        {
            InitRenderProperty();
            btnProject_Click(null, null);
        }

        /// <summary>
        /// 初始化vDraw的渲染属性
        /// </summary>
        private void InitRenderProperty()
        {
            vDraw.ActiveDocument.GlobalRenderProperties.CustomRenderTypeName = "VectorDraw.Render.opengllist#VectorDraw.Professional.dll";
            vDraw.ActiveDocument.GlobalRenderProperties.SpeedupModel = 2;
            vDraw.ActiveDocument.GlobalRenderProperties.TimerBreakForDraw = 300;
            vDraw.ActiveDocument.GlobalRenderProperties.DynamicRotFlag = vdRenderGlobalProperties.DynamicRotFlags.AroundViewCenter;
            vDraw.ActiveDocument.FocalLength = 100.0;
            vDraw.ActiveDocument.ActiveLayOut.RenderMode = vdRender.Mode.Shade;
            vDraw.ActiveDocument.LensAngle = 60;
            vDraw.ActiveDocument.WalkThroughKeys.MovementSpeedIncrease = Keys.OemPeriod;
            vDraw.ActiveDocument.WalkThroughKeys.MovementSpeedDecrease = Keys.Oemcomma;
            //vDraw.ActiveDocument.EnableAutoGripOn = false;
            vDraw.ActiveDocument.GlobalRenderProperties.SetLayerHide.Clear();
            vDraw.ActiveDocument.osnapMode = OsnapMode.END | OsnapMode.MID | OsnapMode.INTERS | OsnapMode.CEN;
            vDraw.ActiveDocument.GlobalRenderProperties.SelectionPreview = vdRenderGlobalProperties.SelectionPreviewFlags.OFF;
            //vDraw.ActiveDocument.GlobalRenderProperties.SelectionPreviewColor = Color.LawnGreen;
            vDraw.ActiveDocument.EntitySelectMode = PickEntityMode.EyeNearest;
            vDraw.ActiveDocument.GlobalRenderProperties.PickAdd = false;
            vDraw.ActiveDocument.OrbitActionKey = vdDocument.KeyWithMouseStroke.ShiftLeft;
        }

        private void CloseCurrentDrawing()
        {
            vDraw.ActiveDocument.ClearAll();
            vDraw.ActiveDocument.EnsureDefaults();
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            _ctrlProjects = new CtrlProjects();
            _ctrlProjects.CloseClickHandler = ClosePanel;
            _ctrlProjects.CreatePrjHandler = ShowPrjInfoPanel;
            _ctrlProjects.OpenPrjHandler = OpenProject;
            _ctrlProjects.Size = GetCurrentClientSize();
            this.ShowModalPanel(_ctrlProjects, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void ShowPrjInfoPanel()
        {
            _ctrlPrjInfo = new CtrlPrjInfo();
            _ctrlPrjInfo.CloseClickHandler = ClosePanel;
            _ctrlPrjInfo.Size = GetCurrentClientSize();
            this.ShowModalPanel(_ctrlPrjInfo, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            _ctrlReport = new CtrlDocument();
            _ctrlReport.CloseClickHandler = ClosePanel;
            _ctrlReport.Size = GetCurrentClientSize();
            this.ShowModalPanel(_ctrlReport, DevComponents.DotNetBar.Controls.eSlideSide.Left);

        }

        private void btnInfoSetting_Click(object sender, EventArgs e)
        {
            _ctrlRobSetting = new CtrlRobSetting();
            _ctrlRobSetting.CloseClickHandler = ClosePanel;
            this.ShowModalPanel(_ctrlRobSetting, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void ClosePanel(UserControl ctrl)
        {
            if (ctrl == null)
                return;

            this.CloseModalPanel(ctrl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            ctrl.Dispose();
            ctrl = null;
        }

        private void OpenProject(string prjName)
        {
            ClosePanel(_ctrlProjects);

            CloseCurrentDrawing();
            InitRenderProperty();

            _currentProject = ProjectConfigFileOper.LoadPrjInfo(prjName);
            if (_currentProject == null)
                return;

            ShowPointsInGrid();

            vDraw.ActiveDocument.Open(_currentProject.ModelFilePathName);

            CreatePoints(_currentProject.ModelPoints);
        }

        private void ShowPointsInGrid()
        {
            gridPoints.SetDataBinding(new List<ModelPoint>(), "", true);

            if (_currentProject == null)
                return;

            gridPoints.SetDataBinding(_currentProject.ModelPoints, "", true);
        }

        private void CreatePoints(List<ModelPoint> points)
        {
            points.ForEach(CreatePoint);
            vDraw.ActiveDocument.Redraw(true);
        }

        private void CreatePoint(ModelPoint pt)
        {
            vdInsert vdi = new vdInsert(vDraw.ActiveDocument, GetSphereBlk(), new gPoint(pt.x, pt.y, pt.z), 0, 5, 5, 5);
            vDraw.ActiveDocument.ActiveLayOut.Entities.Add(vdi);

            vdXProperty vdx = new vdXProperty();
            vdx.Name = "#PointName";
            vdx.PropValue = pt.Name;
            vdi.XProperties.Add(vdx);

            vDraw.ActiveDocument.Redraw(false);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private Size GetCurrentClientSize()
        {
            return new Size(this.Width - 50, this.Height - 100);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void VDraw_GripSelectionModified(object sender, VectorDraw.Professional.vdPrimaries.vdLayout layout,
            VectorDraw.Professional.vdCollections.vdSelection gripSelection)
        {
            if (gripSelection != null)
            {
                /*
                if (vDraw.ActiveDocument.PerspectiveMod == vdRender.VdConstPerspectiveMod.PerspectOFF)
                {
                    var hilightted = (from vdFigure vdf in vDraw.ActiveDocument.ActiveLayOut.Entities
                        where vdf.HighLight
                        select vdf).ToList();

                    hilightted.ForEach(vdf => vdf.HighLight = false);
                    foreach (vdFigure vdf in gripSelection)
                        vdf.HighLight = true;

                    vDraw.ActiveDocument.Redraw(true);
                }
                */

                var pt = gripSelection.Last;
                if (pt == null)
                    return;

                var nameProp = pt.XProperties.FindName("#PointName");
                if (nameProp != null)
                    ShowPointInGrid(nameProp.PropValue.ToString());
            }
        }

        private void ShowPointInGrid(string pointName)
        {
            for (int i = 1; i < gridPoints.Rows.Count; i++)
            {
                var pt = gridPoints.Rows[i].DataSource as ModelPoint;
                if (pt == null)
                    continue;

                if (pt.Name == pointName)
                {
                    gridPoints.Select(i, 1);
                    break;
                }
            }
        }

        #region 自定义消息处理

        enum VDrawMsg
        {
            MSG_USER = 0x600,
            MSG_CANCEL,
            MSG_PAN,
            MSG_ROTATE
        }

        [DllImport("user32.dll")]
        static extern bool PostMessage(int hwnd, int msg, uint wParam, uint lParam);

        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case (int)VDrawMsg.MSG_CANCEL:
                    vDraw.ActiveDocument.CommandAction.Cancel();
                    break;
                case (int)VDrawMsg.MSG_PAN:
                    vDraw.ActiveDocument.CommandAction.Pan();
                    break;
                case (int)VDrawMsg.MSG_ROTATE:
                    RotateAroundCenter();
                    break;
                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }

        private void RotateAroundCenter()
        {

            var gripSel = vDraw.ActiveDocument.GetGripSelection();
            if (gripSel == null || gripSel.Count < 1)
            {
                vDraw.ActiveDocument.GlobalRenderProperties.DynamicRotFlag = vdRenderGlobalProperties.DynamicRotFlags.Auto;
            }
            else
            {
                vDraw.ActiveDocument.GlobalRenderProperties.DynamicRotFlag = vdRenderGlobalProperties.DynamicRotFlags.AroundViewCenter;
                var vdf = gripSel.Last;
                if (vdf != null)
                {
                    var pt = vDraw.ActiveDocument.ActiveRender.CurrentMatrix.Transform(vdf.BoundingBox.MidPoint);
                    vDraw.ActiveDocument.ActiveRender.ViewCenter = pt;
                    vDraw.ActiveDocument.Redraw(true);
                }
            }

            vDraw.ActiveDocument.ActionUtility.getUserDynamicRotEx(false);
        }
        #endregion

        #region vDraw工具条按钮事件

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            vDraw.ActiveDocument.ZoomExtents();
            vDraw.ActiveDocument.CommandAction.Zoom("E", null, null);
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            vDraw.ActiveDocument.CommandAction.Pan();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            PostMessage((int)Handle, (int)VDrawMsg.MSG_ROTATE, 0, 0);
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            SetPerspectiveMode(vDraw.ActiveDocument.PerspectiveMod == vdRender.VdConstPerspectiveMod.PerspectOFF);
        }

        private void btnWalkThrough_Click(object sender, EventArgs e)
        {
            if (btnWalkThrough.Checked)
            {
                PostMessage((int) Handle, (int) VDrawMsg.MSG_CANCEL, 0, 0);
            }
            else
            {
                btnWalkThrough.Checked = true;
                SetPerspectiveMode(true);
                vDraw.ActiveDocument.ActionUtility.getUserWalkThrough(200);
                btnWalkThrough.Checked = false;
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            vDraw.ActiveDocument.ZoomScale(0.9);
            vDraw.ActiveDocument.Redraw(true);
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            vDraw.ActiveDocument.ZoomScale(1 / 0.9);
            vDraw.ActiveDocument.Redraw(true);
        }

        /// <summary>
        /// 设置透视模式
        /// </summary>
        /// <param name="isOn"></param>
        private void SetPerspectiveMode(bool isOn)
        {

            vDraw.ActiveDocument.PerspectiveMod = isOn
                ? vdRender.VdConstPerspectiveMod.PerspectON
                : vdRender.VdConstPerspectiveMod.PerspectOFF;
            UnhighlightAll();

            btnPer.Checked = isOn;
            vDraw.ActiveDocument.Redraw(true);
        }

        private void UnhighlightAll()
        {
            var hilightted = (from vdFigure vdf in vDraw.ActiveDocument.ActiveLayOut.Entities
                              where vdf.HighLight
                              select vdf).ToList();

            hilightted.ForEach(vdf => vdf.HighLight = false);
        }

        private void btnCancelCommand_Click(object sender, EventArgs e)
        {
            PostMessage((int)Handle, (int)VDrawMsg.MSG_CANCEL, 0, 0);
        }

        #endregion

        #region grid事件

        private void gridPoints_SelChange(object sender, EventArgs e)
        {
            if (gridPoints.RowSel < 1)
                return;

            var selectedPoint = gridPoints.Rows[gridPoints.RowSel].DataSource as ModelPoint;
            if (selectedPoint == null)
                return;

            ShowModelPointInfo(selectedPoint);
            HighlightPointInModel(selectedPoint.Name);
        }

        private void ShowModelPointInfo(ModelPoint pt)
        {
            if (pt == null)
                return;

            txtMx.Text = pt.x.ToString();
            txtMy.Text = pt.y.ToString();
            txtMz.Text = pt.z.ToString();
        }

        private void HighlightPointInModel(string pointName)
        {
            UnhighlightAll();

            var point = (from vdFigure vdf in vDraw.ActiveDocument.ActiveLayOut.Entities
                where
                    vdf.XProperties.FindName("#PointName") != null &&
                    vdf.XProperties.FindName("#PointName").PropValue.ToString() == pointName
                select vdf).FirstOrDefault();

            if (point == null)
                return;

            point.HighLight = true;
            vDraw.ActiveDocument.Redraw(true);
        }

        #endregion

        private void addPoint_Click(object sender, EventArgs e)
        {
            if (_currentProject == null)
                return;
          
            var dlg = new FormAddPoint();
            dlg.ValidateNameMethod = IsPointNameValid; 
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;
            
            _currentProject.ModelPoints.Add(dlg.MPoint);
            CreatePoint(dlg.MPoint);
            ShowPointsInGrid();

            ShowPointInGrid(dlg.MPoint.Name);
        }

        private bool IsPointNameValid(string name)
        {
            if (_currentProject == null)
                return false;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("点名称不可为空");
                return false;
            }

            if (_currentProject.ModelPoints.Any(pt => pt.Name == name))
            {
                MessageBox.Show("已经有同名的点，请重新命名");
                return false;
            }

            return true;
        }

        #region 创建球形块

        private vdBlock GetSphereBlk()
        {
            vdBlock blk = vDraw.ActiveDocument.Blocks.FindName("_PointMark");
            if (blk == null)
            {
                vDraw.ActiveDocument.ActivePenColor.ColorIndex = 9;
                vDraw.ActiveDocument.CommandAction.CmdSphere(new gPoint(0, 0, 0), 1.0, 10, 10);
                vdFigure vdf = vDraw.ActiveDocument.ActiveLayOut.Entities.Last;
                if (vdf is vdPolyface)
                {
                    blk = new vdBlock(vDraw.ActiveDocument, "_PointMark");
                    blk.Entities.Add(vdf.Clone(vDraw.ActiveDocument));
                    vDraw.ActiveDocument.Blocks.Add(blk);
                    vdf.Deleted = true;

                    return blk;
                }
                return null;
            }
            return blk;
        }

        #endregion

        private void btnProjectSetting_Click(object sender, EventArgs e)
        {

        }

        private void SaveCurrentDrawing()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "vdcl|*.vdcl";
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            vDraw.ActiveDocument.SaveAs(dlg.FileName);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (gridPoints.Rows.Count < 1)
                return;

            var index = gridPoints.RowSel;
            if (index < 1)
                gridPoints.Select(1, 1);
            else
                gridPoints.Select(index - 1, 1);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (gridPoints.Rows.Count < 1)
                return;

            var index = gridPoints.RowSel;
            if (index < 1)
                gridPoints.Select(1, 1);
            else if (index == gridPoints.Rows.Count - 1)
                return;
            else
                gridPoints.Select(index + 1, 1);
        }

        private ModelPoint SelectPoint()
        {
            vdFigure vdf;
            gPoint gp;
            string pointName = string.Empty;
            while (true)
            {
                var res = vDraw.ActiveDocument.ActionUtility.getUserEntity(out vdf, out gp);
                if (res == StatusCode.Cancel)
                    return null;

                if (res == StatusCode.Success)
                {
                    var xp = vdf.XProperties.FindName("#PointName");
                    if (xp == null)
                        continue;

                    pointName = xp.PropValue.ToString();
                    break;
                }
            }

            return _currentProject.ModelPoints.FirstOrDefault(pt => pt.Name == pointName);
        }

        private void btnSetupOriginPoint_Click(object sender, EventArgs e)
        {
            if (_formStation == null || _formStation.IsDisposed)
                _formStation = new FormMakeStation();

            _formStation.ControlPointSelectHandler = SelectPoint;
            _formStation.BackVisionPointSelectHandler = SelectPoint;
            _formStation.Show(this);
        }
    }
}
