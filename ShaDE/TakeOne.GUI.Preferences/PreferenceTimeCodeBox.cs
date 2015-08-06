using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI.Preferences
{
    public partial class PreferenceTimeCodeBox : PreferenceItem
    {
        public PreferenceTimeCodeBox(string Label, string Value)
        {
            InitializeComponent();
            this.PropertyLabel.Text = Label;
            this.PropertyLabel.SendToBack();
            this.TimeCodeValue.ValueChange += new TimeCodeInputEvent(TimeCodeValue_ValueChange);
        }
        private void TimeCodeValue_ValueChange(string Value)
        {
            base.InvokeChange(Convert.ToInt32(this.Tag), Value);
        }
    }
}
