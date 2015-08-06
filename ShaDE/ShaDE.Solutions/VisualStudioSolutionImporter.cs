using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace ShaDE.Solutions
{
    public class VisualStudioSolutionImporter
    {
        private static Project ImportCS_Project(string Root)
        {
            Project NewProject = new Project();
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.Load(Root);
            foreach(XmlNode CNode in XMLDoc.DocumentElement.ChildNodes)
            {
                if(CNode.Name == "ItemGroup")
                {
                    foreach (XmlNode CCNode in CNode.ChildNodes)
                    {
                        if(CCNode.Name == "Reference")
                        {
                            NewProject.References.Add(CCNode.Attributes["Include"].InnerText);
                        }
                        if (CCNode.Name == "ProjectReference")
                        {
                            foreach (XmlNode CCCNode in CCNode.ChildNodes)
                            {
                                if (CCCNode.Name == "Name")
                                {
                                    NewProject.References.Add(CCCNode.InnerText);
                                    break;
                                }
                            }
                        }
                        if (CCNode.Name == "Compile")
                        {
                            int FType = 0;
                            foreach (XmlNode CCCNode in CCNode.ChildNodes)
                            {
                                if(CCCNode.Name == "SubType")
                                {
                                    if (CCCNode.InnerText == "Form") FType = 7;
                                    else if (CCCNode.InnerText == "UserControl") FType = 7;
                                }
                            }
                            Folder CurrentFolder = NewProject.ProjectFolder;
                            string Path = CCNode.Attributes["Include"].InnerText;
                            string[] BrokenPath = Path.Split('\\');
                            for(int i = 0; i < BrokenPath.Length-1; i++)
                            {
                                bool Exists = false;
                                for(int j = 0; j < CurrentFolder.Subfolders.Count; j++)
                                {
                                    if(CurrentFolder.Subfolders[j].Name == BrokenPath[i])
                                    {
                                        CurrentFolder = CurrentFolder.Subfolders[j];
                                        Exists = true;
                                        break;
                                    }
                                }
                                if(Exists) continue;
                                Folder NewFolder = new Folder();
                                NewFolder.Name = BrokenPath[i];
                                CurrentFolder.Subfolders.Add(NewFolder);
                                CurrentFolder = NewFolder;
                            }
                            File NewFile = new File();
                            NewFile.Type = FType;
                            NewFile.Name = BrokenPath[BrokenPath.Length - 1];
                            NewFile.Root = System.IO.Path.GetDirectoryName(Root) + "\\" + Path;
                            CurrentFolder.Files.Add(NewFile);
                        }
                        if (CCNode.Name == "None")
                        {
                            Folder CurrentFolder = NewProject.ProjectFolder;
                            string Path = CCNode.Attributes["Include"].InnerText;
                            string[] BrokenPath = Path.Split('\\');
                            for (int i = 0; i < BrokenPath.Length - 1; i++)
                            {
                                bool Exists = false;
                                for (int j = 0; j < CurrentFolder.Subfolders.Count; j++)
                                {
                                    if (CurrentFolder.Subfolders[j].Name == BrokenPath[i])
                                    {
                                        CurrentFolder = CurrentFolder.Subfolders[j];
                                        Exists = true;
                                        break;
                                    }
                                }
                                if (Exists) continue;
                                Folder NewFolder = new Folder();
                                NewFolder.Name = BrokenPath[i];
                                CurrentFolder.Subfolders.Add(NewFolder);
                                CurrentFolder = NewFolder;
                            }
                            File NewFile = new File();
                            NewFile.Type = 0;
                            NewFile.Name = BrokenPath[BrokenPath.Length - 1];
                            if (NewFile.Name.EndsWith(".png") || NewFile.Name.EndsWith(".jpeg") || NewFile.Name.EndsWith(".jpg") || NewFile.Name.EndsWith(".bmp") || NewFile.Name.EndsWith(".ico")) NewFile.Type = 2;
                            NewFile.Root = System.IO.Path.GetDirectoryName(Root) + "\\" + Path;
                            CurrentFolder.Files.Add(NewFile);
                        }
                    }
                }
            }
            return NewProject;
        }
        private static Project ImportCPP_Project(string Root)
        {
            Project NewProject = new Project();
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.Load(Root);
            foreach (XmlNode CNode in XMLDoc.DocumentElement.ChildNodes)
            {
                if (CNode.Name == "ItemGroup")
                {
                    foreach (XmlNode CCNode in CNode.ChildNodes)
                    {
                        if (CCNode.Name == "Reference")
                        {
                            NewProject.References.Add(CCNode.Attributes["Include"].InnerText);
                        }
                        if (CCNode.Name == "ProjectReference")
                        {
                            NewProject.References.Add(CCNode.Attributes["Include"].InnerText);
                        }
                    }
                }
            }
            XMLDoc = new XmlDocument();
            XMLDoc.Load(Root + ".filters");
            foreach (XmlNode CNode in XMLDoc.DocumentElement.ChildNodes)
            {
                if (CNode.Name == "ItemGroup")
                {
                    foreach (XmlNode CCNode in CNode.ChildNodes)
                    {
                        if (CCNode.Name == "ClCompile" || CCNode.Name == "ClInclude" || CCNode.Name == "Text" || CCNode.Name == "Image" || CCNode.Name == "None")
                        {
                            int FType = 0;
                            string Location = "";
                            foreach (XmlNode CCCNode in CCNode.ChildNodes)
                            {
                                if (CCCNode.Name == "Filter")
                                {
                                    Location = CCCNode.InnerText;
                                }
                            }
                            Folder CurrentFolder = NewProject.ProjectFolder;
                            string Path = CCNode.Attributes["Include"].InnerText;
                            string[] BrokenPath = Location.Split('\\');
                            for (int i = 0; i < BrokenPath.Length; i++)
                            {
                                if (BrokenPath[i] == "") break;
                                bool Exists = false;
                                for (int j = 0; j < CurrentFolder.Subfolders.Count; j++)
                                {
                                    if (CurrentFolder.Subfolders[j].Name == BrokenPath[i])
                                    {
                                        CurrentFolder = CurrentFolder.Subfolders[j];
                                        Exists = true;
                                        break;
                                    }
                                }
                                if (Exists) continue;
                                Folder NewFolder = new Folder();
                                NewFolder.Name = BrokenPath[i];
                                CurrentFolder.Subfolders.Add(NewFolder);
                                CurrentFolder = NewFolder;
                            }
                            File NewFile = new File();
                            NewFile.Type = FType;
                            if(NewFile.Name.EndsWith(".png") || NewFile.Name.EndsWith(".jpeg") || NewFile.Name.EndsWith(".jpg") || NewFile.Name.EndsWith(".bmp") || NewFile.Name.EndsWith(".ico")) NewFile.Type = 2;
                            NewFile.Name = System.IO.Path.GetFileName(Path);
                            NewFile.Root = System.IO.Path.GetDirectoryName(Root) + "\\" + Path;
                            CurrentFolder.Files.Add(NewFile);
                        }
                    }
                }
            }
            return NewProject;
        }
        public static Solution Import(string Root)
        {
            Solution NewSolution = new Solution();
            NewSolution.Name = Path.GetFileNameWithoutExtension(Root);
            string[] Lines = System.IO.File.ReadAllLines(Root);
            for (int i = 0; i < Lines.Length; i++)
            {
                if (Lines[i].StartsWith("Project"))
                {
                    string Sublines = Lines[i].Remove(0, 52);
                    string[] SublinesValues = Sublines.Split('\"');
                    Project NewProject = null;
                    if (SublinesValues[3].EndsWith(".csproj")) NewProject = ImportCS_Project(Path.GetDirectoryName(Root) + "\\" + SublinesValues[3]);
                    else if (SublinesValues[3].EndsWith(".vcxproj")) NewProject = ImportCPP_Project(Path.GetDirectoryName(Root) + "\\" + SublinesValues[3]);
                    if (NewProject == null) return null;
                    NewProject.ProjectFolder.Name = SublinesValues[1];
                    NewSolution.Projects.Add(NewProject);
                }
            }
            return NewSolution;
        }
    }
}
