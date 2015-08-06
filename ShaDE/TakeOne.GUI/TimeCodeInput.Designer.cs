namespace TakeOne.GUI
{
    partial class TimeCodeInput
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
            this.InputSF = new TakeOne.GUI.Numeric();
            this.InputF = new TakeOne.GUI.Numeric();
            this.InputS = new TakeOne.GUI.Numeric();
            this.InputM = new TakeOne.GUI.Numeric();
            this.InputH = new TakeOne.GUI.Numeric();
            this.SuspendLayout();
            // 
            // InputSF
            // 
            this.InputSF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.InputSF.DecimalNum = 0;
            this.InputSF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputSF.FormatValue = true;
            this.InputSF.Location = new System.Drawing.Point(376, 0);
            this.InputSF.MaxValue = 10000F;
            this.InputSF.MinValue = 0F;
            this.InputSF.Name = "InputSF";
            this.InputSF.Size = new System.Drawing.Size(107, 65);
            this.InputSF.TabIndex = 4;
            this.InputSF.Value = 0F;
            this.InputSF.ValueChange += new TakeOne.GUI.NumericEventHandler(this.ValueUpdated);
            // 
            // InputF
            // 
            this.InputF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InputF.DecimalNum = 0;
            this.InputF.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputF.FormatValue = true;
            this.InputF.Location = new System.Drawing.Point(282, 0);
            this.InputF.MaxValue = 29F;
            this.InputF.MinValue = 0F;
            this.InputF.Name = "InputF";
            this.InputF.Size = new System.Drawing.Size(94, 65);
            this.InputF.TabIndex = 3;
            this.InputF.Value = 0F;
            this.InputF.ValueChange += new TakeOne.GUI.NumericEventHandler(this.ValueUpdated);
            // 
            // InputS
            // 
            this.InputS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InputS.DecimalNum = 0;
            this.InputS.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputS.FormatValue = true;
            this.InputS.Location = new System.Drawing.Point(188, 0);
            this.InputS.MaxValue = 59F;
            this.InputS.MinValue = 0F;
            this.InputS.Name = "InputS";
            this.InputS.Size = new System.Drawing.Size(94, 65);
            this.InputS.TabIndex = 2;
            this.InputS.Value = 0F;
            this.InputS.ValueChange += new TakeOne.GUI.NumericEventHandler(this.ValueUpdated);
            // 
            // InputM
            // 
            this.InputM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InputM.DecimalNum = 0;
            this.InputM.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputM.FormatValue = true;
            this.InputM.Location = new System.Drawing.Point(94, 0);
            this.InputM.MaxValue = 59F;
            this.InputM.MinValue = 0F;
            this.InputM.Name = "InputM";
            this.InputM.Size = new System.Drawing.Size(94, 65);
            this.InputM.TabIndex = 1;
            this.InputM.Value = 0F;
            this.InputM.ValueChange += new TakeOne.GUI.NumericEventHandler(this.ValueUpdated);
            // 
            // InputH
            // 
            this.InputH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InputH.DecimalNum = 0;
            this.InputH.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputH.FormatValue = true;
            this.InputH.Location = new System.Drawing.Point(0, 0);
            this.InputH.MaxValue = 1000F;
            this.InputH.MinValue = 0F;
            this.InputH.Name = "InputH";
            this.InputH.Size = new System.Drawing.Size(94, 65);
            this.InputH.TabIndex = 0;
            this.InputH.Value = 0F;
            this.InputH.ValueChange += new TakeOne.GUI.NumericEventHandler(this.ValueUpdated);
            // 
            // TimeCodeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InputSF);
            this.Controls.Add(this.InputF);
            this.Controls.Add(this.InputS);
            this.Controls.Add(this.InputM);
            this.Controls.Add(this.InputH);
            this.Name = "TimeCodeInput";
            this.Size = new System.Drawing.Size(483, 65);
            this.Resize += new System.EventHandler(this.TimeCodeInput_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Numeric InputH;
        private Numeric InputM;
        private Numeric InputS;
        private Numeric InputF;
        private Numeric InputSF;
    }
}
