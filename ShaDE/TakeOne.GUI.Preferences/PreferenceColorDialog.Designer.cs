namespace TakeOne.GUI.Preferences
{
    partial class PreferenceColorDialog
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
            this.ColorValue = new System.Windows.Forms.Button();
            this.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Controls.Add(this.ColorValue);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LayoutPanel.Location = new System.Drawing.Point(120, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(98, 35);
            this.LayoutPanel.TabIndex = 4;
            // 
            // ColorValue
            // 
            this.ColorValue.BackColor = System.Drawing.Color.Red;
            this.ColorValue.FlatAppearance.BorderSize = 0;
            this.ColorValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorValue.Location = new System.Drawing.Point(20, 6);
            this.ColorValue.Name = "ColorValue";
            this.ColorValue.Size = new System.Drawing.Size(75, 23);
            this.ColorValue.TabIndex = 1;
            this.ColorValue.UseVisualStyleBackColor = false;
            this.ColorValue.Click += new System.EventHandler(this.ColorValue_Click);
            // 
            // ColorProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.PropertyLabel);
            this.Name = "ColorProperty";
            this.Size = new System.Drawing.Size(519, 35);
            this.LayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LayoutPanel;
        private System.Windows.Forms.Button ColorValue;
    }
}
