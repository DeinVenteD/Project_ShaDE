namespace ShaDE
{
    partial class SolutionExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionExplorer));
            this.SolutionTreeView = new CodersLab.Windows.Controls.TreeView();
            this.TreeImages = new System.Windows.Forms.ImageList(this.components);
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.SolutionTreeView);
            this.ContentPanel.Controls.Add(this.SearchBox);
            // 
            // SolutionTreeView
            // 
            this.SolutionTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SolutionTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SolutionTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SolutionTreeView.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionTreeView.ForeColor = System.Drawing.Color.White;
            this.SolutionTreeView.ImageIndex = 0;
            this.SolutionTreeView.ImageList = this.TreeImages;
            this.SolutionTreeView.Location = new System.Drawing.Point(0, 18);
            this.SolutionTreeView.Name = "SolutionTreeView";
            this.SolutionTreeView.SelectedImageIndex = 0;
            this.SolutionTreeView.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.SolutionTreeView.SelectionMode = CodersLab.Windows.Controls.TreeViewSelectionMode.SingleSelect;
            this.SolutionTreeView.Size = new System.Drawing.Size(490, 352);
            this.SolutionTreeView.TabIndex = 0;
            // 
            // TreeImages
            // 
            this.TreeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeImages.ImageStream")));
            this.TreeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeImages.Images.SetKeyName(0, "File.png");
            this.TreeImages.Images.SetKeyName(1, "Folder.png");
            this.TreeImages.Images.SetKeyName(2, "Image.png");
            this.TreeImages.Images.SetKeyName(3, "Project.png");
            this.TreeImages.Images.SetKeyName(4, "Settings.png");
            this.TreeImages.Images.SetKeyName(5, "Shader.png");
            this.TreeImages.Images.SetKeyName(6, "Solution.png");
            this.TreeImages.Images.SetKeyName(7, "Window.png");
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.White;
            this.SearchBox.Location = new System.Drawing.Point(0, 0);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(490, 18);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.Text = "- Search -";
            this.SearchBox.Visible = false;
            // 
            // SolutionExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.CloseVisible = true;
            this.ControlsVisible = true;
            this.MaximiseVisible = true;
            this.Name = "SolutionExplorer";
            this.Text = "Solution Explorer";
            this.Title = "Solution Explorer";
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox;
        public CodersLab.Windows.Controls.TreeView SolutionTreeView;
        private System.Windows.Forms.ImageList TreeImages;
    }
}