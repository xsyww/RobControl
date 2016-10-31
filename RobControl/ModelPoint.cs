using System;
using System.Collections.Generic;
using System.Text;

namespace RobControl
{
    public class ModelPoint
    {
        public ModelPoint(string name)
        {
            this.Name = name;

            x = 0;
            y = 0;
            z = 0;
            x1 = 0;
            y1 = 0;
            z1 = 0;
            Type = 0;
        }

        public string Name { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double z1 { get; set; }
        public bool Checked { get; set; }
        public int Type { get; set; }
    }
}
