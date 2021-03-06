﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace RobControl
{
    class ProjectConfigFileOper
    {
        public static bool CreatePrjFile(string prjName)
        {
            try
            {
                ProjectInfo prjInfo = new ProjectInfo(prjName);

                if (!Directory.Exists(prjInfo.ProjectFolderPath))
                    Directory.CreateDirectory(prjInfo.ProjectFolderPath);

                XmlDocument doc = new XmlDocument();
                var elem = doc.CreateElement("Project");
                doc.AppendChild(elem);
                doc.Save(prjInfo.ProjectFilePathName);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool SavePrjInfo(ProjectInfo prjInfo)
        {
            try
            {
                var doc = new XmlDocument();
                doc.Load(prjInfo.ProjectFilePathName);

                var rootElem = doc.DocumentElement;
                if (rootElem == null)
                    return false;

                var pointsNode = rootElem.GetElementsByTagName("Points");
                if (pointsNode.Count > 0)
                {
                    pointsNode[0].RemoveAll();
                }
                else
                {
                    var points = doc.CreateElement("Points");
                    rootElem.AppendChild(points);
                }

                pointsNode = rootElem.GetElementsByTagName("Points");
                if (pointsNode.Count < 1)
                    return false;

                foreach (ModelPoint pt in prjInfo.ModelPoints)
                {
                    var ptNode = doc.CreateElement("Point");
                    ptNode.SetAttribute("x", pt.x.ToString());
                    ptNode.SetAttribute("y", pt.y.ToString());
                    ptNode.SetAttribute("z", pt.z.ToString());

                    ptNode.SetAttribute("x1", pt.x1.ToString());
                    ptNode.SetAttribute("y1", pt.y1.ToString());
                    ptNode.SetAttribute("z1", pt.z1.ToString());
                    ptNode.InnerText = pt.Name;
                    ptNode.SetAttribute("Type", pt.Type.ToString());

                    pointsNode[0].AppendChild(ptNode);
                }

                doc.Save(prjInfo.ProjectFilePathName);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存项目信息失败！\n" + ex.Message);
                return false;
            }
        }

        public static ProjectInfo LoadPrjInfo(string prjName)
        {
            try
            {
                ProjectInfo prjInfo = new ProjectInfo(prjName);

                var doc = new XmlDocument();
                doc.Load(prjInfo.ProjectFilePathName);

                var rootElem = doc.DocumentElement;
                if (rootElem == null)
                    return null;

                prjInfo.ModelPoints.Clear();
                var pointsNode = rootElem.GetElementsByTagName("Point");
                foreach (XmlNode ptNode in pointsNode)
                {
                    var ptElem = ptNode as XmlElement;
                    if (ptElem == null)
                        continue;

                    var point = new ModelPoint(ptElem.InnerText)
                    {
                        x = double.Parse(ptElem.GetAttribute("x")),
                        y = double.Parse(ptElem.GetAttribute("y")),
                        z = double.Parse(ptElem.GetAttribute("z")),
                        x1 = double.Parse(ptElem.GetAttribute("x1")),
                        y1 = double.Parse(ptElem.GetAttribute("y1")),
                        z1 = double.Parse(ptElem.GetAttribute("z1")),
                        Type = int.Parse(ptElem.GetAttribute("Type"))
                    };

                    prjInfo.ModelPoints.Add(point);
                }

                return prjInfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取项目信息失败！ \n" + ex.Message);
                return null;
            }
        }
    }
}
