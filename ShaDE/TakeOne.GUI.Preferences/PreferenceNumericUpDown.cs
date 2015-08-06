using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI.Preferences
{
    public partial class PreferenceNumericUpDown : PreferenceItem
    {
        public PreferenceNumericUpDown(string Label, string Value)
        {
            string[] Values = Value.Split('_');
            InitializeComponent();
            this.PropertyLabel.Text = Label;
            if (Values.Length > 1) this.PropertyNumber.MinValue = Convert.ToSingle(Values[1]);
            if (Values.Length > 2) this.PropertyNumber.MaxValue = Convert.ToSingle(Values[2]);
            this.PropertyNumber.Value = Convert.ToSingle(Values[0]);
            this.PropertyLabel.SendToBack();
        }
        private void PropertyNumber_ValueChange()
        {
            base.InvokeChange(Convert.ToInt32(this.Tag), PropertyNumber.Value.ToString());
        }
    }
}
