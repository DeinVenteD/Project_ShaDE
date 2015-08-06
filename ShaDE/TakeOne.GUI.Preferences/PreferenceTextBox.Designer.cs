namespace TakeOne.GUI.Preferences
{
    partial class PreferenceTextBox
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
            this.PropertyRoot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PropertyRoot
            // 
            this.PropertyRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PropertyRoot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PropertyRoot.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyRoot.ForeColor = System.Drawing.Color.White;
            this.PropertyRoot.Location = new System.Drawing.Point(126, 8);
            this.PropertyRoot.Name = "PropertyRoot";
            this.PropertyRoot.Size = new System.Drawing.Size(1258, 18);
            this.PropertyRoot.TabIndex = 5;
            this.PropertyRoot.TextChanged += new System.EventHandler(this.PropertyRoot_TextChanged);
            // 
            // StringProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.PropertyRoot);
            this.Controls.Add(this.PropertyLabel);
            this.Name = "StringProperty";
            this.Size = new System.Drawing.Size(519, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PropertyRoot;
    }
}
