using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using VectorDraw.Professional.vdFigures;

namespace RobControl
{
    class ProjectInfo
    {
        public ProjectInfo(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public List<ModelPoint> ModelPoints { get; set; }

        public static string ProjectPath
        {
            get { return Application.StartupPath + "\\Projects"; }
        }

        public string ProjectFolderPath
        {
            get { return ProjectPath + "\\" + Name; }
        }

        public string ProjectFilePathName
        {
            get { return ProjectFolderPath + "\\PrjData.xml"; }
        }

        public string ImageFilePathName
        {
            get { return ProjectFolderPath + "\\image.jpg"; }
        }

        public string ModelFilePathName
        {
            get { return ProjectFolderPath + "\\model.vdcl"; }
        }
    }
}
