using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobControl
{
    public partial class MainItemPanelCtrl : UserControl
    {
        public delegate void CancelClickedEvent();

        public CancelClickedEvent CloseHandle;


        public MainItemPanelCtrl()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (CloseHandle != null)
                CloseHandle();
        }
    }
}
