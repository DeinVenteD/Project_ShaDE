namespace TakeOne.GUI
{
    partial class FileView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Toolbar = new System.Windows.Forms.Panel();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.TextFilterBox = new System.Windows.Forms.TextBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.SearchImage = new System.Windows.Forms.PictureBox();
            this.ToolSortType = new System.Windows.Forms.Button();
            this.ToolSortSize = new System.Windows.Forms.Button();
            this.ToolSortName = new System.Windows.Forms.Button();
            this.ToolSortTime = new System.Windows.Forms.Button();
            this.List = new TakeOne.GUI.ListViewer();
            this.Toolbar.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Toolbar
            // 
            this.Toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Toolbar.Controls.Add(this.ToolSortType);
            this.Toolbar.Controls.Add(this.ToolSortSize);
            this.Toolbar.Controls.Add(this.ToolSortName);
            this.Toolbar.Controls.Add(this.ToolSortTime);
            this.Toolbar.Controls.Add(this.SortByLabel);
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(289, 20);
            this.Toolbar.TabIndex = 1;
            // 
            // SortByLabel
            // 
            this.SortByLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SortByLabel.ForeColor = System.Drawing.Color.White;
            this.SortByLabel.Location = new System.Drawing.Point(0, 0);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(46, 20);
            this.SortByLabel.TabIndex = 8;
            this.SortByLabel.Text = "Sort By:";
            this.SortByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextFilterBox
            // 
            this.TextFilterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TextFilterBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextFilterBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextFilterBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFilterBox.ForeColor = System.Drawing.Color.White;
            this.TextFilterBox.Location = new System.Drawing.Point(0, 0);
            this.TextFilterBox.Name = "TextFilterBox";
            this.TextFilterBox.Size = new System.Drawing.Size(263, 26);
            this.TextFilterBox.TabIndex = 3;
            this.TextFilterBox.TextChanged += new System.EventHandler(this.TextFilterBox_TextChanged);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BottomPanel.Controls.Add(this.TextFilterBox);
            this.BottomPanel.Controls.Add(this.SearchImage);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 416);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(289, 26);
            this.BottomPanel.TabIndex = 4;
            // 
            // SearchImage
            // 
            this.SearchImage.BackgroundImage = global::TakeOne.GUI.Properties.Resources.Search;
            this.SearchImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchImage.Location = new System.Drawing.Point(263, 0);
            this.SearchImage.Name = "SearchImage";
            this.SearchImage.Size = new System.Drawing.Size(26, 26);
            this.SearchImage.TabIndex = 4;
            this.SearchImage.TabStop = false;
            // 
            // ToolSortType
            // 
            this.ToolSortType.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortByType;
            this.ToolSortType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolSortType.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolSortType.FlatAppearance.BorderSize = 0;
            this.ToolSortType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ToolSortType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ToolSortType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolSortType.ForeColor = System.Drawing.Color.White;
            this.ToolSortType.Location = new System.Drawing.Point(226, 0);
            this.ToolSortType.Name = "ToolSortType";
            this.ToolSortType.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ToolSortType.Size = new System.Drawing.Size(60, 20);
            this.ToolSortType.TabIndex = 7;
            this.ToolSortType.Tag = "3";
            this.ToolSortType.Text = "Type";
            this.ToolSortType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolSortType.UseVisualStyleBackColor = true;
            this.ToolSortType.Click += new System.EventHandler(this.ToolSort_Click);
            this.ToolSortType.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tool_MouseDown);
            this.ToolSortType.MouseEnter += new System.EventHandler(this.Tool_MouseEnter);
            this.ToolSortType.MouseLeave += new System.EventHandler(this.Tool_MouseLeave);
            this.ToolSortType.MouseHover += new System.EventHandler(this.Tool_MouseHover);
            this.ToolSortType.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tool_MouseUp);
            // 
            // ToolSortSize
            // 
            this.ToolSortSize.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortBySize;
            this.ToolSortSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolSortSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolSortSize.FlatAppearance.BorderSize = 0;
            this.ToolSortSize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ToolSortSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ToolSortSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolSortSize.ForeColor = System.Drawing.Color.White;
            this.ToolSortSize.Location = new System.Drawing.Point(166, 0);
            this.ToolSortSize.Name = "ToolSortSize";
            this.ToolSortSize.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ToolSortSize.Size = new System.Drawing.Size(60, 20);
            this.ToolSortSize.TabIndex = 6;
            this.ToolSortSize.Tag = "2";
            this.ToolSortSize.Text = "Size";
            this.ToolSortSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolSortSize.UseVisualStyleBackColor = true;
            this.ToolSortSize.Click += new System.EventHandler(this.ToolSort_Click);
            this.ToolSortSize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tool_MouseDown);
            this.ToolSortSize.MouseEnter += new System.EventHandler(this.Tool_MouseEnter);
            this.ToolSortSize.MouseLeave += new System.EventHandler(this.Tool_MouseLeave);
            this.ToolSortSize.MouseHover += new System.EventHandler(this.Tool_MouseHover);
            this.ToolSortSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tool_MouseUp);
            // 
            // ToolSortName
            // 
            this.ToolSortName.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortByName;
            this.ToolSortName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolSortName.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolSortName.FlatAppearance.BorderSize = 0;
            this.ToolSortName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ToolSortName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ToolSortName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolSortName.ForeColor = System.Drawing.Color.White;
            this.ToolSortName.Location = new System.Drawing.Point(106, 0);
            this.ToolSortName.Name = "ToolSortName";
            this.ToolSortName.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ToolSortName.Size = new System.Drawing.Size(60, 20);
            this.ToolSortName.TabIndex = 5;
            this.ToolSortName.Tag = "1";
            this.ToolSortName.Text = "Name";
            this.ToolSortName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolSortName.UseVisualStyleBackColor = true;
            this.ToolSortName.Click += new System.EventHandler(this.ToolSort_Click);
            this.ToolSortName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tool_MouseDown);
            this.ToolSortName.MouseEnter += new System.EventHandler(this.Tool_MouseEnter);
            this.ToolSortName.MouseLeave += new System.EventHandler(this.Tool_MouseLeave);
            this.ToolSortName.MouseHover += new System.EventHandler(this.Tool_MouseHover);
            this.ToolSortName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tool_MouseUp);
            // 
            // ToolSortTime
            // 
            this.ToolSortTime.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortByTime;
            this.ToolSortTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolSortTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolSortTime.FlatAppearance.BorderSize = 0;
            this.ToolSortTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ToolSortTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ToolSortTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolSortTime.ForeColor = System.Drawing.Color.White;
            this.ToolSortTime.Location = new System.Drawing.Point(46, 0);
            this.ToolSortTime.Name = "ToolSortTime";
            this.ToolSortTime.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ToolSortTime.Size = new System.Drawing.Size(60, 20);
            this.ToolSortTime.TabIndex = 4;
            this.ToolSortTime.Tag = "0";
            this.ToolSortTime.Text = "Time";
            this.ToolSortTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolSortTime.UseVisualStyleBackColor = true;
            this.ToolSortTime.Click += new System.EventHandler(this.ToolSort_Click);
            this.ToolSortTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tool_MouseDown);
            this.ToolSortTime.MouseEnter += new System.EventHandler(this.Tool_MouseEnter);
            this.ToolSortTime.MouseLeave += new System.EventHandler(this.Tool_MouseLeave);
            this.ToolSortTime.MouseHover += new System.EventHandler(this.Tool_MouseHover);
            this.ToolSortTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tool_MouseUp);
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.List.FileTypeFilter = -1;
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 30;
            this.List.Location = new System.Drawing.Point(0, 20);
            this.List.Name = "List";
            this.List.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.List.Size = new System.Drawing.Size(289, 396);
            this.List.SortType = 0;
            this.List.TabIndex = 2;
            this.List.TextFilter = "";
            this.List.DoubleClick += new System.EventHandler(this.FilesView_DoubleClick);
            // 
            // FileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.List);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.Toolbar);
            this.Name = "FileView";
            this.Size = new System.Drawing.Size(289, 442);
            this.Toolbar.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Toolbar;
        private TakeOne.GUI.ListViewer List;
        private System.Windows.Forms.TextBox TextFilterBox;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.PictureBox SearchImage;
        private System.Windows.Forms.Button ToolSortTime;
        private System.Windows.Forms.Button ToolSortType;
        private System.Windows.Forms.Button ToolSortSize;
        private System.Windows.Forms.Button ToolSortName;
        private System.Windows.Forms.Label SortByLabel;
    }
}
