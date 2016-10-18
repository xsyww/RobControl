using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RobControl
{
    public delegate void CloseClickEvent(UserControl ctrl);
    public delegate void CreatePrjEvent();
    public delegate void OperPrjEvent(string prjName);

    public delegate bool ValidatePointName(string name);

    public delegate ModelPoint SelectPointFromModel();
    public delegate void CreateStationOKEvent(BackVisionData data, bool isBack);


    public class BackVisionData
    {
        public ModelPoint ControlPoint;
        public ModelPoint BackVisionPoint;

        public double MachineHeight = 0.0;
        public double MirrorHeight = 0.0;
    }

}
