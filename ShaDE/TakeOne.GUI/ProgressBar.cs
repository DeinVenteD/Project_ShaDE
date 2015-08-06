using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI
{
    public partial class ProgressBar : UserControl
    {
        private int Value_Value;
        private int Value_MinValue;
        private int Value_MaxValue;
        public int Value
        {
            get { return this.Value_Value; }
            set 
            {
                if (value < this.MinValue) this.Value_Value = this.MinValue;
                else if (value > this.MaxValue) this.Value_Value = this.MaxValue;
                else this.Value_Value = value;
                this.Progress.Width = (int)((this.Value_Value * 1.0 / this.Value_MaxValue) * this.Width);
            }
        }
        public int MinValue
        {
            get { return this.Value_MinValue; }
            set { this.Value_MinValue = value; }
        }
        public int MaxValue
        {
            get { return this.Value_MaxValue; }
            set { this.Value_MaxValue = value; }
        }
        public ProgressBar()
        {
            InitializeComponent();
        }
    }
}
