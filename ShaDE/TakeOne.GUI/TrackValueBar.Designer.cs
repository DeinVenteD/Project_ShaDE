namespace TakeOne.GUI
{
    partial class TrackValueBar
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
            this.MinValueLabel = new System.Windows.Forms.Label();
            this.MaxValueLabel = new System.Windows.Forms.Label();
            this.CurrentValueLabel = new System.Windows.Forms.Label();
            this.Track = new TakeOne.GUI.TrackBar();
            this.SuspendLayout();
            // 
            // MinValueLabel
            // 
            this.MinValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinValueLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MinValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinValueLabel.ForeColor = System.Drawing.Color.White;
            this.MinValueLabel.Location = new System.Drawing.Point(0, 40);
            this.MinValueLabel.Name = "MinValueLabel";
            this.MinValueLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MinValueLabel.Size = new System.Drawing.Size(60, 22);
            this.MinValueLabel.TabIndex = 2;
            this.MinValueLabel.Text = "0";
            // 
            // MaxValueLabel
            // 
            this.MaxValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaxValueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxValueLabel.ForeColor = System.Drawing.Color.White;
            this.MaxValueLabel.Location = new System.Drawing.Point(240, 40);
            this.MaxValueLabel.Name = "MaxValueLabel";
            this.MaxValueLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.MaxValueLabel.Size = new System.Drawing.Size(60, 22);
            this.MaxValueLabel.TabIndex = 3;
            this.MaxValueLabel.Text = "100";
            this.MaxValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CurrentValueLabel
            // 
            this.CurrentValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentValueLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentValueLabel.Location = new System.Drawing.Point(103, 32);
            this.CurrentValueLabel.Name = "CurrentValueLabel";
            this.CurrentValueLabel.Size = new System.Drawing.Size(100, 25);
            this.CurrentValueLabel.TabIndex = 4;
            this.CurrentValueLabel.Text = "0";
            this.CurrentValueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Track
            // 
            this.Track.BackColor = System.Drawing.Color.Transparent;
            this.Track.Dock = System.Windows.Forms.DockStyle.Top;
            this.Track.Location = new System.Drawing.Point(0, 0);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(300, 40);
            this.Track.TabIndex = 1;
            this.Track.Value = 0;
            this.Track.ValueChange += new TakeOne.GUI.TracklineEventHandler(this.Track_ValueChange);
            // 
            // TrackValueBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CurrentValueLabel);
            this.Controls.Add(this.MaxValueLabel);
            this.Controls.Add(this.MinValueLabel);
            this.Controls.Add(this.Track);
            this.Name = "TrackValueBar";
            this.Size = new System.Drawing.Size(300, 62);
            this.Resize += new System.EventHandler(this.Trackbar_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private TrackBar Track;
        private System.Windows.Forms.Label MinValueLabel;
        private System.Windows.Forms.Label MaxValueLabel;
        private System.Windows.Forms.Label CurrentValueLabel;


    }
}
