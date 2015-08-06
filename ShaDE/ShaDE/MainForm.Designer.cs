namespace ShaDE
{
    partial class _Parent
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuildInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuildInterface
            // 
            this.BuildInterface.Size = new System.Drawing.Size(867, 34);
            // 
            // BuildInterface_Start
            // 
            this.BuildInterface_Start.FlatAppearance.BorderSize = 0;
            // 
            // _Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 600);
            this.CloseVisible = true;
            this.ControlsVisible = true;
            this.IconImage = global::ShaDE.Properties.Resources.ShaDE;
            this.IconVisible = true;
            this.MaximiseVisible = true;
            this.MinimiseVisible = true;
            this.Name = "_Parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Title = "ShaDE : Shader Handling and Development Environment";
            this.BuildInterface.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

