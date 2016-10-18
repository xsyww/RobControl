using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using VectorDraw.Geometry;

namespace RobControl
{
    public partial class FormAddPoint : Form
    {
        public ModelPoint MPoint = null;
        public ValidatePointName ValidateNameMethod = null;

        public FormAddPoint()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (ValidateNameMethod != null)
            {
                if (!ValidateNameMethod(txtName.Text))
                    return;
            }

            double dx, dy, dz;
            if (double.TryParse(txtx.Text, out dx) &&
                double.TryParse(txty.Text, out dy) &&
                double.TryParse(txtz.Text, out dz))
            {
                MPoint = new ModelPoint(txtName.Text);
                MPoint.x = dx;
                MPoint.y = dy;
                MPoint.z = dz;
                MPoint.Type = 0;

                DialogResult = DialogResult.OK;
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
