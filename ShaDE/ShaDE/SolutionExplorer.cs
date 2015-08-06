using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TakeOne.WindowSuite;
using CodersLab.Windows.Controls;

namespace ShaDE
{
    public partial class SolutionExplorer : ToolForm
    {
        public SolutionExplorer()
        {
            InitializeComponent();
        }
        private void UpdateSolution_Folder(TreeNode Node, ShaDE.Solutions.Folder CurrentFolder)
        {
            TreeNode CFolder = new TreeNode(CurrentFolder.Name);
            CFolder.ImageIndex = 1;
            CFolder.SelectedImageIndex = 1;
            for (int i = 0; i < CurrentFolder.Subfolders.Count; i++) UpdateSolution_Folder(CFolder, CurrentFolder.Subfolders[i]);
            for (int i = 0; i < CurrentFolder.Files.Count; i++)
            {
                TreeNode CFile = new TreeNode(CurrentFolder.Files[i].Name);
                CFile.ImageIndex = CurrentFolder.Files[i].Type;
                CFile.SelectedImageIndex = CurrentFolder.Files[i].Type;
                CFile.Tag = CurrentFolder.Files[i].Root;
                CFolder.Nodes.Add(CFile);
            }
            Node.Nodes.Add(CFolder);
        }
        public void UpdateSolution(ShaDE.Solutions.Solution NewSolution)
        {
            TreeNode Solutionnode = new TreeNode(NewSolution.Name);
            Solutionnode.ImageIndex = 6;
            Solutionnode.SelectedImageIndex = 6;
            for(int i = 0; i < NewSolution.Projects.Count; i++)
            {
                TreeNode Projectnode = new TreeNode(NewSolution.Projects[i].ProjectFolder.Name);
                Projectnode.ImageIndex = 3;
                Projectnode.SelectedImageIndex = 3;
                if (NewSolution.Projects[i].References.Count > 0)
                {
                    TreeNode References = new TreeNode("References");
                    References.ImageIndex = 1;
                    References.SelectedImageIndex = 1;
                    for(int j = 0; j < NewSolution.Projects[i].References.Count; j++)
                    {
                        TreeNode Reference = new TreeNode(NewSolution.Projects[i].References[j]);
                        Reference.ImageIndex = 4;
                        Reference.SelectedImageIndex = 4;
                        References.Nodes.Add(Reference);
                    }
                    Projectnode.Nodes.Add(References);
                }
                for(int j = 0; j < NewSolution.Projects[i].ProjectFolder.Subfolders.Count; j++) UpdateSolution_Folder(Projectnode, NewSolution.Projects[i].ProjectFolder.Subfolders[j]);
                for (int j = 0; j < NewSolution.Projects[i].ProjectFolder.Files.Count; j++)
                {
                    TreeNode CFile = new TreeNode(NewSolution.Projects[i].ProjectFolder.Files[j].Name);
                    CFile.ImageIndex = NewSolution.Projects[i].ProjectFolder.Files[j].Type;
                    CFile.SelectedImageIndex = NewSolution.Projects[i].ProjectFolder.Files[j].Type;
                    CFile.Tag = NewSolution.Projects[i].ProjectFolder.Files[j].Root;
                    Projectnode.Nodes.Add(CFile);
                }
                Solutionnode.Nodes.Add(Projectnode);
            }
            SolutionTreeView.Nodes.Clear();
            SolutionTreeView.Nodes.Add(Solutionnode);
        }
    }
}
