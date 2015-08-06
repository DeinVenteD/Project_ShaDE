namespace TakeOne.GUI.Preferences
{
    partial class PreferenceItem
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
            this.PropertyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PropertyLabel
            // 
            this.PropertyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PropertyLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PropertyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyLabel.ForeColor = System.Drawing.Color.White;
            this.PropertyLabel.Location = new System.Drawing.Point(0, 0);
            this.PropertyLabel.Name = "PropertyLabel";
            this.PropertyLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.PropertyLabel.Size = new System.Drawing.Size(120, 35);
            this.PropertyLabel.TabIndex = 1;
            this.PropertyLabel.Text = "Property Label";
            this.PropertyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PropertyLabel.UseMnemonic = false;
            // 
            // PreferenceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.PropertyLabel);
            this.Name = "PreferenceItem";
            this.Size = new System.Drawing.Size(519, 35);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label PropertyLabel;
    }
}
