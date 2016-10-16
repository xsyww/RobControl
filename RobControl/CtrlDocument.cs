using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobControl
{
    public partial class CtrlDocument : UserControl
    {
        public CloseClickEvent CloseClickHandler;

        public CtrlDocument()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (CloseClickHandler != null)
                CloseClickHandler(this);
        }
    }
}
