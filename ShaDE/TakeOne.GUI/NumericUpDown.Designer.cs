namespace TakeOne.GUI
{
    partial class Numeric
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
            this.NumericInput = new System.Windows.Forms.TextBox();
            this.ArrowPanel = new System.Windows.Forms.Panel();
            this.DownArrow = new System.Windows.Forms.PictureBox();
            this.UpArrow = new System.Windows.Forms.PictureBox();
            this.ArrowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DownArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericInput
            // 
            this.NumericInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumericInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumericInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericInput.ForeColor = System.Drawing.Color.White;
            this.NumericInput.Location = new System.Drawing.Point(51, 48);
            this.NumericInput.Name = "NumericInput";
            this.NumericInput.Size = new System.Drawing.Size(156, 15);
            this.NumericInput.TabIndex = 0;
            this.NumericInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.NumericInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // ArrowPanel
            // 
            this.ArrowPanel.Controls.Add(this.DownArrow);
            this.ArrowPanel.Controls.Add(this.UpArrow);
            this.ArrowPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ArrowPanel.Location = new System.Drawing.Point(253, 0);
            this.ArrowPanel.Name = "ArrowPanel";
            this.ArrowPanel.Size = new System.Drawing.Size(10, 112);
            this.ArrowPanel.TabIndex = 3;
            // 
            // DownArrow
            // 
            this.DownArrow.BackColor = System.Drawing.Color.Transparent;
            this.DownArrow.BackgroundImage = global::TakeOne.GUI.Properties.Resources.ArrowDown;
            this.DownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DownArrow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownArrow.Location = new System.Drawing.Point(0, 102);
            this.DownArrow.Name = "DownArrow";
            this.DownArrow.Size = new System.Drawing.Size(10, 10);
            this.DownArrow.TabIndex = 2;
            this.DownArrow.TabStop = false;
            this.DownArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.downArrow_MouseDown);
            // 
            // UpArrow
            // 
            this.UpArrow.BackColor = System.Drawing.Color.Transparent;
            this.UpArrow.BackgroundImage = global::TakeOne.GUI.Properties.Resources.ArrowUp;
            this.UpArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpArrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpArrow.Location = new System.Drawing.Point(0, 0);
            this.UpArrow.Name = "UpArrow";
            this.UpArrow.Size = new System.Drawing.Size(10, 10);
            this.UpArrow.TabIndex = 1;
            this.UpArrow.TabStop = false;
            this.UpArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upArrow_MouseDown);
            // 
            // Numeric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumericInput);
            this.Controls.Add(this.ArrowPanel);
            this.Name = "Numeric";
            this.Size = new System.Drawing.Size(263, 112);
            this.Resize += new System.EventHandler(this.Numeric_Resize);
            this.ArrowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DownArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumericInput;
        private System.Windows.Forms.PictureBox UpArrow;
        private System.Windows.Forms.PictureBox DownArrow;
        private System.Windows.Forms.Panel ArrowPanel;
    }
}
