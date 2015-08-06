namespace TakeOne.GUI.Preferences
{
    partial class PreferenceCheckBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferenceCheckBox));
            this.PropertyCheck = new TakeOne.GUI.CustomPictureBox();
            this.LayoutPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyCheck)).BeginInit();
            this.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PropertyCheck
            // 
            this.PropertyCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PropertyCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PropertyCheck.BackgroundImage")));
            this.PropertyCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PropertyCheck.Checked = false;
            this.PropertyCheck.Location = new System.Drawing.Point(32, 2);
            this.PropertyCheck.Name = "PropertyCheck";
            this.PropertyCheck.Size = new System.Drawing.Size(30, 30);
            this.PropertyCheck.TabIndex = 0;
            this.PropertyCheck.TabStop = false;
            this.PropertyCheck.Change += new TakeOne.GUI.ValueChange(this.PropertyCheck_Change);
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Controls.Add(this.PropertyCheck);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LayoutPanel.Location = new System.Drawing.Point(120, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(66, 35);
            this.LayoutPanel.TabIndex = 2;
            // 
            // CheckBoxProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.PropertyLabel);
            this.Name = "CheckBoxProperty";
            this.Size = new System.Drawing.Size(519, 35);
            ((System.ComponentModel.ISupportInitialize)(this.PropertyCheck)).EndInit();
            this.LayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPictureBox PropertyCheck;
        private System.Windows.Forms.Panel LayoutPanel;
    }
}
