using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using VectorDraw.Geometry;
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
            this.CloseModalPanel(ctrl, DevComponents.DotNetBar.Controls.eSlideSide.Left);
            ctrl.Dispose();
            ctrl = null;
        }

        private void OpenProject(string prjName)
        {
            ClosePanel(_ctrlProjects);

            CloseCurrentDrawing();
            InitRenderProperty();

            var prjInfo = ProjectConfigFileOper.LoadPrjInfo(prjName);
            if (prjInfo == null)
                return;

            vDraw.ActiveDocument.Open(prjInfo.ModelFilePathName);
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
            }
        }
    }
}
