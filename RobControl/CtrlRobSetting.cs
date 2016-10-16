using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobControl
{
    public partial class CtrlRobSetting : UserControl
    {
        public CloseClickEvent CloseClickHandler;

        public CtrlRobSetting()
        {
            InitializeComponent();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            if (CloseClickHandler != null)
                CloseClickHandler(this);
        }
    }
}
