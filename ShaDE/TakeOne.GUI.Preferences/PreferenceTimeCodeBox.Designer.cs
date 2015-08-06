namespace TakeOne.GUI.Preferences
{
    partial class PreferenceTimeCodeBox
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
            this.TimeCodeValue = new TakeOne.GUI.TimeCodeInput();
            this.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Controls.Add(this.TimeCodeValue);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LayoutPanel.Location = new System.Drawing.Point(120, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(221, 35);
            this.LayoutPanel.TabIndex = 4;
            // 
            // TimeCodeValue
            // 
            this.TimeCodeValue.Location = new System.Drawing.Point(0, 5);
            this.TimeCodeValue.Name = "TimeCodeValue";
            this.TimeCodeValue.Size = new System.Drawing.Size(221, 22);
            this.TimeCodeValue.TabIndex = 0;
            // 
            // PreferenceTimeCodeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.LayoutPanel);
            this.Name = "PreferenceTimeCodeBox";
            this.Controls.SetChildIndex(this.PropertyLabel, 0);
            this.Controls.SetChildIndex(this.LayoutPanel, 0);
            this.LayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LayoutPanel;
        private TimeCodeInput TimeCodeValue;
    }
}
