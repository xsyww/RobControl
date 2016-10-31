using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RobControl
{
    public partial class CtrlPrjInfo : Form
    {
        public CloseClickEvent CloseClickHandler;

        private string _sourceModelFilePath;

        public CtrlPrjInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSavePrj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrjName.Text))
            {
                MessageBox.Show("请输入项目名称");
                return;
            }

            var filePath = ProjectInfo.ProjectPath + "\\" + txtPrjName.Text;
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                if (txtPrjName.Text.Contains(c.ToString()))
                {
                    MessageBox.Show("项目名中包含不可使用的字符，请重新命名。");
                    return;
                }
            }

            try
            {
                if (!Directory.Exists(filePath))
                    Directory.CreateDirectory(filePath);

                var prjInfo = new ProjectInfo(txtPrjName.Text);

                if (!string.IsNullOrEmpty(_sourceModelFilePath))
                    File.Copy(_sourceModelFilePath, prjInfo.ModelFilePathName, true);

                if (picPreview.Image != null)
                    picPreview.Image.Save(prjInfo.ImageFilePathName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建项目文件夹失败！\n" + ex.Message);
                return;
            }

            ProjectInfo info = new ProjectInfo(txtPrjName.Text);
            info.ModelPoints.Add(new ModelPoint("testPoint"));
            if (!ProjectConfigFileOper.CreatePrjFile(info.Name))
                return;

            if (!ProjectConfigFileOper.SavePrjInfo(info))
                return;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void prjSelectModel_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Revit轻量化模型文件（*.vdcl）|*.vdcl";
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            _sourceModelFilePath = dlg.FileName;
            txtModelName.Text = Path.GetFileName(dlg.FileName);
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "图形文件（*.jpg）|*.jpg";
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            Image img = Image.FromFile(dlg.FileName);
            Bitmap bmp = new Bitmap(img, new Size(360, 180));
            picPreview.Image = bmp;
        }
    }
}
