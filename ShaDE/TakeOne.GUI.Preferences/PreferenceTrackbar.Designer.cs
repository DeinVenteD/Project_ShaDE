namespace TakeOne.GUI.Preferences
{
    partial class PreferenceTrackbar
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
            this.PropertySlide = new TakeOne.GUI.TrackBar();
            this.PropertyNumber = new TakeOne.GUI.Numeric();
            this.LayoutPanel = new System.Windows.Forms.Panel();
            this.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PropertySlide
            // 
            this.PropertySlide.BackColor = System.Drawing.Color.Transparent;
            this.PropertySlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertySlide.Location = new System.Drawing.Point(120, 0);
            this.PropertySlide.Name = "PropertySlide";
            this.PropertySlide.Size = new System.Drawing.Size(334, 35);
            this.PropertySlide.TabIndex = 2;
            this.PropertySlide.Value = 0;
            this.PropertySlide.ValueChange += new TakeOne.GUI.TracklineEventHandler(this.PropertySlide_ValueChange);
            // 
            // PropertyNumber
            // 
            this.PropertyNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PropertyNumber.Location = new System.Drawing.Point(0, 6);
            this.PropertyNumber.Name = "PropertyNumber";
            this.PropertyNumber.Size = new System.Drawing.Size(60, 20);
            this.PropertyNumber.TabIndex = 3;
            this.PropertyNumber.Value = 0F;
            this.PropertyNumber.ValueChange += new TakeOne.GUI.NumericEventHandler(this.PropertyNumber_ValueChange);
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Controls.Add(this.PropertyNumber);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LayoutPanel.Location = new System.Drawing.Point(454, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(65, 35);
            this.LayoutPanel.TabIndex = 4;
            // 
            // SliderProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.PropertySlide);
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.PropertyLabel);
            this.Name = "SliderProperty";
            this.Size = new System.Drawing.Size(519, 35);
            this.LayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TakeOne.GUI.TrackBar PropertySlide;
        private Numeric PropertyNumber;
        private System.Windows.Forms.Panel LayoutPanel;
    }
}
