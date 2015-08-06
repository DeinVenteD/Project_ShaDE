namespace TakeOne.GUI
{
    partial class EnterKeyDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.KeysText = new System.Windows.Forms.Label();
            this.ResultOK = new System.Windows.Forms.Button();
            this.ResultCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Keys";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeysText
            // 
            this.KeysText.Dock = System.Windows.Forms.DockStyle.Top;
            this.KeysText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeysText.ForeColor = System.Drawing.Color.White;
            this.KeysText.Location = new System.Drawing.Point(0, 58);
            this.KeysText.Name = "KeysText";
            this.KeysText.Size = new System.Drawing.Size(314, 35);
            this.KeysText.TabIndex = 1;
            this.KeysText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultOK
            // 
            this.ResultOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ResultOK.FlatAppearance.BorderSize = 0;
            this.ResultOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultOK.ForeColor = System.Drawing.Color.White;
            this.ResultOK.Location = new System.Drawing.Point(12, 97);
            this.ResultOK.Name = "ResultOK";
            this.ResultOK.Size = new System.Drawing.Size(78, 27);
            this.ResultOK.TabIndex = 2;
            this.ResultOK.Text = "OK";
            this.ResultOK.UseVisualStyleBackColor = false;
            this.ResultOK.Click += new System.EventHandler(this.ResultOK_Click);
            // 
            // ResultCancel
            // 
            this.ResultCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ResultCancel.FlatAppearance.BorderSize = 0;
            this.ResultCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultCancel.ForeColor = System.Drawing.Color.White;
            this.ResultCancel.Location = new System.Drawing.Point(224, 97);
            this.ResultCancel.Name = "ResultCancel";
            this.ResultCancel.Size = new System.Drawing.Size(78, 27);
            this.ResultCancel.TabIndex = 3;
            this.ResultCancel.Text = "Cancel";
            this.ResultCancel.UseVisualStyleBackColor = false;
            this.ResultCancel.Click += new System.EventHandler(this.ResultCancel_Click);
            // 
            // EnterKeyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(314, 136);
            this.Controls.Add(this.ResultCancel);
            this.Controls.Add(this.ResultOK);
            this.Controls.Add(this.KeysText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnterKeyDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterKeyDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KeysText;
        private System.Windows.Forms.Button ResultOK;
        private System.Windows.Forms.Button ResultCancel;
    }
}