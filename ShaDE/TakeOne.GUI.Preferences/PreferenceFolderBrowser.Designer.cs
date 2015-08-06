namespace TakeOne.GUI.Preferences
{
    partial class PreferenceFolderBrowser
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
            this.LayoutPanel = new System.Windows.Forms.Panel();
            this.PropertyFindRoot = new System.Windows.Forms.Button();
            this.PropertyRoot = new System.Windows.Forms.TextBox();
            this.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Controls.Add(this.PropertyFindRoot);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LayoutPanel.Location = new System.Drawing.Point(449, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(70, 35);
            this.LayoutPanel.TabIndex = 2;
            // 
            // PropertyFindRoot
            // 
            this.PropertyFindRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PropertyFindRoot.FlatAppearance.BorderSize = 0;
            this.PropertyFindRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PropertyFindRoot.ForeColor = System.Drawing.Color.White;
            this.PropertyFindRoot.Location = new System.Drawing.Point(3, 5);
            this.PropertyFindRoot.Name = "PropertyFindRoot";
            this.PropertyFindRoot.Size = new System.Drawing.Size(45, 25);
            this.PropertyFindRoot.TabIndex = 6;
            this.PropertyFindRoot.Text = "...";
            this.PropertyFindRoot.UseVisualStyleBackColor = false;
            this.PropertyFindRoot.Click += new System.EventHandler(this.PropertyFindRoot_Click);
            // 
            // PropertyRoot
            // 
            this.PropertyRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PropertyRoot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PropertyRoot.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyRoot.ForeColor = System.Drawing.Color.White;
            this.PropertyRoot.Location = new System.Drawing.Point(126, 8);
            this.PropertyRoot.Name = "PropertyRoot";
            this.PropertyRoot.ReadOnly = true;
            this.PropertyRoot.Size = new System.Drawing.Size(1258, 18);
            this.PropertyRoot.TabIndex = 5;
            this.PropertyRoot.TextChanged += new System.EventHandler(this.PropertyRoot_TextChanged);
            // 
            // PreferenceFolderBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.PropertyRoot);
            this.Name = "PreferenceFolderBrowser";
            this.Controls.SetChildIndex(this.PropertyRoot, 0);
            this.Controls.SetChildIndex(this.LayoutPanel, 0);
            this.LayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LayoutPanel;
        private System.Windows.Forms.Button PropertyFindRoot;
        private System.Windows.Forms.TextBox PropertyRoot;
    }
}
