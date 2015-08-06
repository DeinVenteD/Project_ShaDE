using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI.Preferences
{
    public partial class PreferenceCheckBox : PreferenceItem
    {
        public PreferenceCheckBox(string Label, string Value)
        {
            InitializeComponent();
            this.PropertyLabel.Text = Label;
            this.PropertyCheck.Checked = Convert.ToBoolean(Value);
        }
        private void PropertyCheck_Change(bool value)
        {
            base.InvokeChange(Convert.ToInt32(this.Tag), PropertyCheck.Checked.ToString());
        }
    }
}
