using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;

namespace RobControl
{
    public partial class CtrlProjects : Form
    {
        public CloseClickEvent CloseClickHandler;
        public CreatePrjEvent CreatePrjHandler;
        public OperPrjEvent OpenPrjHandler;
        public string SelectedProjectPath = string.Empty;

        public CtrlProjects()
        {
            InitializeComponent();
        }

        private void CtrlProjects_Load(object sender, EventArgs e)
        {
            LoadPrjIntoMetroPanel();
        }

        private void LoadPrjIntoMetroPanel()
        {
            prjItemContainer.SubItems.Clear();

            var dirs = Directory.GetDirectories(ProjectInfo.ProjectPath);
            if (dirs.Length < 1)
                return;

            foreach (string dir in dirs)
            {
                var folders = dir.Split('\\');
                var prjName = folders[folders.Length - 1];
                var files = Directory.GetFiles(dir, "PrjData.xml", SearchOption.TopDirectoryOnly);
                if (files.Length < 1)
                    continue;

                var tileItem = new MetroTileItem();
                tileItem.TileSize = new Size(360, 180);
                tileItem.TitleText = prjName;
                tileItem.Click += TileItem_Click;
                if (File.Exists(dir + "\\image.jpg"))
                {
                    Image img = Image.FromFile(dir + "\\image.jpg");
                    tileItem.Image = new Bitmap(img);
                    img.Dispose();
                }

                prjItemContainer.SubItems.Add(tileItem);
            }
        }

        private void TileItem_Click(object sender, EventArgs e)
        {
            var item = sender as MetroTileItem;
            if (item == null)
                return;


            SelectedProjectPath = item.TitleText;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddPrj_Click(object sender, EventArgs e)
        {
            CtrlPrjInfo dlg = new CtrlPrjInfo();
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            LoadPrjIntoMetroPanel();
        }

        private void btnDeletePrj_Click(object sender, EventArgs e)
        {
            var selectedItems = new List<MetroTileItem>();

            foreach (var item in prjItemContainer.SubItems)
            {
                var prjItem = item as MetroTileItem;
                if (prjItem == null)
                    continue;

                if (prjItem.Checked)
                    selectedItems.Add(prjItem);
            }

            if (selectedItems.Count < 1)
            {
                MessageBox.Show("当前没有选中的项目！");
                return;
            }

            foreach (var item in selectedItems)
            {
                if (DeletePrjFolder(item.TitleText))
                    prjItemContainer.SubItems.Remove(item);
            }

            tilePanel.RecalcLayout();
        }

        private bool DeletePrjFolder(string prjName)
        {
            try
            {
                var result = MessageBox.Show("您确定要删除项目[" + prjName + "]吗？删除后将无法恢复！", "确认删除", MessageBoxButtons.OKCancel);
                if (result != DialogResult.OK)
                    return true;

                DirectoryInfo di = new DirectoryInfo(ProjectInfo.ProjectPath + "\\" + prjName);
                di.Delete(true);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除项目文件夹失败！\n" + ex.Message);
                return false;
            }
        }
    }
}
