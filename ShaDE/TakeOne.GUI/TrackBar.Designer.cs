namespace TakeOne.GUI
{
    partial class TrackBar
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
            this.Pointer = new System.Windows.Forms.PictureBox();
            this.Bar = new System.Windows.Forms.PictureBox();
            this.LeftMargin = new System.Windows.Forms.Panel();
            this.RightMargin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Pointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // Pointer
            // 
            this.Pointer.BackgroundImage = global::TakeOne.GUI.Properties.Resources.Circle;
            this.Pointer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pointer.Location = new System.Drawing.Point(10, 10);
            this.Pointer.Name = "Pointer";
            this.Pointer.Size = new System.Drawing.Size(20, 20);
            this.Pointer.TabIndex = 1;
            this.Pointer.TabStop = false;
            this.Pointer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pointer_MouseDown);
            this.Pointer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pointer_MouseMove);
            this.Pointer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pointer_MouseUp);
            // 
            // Bar
            // 
            this.Bar.BackgroundImage = global::TakeOne.GUI.Properties.Resources.Line;
            this.Bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bar.Location = new System.Drawing.Point(10, 0);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(280, 40);
            this.Bar.TabIndex = 0;
            this.Bar.TabStop = false;
            this.Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bar_MouseDown);
            this.Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bar_MouseMove);
            this.Bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bar_MouseUp);
            // 
            // LeftMargin
            // 
            this.LeftMargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMargin.Location = new System.Drawing.Point(0, 0);
            this.LeftMargin.Name = "LeftMargin";
            this.LeftMargin.Size = new System.Drawing.Size(10, 40);
            this.LeftMargin.TabIndex = 2;
            // 
            // RightMargin
            // 
            this.RightMargin.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightMargin.Location = new System.Drawing.Point(290, 0);
            this.RightMargin.Name = "RightMargin";
            this.RightMargin.Size = new System.Drawing.Size(10, 40);
            this.RightMargin.TabIndex = 3;
            // 
            // TrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Pointer);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.RightMargin);
            this.Controls.Add(this.LeftMargin);
            this.Name = "TrackBar";
            this.Size = new System.Drawing.Size(300, 40);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Trackline_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Trackline_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Trackline_MouseUp);
            this.Resize += new System.EventHandler(this.Trackline_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Pointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Bar;
        private System.Windows.Forms.PictureBox Pointer;
        private System.Windows.Forms.Panel LeftMargin;
        private System.Windows.Forms.Panel RightMargin;

    }
}
