using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RobControl
{
    public partial class FormMakeStation : Form
    {
        public SelectPointFromModel ControlPointSelectHandler = null;
        public SelectPointFromModel BackVisionPointSelectHandler = null;

        public Form parent = null;

        public ModelPoint ControlPoint = null;
        public ModelPoint BackVisionPoint = null;

        public FormMakeStation()
        {
            InitializeComponent();
        }

        private void btnSelectControlPoint_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            if (ControlPointSelectHandler != null)
            {
                var pt = ControlPointSelectHandler();
                if (pt != null)
                {
                    txtControlPoint.Text = pt.Name;
                    ControlPoint = pt;
                }
            }

            this.Visible = true;
        }

        private void btnSelectBackVisionPoint_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            if (BackVisionPointSelectHandler != null)
            {
                var pt = BackVisionPointSelectHandler();
                if (pt != null)
                {
                    txtVisionPoint.Text = pt.Name;
                    BackVisionPoint = pt;
                }
            }

            this.Visible = true;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRobHeight.Text))
            {
                MessageBox.Show("仪器高输入非法");
                return;
            }

            if (string.IsNullOrEmpty(txtMirrorHeight.Text))
            {
                MessageBox.Show("棱镜高输入非法");
                return;
            }

            if (BackVisionPoint == null)
            {
                MessageBox.Show("请设置后视点");
                return;
            }

            if (ControlPoint == null)
            {
                MessageBox.Show("请设置控制点");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FormMakeStation_Load(object sender, EventArgs e)
        {
            BackVisionPoint = null;
            ControlPoint = null;
        }
    }
}
