namespace TakeOne.GUI.Preferences
{
    partial class PreferenceSetShortcutDialog
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
            this.PropertyShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PropertyShow
            // 
            this.PropertyShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyShow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyShow.ForeColor = System.Drawing.Color.White;
            this.PropertyShow.Location = new System.Drawing.Point(120, 0);
            this.PropertyShow.Name = "PropertyShow";
            this.PropertyShow.Size = new System.Drawing.Size(399, 35);
            this.PropertyShow.TabIndex = 3;
            this.PropertyShow.Text = "Value";
            this.PropertyShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PropertyShow.Click += new System.EventHandler(this.PropertyShow_Click);
            // 
            // ShortcutProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.PropertyShow);
            this.Controls.Add(this.PropertyLabel);
            this.Name = "ShortcutProperty";
            this.Size = new System.Drawing.Size(519, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PropertyShow;
    }
}
