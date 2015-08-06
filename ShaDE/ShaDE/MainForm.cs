using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using TakeOne.WindowSuite;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Build.Execution;
using Microsoft.Build.Evaluation;

namespace ShaDE
{
    public partial class _Parent : MainForm
    {
        private string _Version = "0.0.1.0";
        private string _SolutionPath = "";
        private string _OutputPath = "";
        private SolutionExplorer _SolutionExplorerInstance;
        private List<string> _OpenedFiles;
        public _Parent()
        {
            InitializeComponent();
            this.Title += " " + _Version;
            _SolutionExplorerInstance = new SolutionExplorer();
            _SolutionExplorerInstance.Show(MainDock, DockState.DockLeft);
            BuildInterface_Start.Click += new EventHandler(Menu_BuildRun_Click);
            openToolStripMenuItem.Click += new EventHandler(Menu_Open_Click);
            openFileToolStripMenuItem.Click += new EventHandler(Menu_OpenFile_Click);
            buildToolStripMenuItem.Click += new EventHandler(Menu_Build_Click);
            buildRunToolStripMenuItem.Click += new EventHandler(Menu_BuildRun_Click);
            buildInterfaceToolStripMenuItem.Click += new EventHandler(Menu_View_BuildInterface_Click);
            _SolutionExplorerInstance.SolutionTreeView.DoubleClick += new EventHandler(SolutionExplorer_DoubleCLick);
            _OpenedFiles = new List<string>();
        }
        private void Menu_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Visual Studio Solution (*.sln)|*.sln";
            Dialog.Multiselect = false;
            if(Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShaDE.Solutions.Solution NewSolution = ShaDE.Solutions.VisualStudioSolutionImporter.Import(Dialog.FileName);
                _SolutionExplorerInstance.UpdateSolution(NewSolution);
                _SolutionPath = Dialog.FileName;
            }
        }
        private void Menu_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Code Files (*.cs;*.c;*.cpp;*.h;*.hpp)|*.cs;*.c;*.cpp;*.h;*.hpp|Shader Files (*.vertex;*.fragment)|*.vertex;*.fragment|Image Files (*.png;*.jpeg;*.jpg;*.bmp;*.ico)|*.png;*.jpeg;*.jpg;*.bmp;*.ico|Other as Text (*.*)|*.*";
            Dialog.Multiselect = true;
            if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for(int i = 0; i < Dialog.FileNames.Count(); i++)
                {
                    Open_File(Dialog.FileNames[i], Dialog.FilterIndex-1);
                }
            }
        }
        private void SolutionExplorer_DoubleCLick(object sender, EventArgs e)
        {
            try
            {
                if (_SolutionExplorerInstance.SolutionTreeView.SelectedNodes[0] == null) return;
                TreeNode Node = _SolutionExplorerInstance.SolutionTreeView.SelectedNodes[0];
                string FilePath = (string)Node.Tag;
                if (FilePath == null) return;
                if (_OpenedFiles.Contains(FilePath)) return;
                Open_File_FilterFileType(FilePath);
            }
            catch { }
        }
        private void Open_File_FilterFileType(string FilePath)
        {
            if (FilePath.EndsWith(".cs") || FilePath.EndsWith(".c") || FilePath.EndsWith(".cpp") || FilePath.EndsWith(".h") || FilePath.EndsWith(".hpp")) Open_File(FilePath, 0);
            else if (FilePath.EndsWith(".vertex") || FilePath.EndsWith(".fragment")) Open_File(FilePath, 1);
            else if (FilePath.EndsWith(".png") || FilePath.EndsWith(".jpeg") || FilePath.EndsWith(".jpg") || FilePath.EndsWith(".bmp") || FilePath.EndsWith(".ico")) Open_File(FilePath, 2);
            else Open_File(FilePath, 3);
        }
        private void Open_File(string FilePath, int Type)
        {
            if (Type == -1)
            {
                MessageBox.Show("File Type Not Supported","Not Supported");
                return;
            }
            if (Type == 0) Open_Document_File(FilePath);
            else if (Type == 1) Open_Document_File(FilePath);
            else if (Type == 2) Open_Image_File(FilePath);
            else if (Type == 3) Open_Document_File(FilePath);
        }
        private void Open_Document_File(string FilePath)
        {
            DocumentView NewDocumentView = new DocumentView();
            string Title = System.IO.Path.GetFileName(FilePath);
            string Text = System.IO.File.ReadAllText(FilePath);
            NewDocumentView.SetText(Title, Text);
            NewDocumentView.Show(MainDock, DockState.Document);
            _OpenedFiles.Add(FilePath);
        }
        private void Open_Image_File(string FilePath)
        {
            Bitmap ViewImage = (Bitmap)Image.FromFile(FilePath);
            ImageView NewImageView = new ImageView();
            string Title = System.IO.Path.GetFileName(FilePath);
            NewImageView.SetImage(Title, ViewImage);
            NewImageView.Show(MainDock, DockState.Document);
            _OpenedFiles.Add(FilePath);
        }
        private void Menu_BuildRun_Click(object sender, EventArgs e)
        {
            if (BuildSolution_VS()) RunSolution_VS();
        }
        private void Menu_Build_Click(object sender, EventArgs e)
        {
            if (BuildSolution_VS()) MessageBox.Show("Build Finished Successfully", "Success");
        }
        private bool BuildSolution_VS()
        {
            if (_SolutionPath == "") return false;
            try
            {
                string projectFilePath = Path.Combine(_SolutionPath);
                _OutputPath = _SolutionPath.Replace(Path.GetFileName(_SolutionPath), "") + "\\bin\\" + BuildInterface_Configuration.Text + "\\";
                ProjectCollection pc = new ProjectCollection();
                Dictionary<string, string> globalProperty = new Dictionary<string, string>();
                globalProperty.Add("OutputPath", _OutputPath);
                BuildParameters bp = new BuildParameters(pc);
                BuildRequestData buildRequest = new BuildRequestData(projectFilePath, globalProperty, "4.0", new string[] { "Build" }, null);
                BuildResult buildResult = BuildManager.DefaultBuildManager.Build(bp, buildRequest);
                if (buildResult.OverallResult == BuildResultCode.Success)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("There Are Errors", "Error");
                }
            }
            catch
            {
                MessageBox.Show("Build Failed Unexpectedly", "Error");
            }
            return false;
        }
        private void RunSolution_VS()
        {
            string RunPath = _OutputPath + Path.GetFileNameWithoutExtension(_SolutionPath) + ".exe";
            System.Diagnostics.Process.Start(RunPath);
        }
        private void Menu_View_BuildInterface_Click(object sender, EventArgs e)
        {
            BuildInterface.Visible = !BuildInterface.Visible;
        }
    }
}
