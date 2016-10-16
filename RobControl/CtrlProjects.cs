using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobControl
{
    public partial class CtrlProjects : UserControl
    {
        public CloseClickEvent CloseClickHandler;
        public CreatePrjEvent CreatePrjHandler;
        public string SelectedProjectPath = string.Empty;

        public CtrlProjects()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (CloseClickHandler != null)
                CloseClickHandler(this);
        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddPrj_Click(object sender, EventArgs e)
        {
            if (CreatePrjHandler != null)
                CreatePrjHandler();

            if (CloseClickHandler != null)
                CloseClickHandler(this);
        }
    }
}
