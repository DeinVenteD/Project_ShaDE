namespace TakeOne.GUI
{
    partial class DeletionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletionDialog));
            this.DeleteFileEntries = new System.Windows.Forms.Button();
            this.DeleteScriptEntries = new System.Windows.Forms.Button();
            this.DefaultLabel = new System.Windows.Forms.Label();
            this.DontAskCheck = new TakeOne.GUI.CustomPictureBox();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DontAskCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ContentPanel.Controls.Add(this.DefaultLabel);
            this.ContentPanel.Controls.Add(this.DeleteScriptEntries);
            this.ContentPanel.Controls.Add(this.DeleteFileEntries);
            this.ContentPanel.Controls.Add(this.DontAskCheck);
            this.ContentPanel.Size = new System.Drawing.Size(421, 170);
            // 
            // DeleteFileEntries
            // 
            this.DeleteFileEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteFileEntries.FlatAppearance.BorderSize = 0;
            this.DeleteFileEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteFileEntries.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFileEntries.ForeColor = System.Drawing.Color.White;
            this.DeleteFileEntries.Location = new System.Drawing.Point(111, 70);
            this.DeleteFileEntries.Name = "DeleteFileEntries";
            this.DeleteFileEntries.Size = new System.Drawing.Size(200, 30);
            this.DeleteFileEntries.TabIndex = 28;
            this.DeleteFileEntries.Text = "Delete File Entries";
            this.DeleteFileEntries.UseVisualStyleBackColor = false;
            this.DeleteFileEntries.Click += new System.EventHandler(this.DeleteFileEntries_Click);
            // 
            // DeleteScriptEntries
            // 
            this.DeleteScriptEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteScriptEntries.FlatAppearance.BorderSize = 0;
            this.DeleteScriptEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteScriptEntries.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteScriptEntries.ForeColor = System.Drawing.Color.White;
            this.DeleteScriptEntries.Location = new System.Drawing.Point(111, 106);
            this.DeleteScriptEntries.Name = "DeleteScriptEntries";
            this.DeleteScriptEntries.Size = new System.Drawing.Size(200, 30);
            this.DeleteScriptEntries.TabIndex = 29;
            this.DeleteScriptEntries.Text = "Delete Script Entries";
            this.DeleteScriptEntries.UseVisualStyleBackColor = false;
            this.DeleteScriptEntries.Click += new System.EventHandler(this.DeleteScriptEntries_Click);
            // 
            // DefaultLabel
            // 
            this.DefaultLabel.AutoSize = true;
            this.DefaultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultLabel.ForeColor = System.Drawing.Color.White;
            this.DefaultLabel.Location = new System.Drawing.Point(122, 40);
            this.DefaultLabel.Name = "DefaultLabel";
            this.DefaultLabel.Size = new System.Drawing.Size(120, 16);
            this.DefaultLabel.TabIndex = 30;
            this.DefaultLabel.Text = "Don\'t ask anymore";
            // 
            // DontAskCheck
            // 
            this.DontAskCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DontAskCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DontAskCheck.BackgroundImage")));
            this.DontAskCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DontAskCheck.Checked = false;
            this.DontAskCheck.Location = new System.Drawing.Point(281, 35);
            this.DontAskCheck.Name = "DontAskCheck";
            this.DontAskCheck.Size = new System.Drawing.Size(30, 30);
            this.DontAskCheck.TabIndex = 3;
            this.DontAskCheck.TabStop = false;
            // 
            // DeletionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 200);
            this.Name = "DeletionDialog";
            this.Resizable = false;
            this.CloseVisible = false;
            this.MaximiseVisible = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletion Dialog";
            this.Title = "Deletion Dialog";
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DontAskCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPictureBox DontAskCheck;
        private System.Windows.Forms.Label DefaultLabel;
        private System.Windows.Forms.Button DeleteScriptEntries;
        private System.Windows.Forms.Button DeleteFileEntries;

    }
}