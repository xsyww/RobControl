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
    public partial class CtrlProjects : UserControl
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

                var tileItem = new DevComponents.DotNetBar.Metro.MetroTileItem();
                tileItem.TileSize = new Size(360, 180);
                tileItem.TitleText = prjName;
                tileItem.Click += TileItem_Click;
                if (File.Exists(dir + "\\image.jpg"))
                    tileItem.Image = Image.FromFile(dir + "\\image.jpg");

                prjItemContainer.SubItems.Add(tileItem);
            }
        }

        private void TileItem_Click(object sender, EventArgs e)
        {
            var item = sender as DevComponents.DotNetBar.Metro.MetroTileItem;
            if (item == null)
                return;

            if (OpenPrjHandler != null)
                OpenPrjHandler(item.TitleText);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (CloseClickHandler != null)
                CloseClickHandler(this);
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
