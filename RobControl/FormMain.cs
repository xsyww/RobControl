using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RobControl
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            tabMain.TabsVisible = !tabMain.TabsVisible;
        }

        private void btnInfoSetting_Click(object sender, EventArgs e)
        {
            (new FormRobotSetting()).ShowDialog(this);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPrj_Click(object sender, EventArgs e)
        {

        }

        private void c1FlexGrid3_Click(object sender, EventArgs e)
        {

        }
    }
}
