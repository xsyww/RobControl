using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;

namespace RobControl
{
    public delegate void CloseClickEvent(UserControl ctrl);
    public delegate void CreatePrjEvent();
    public delegate void SavePrjEvent();

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
        }


        private void FormMetro_Load(object sender, EventArgs e)
        {
            btnProject_Click(null, null);
        }


        private void btnProject_Click(object sender, EventArgs e)
        {
            _ctrlProjects = new CtrlProjects();
            _ctrlProjects.CloseClickHandler = ClosePanel;
            _ctrlProjects.CreatePrjHandler = ShowPrjInfoPanel;
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

    }
}
