using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI.Preferences
{
    public partial class PreferenceTrackbar : PreferenceItem
    {
        private bool RefreshFlag = false;
        public PreferenceTrackbar(string Label, string Value)
        {
            string[] Values = Value.Split('_');
            InitializeComponent();
            this.PropertyLabel.Text = Label;
            if (Values.Length > 1)
            {
                this.PropertySlide.MinValue = Convert.ToInt32(Values[1]);
                this.PropertyNumber.MinValue = Convert.ToSingle(Values[1]);
            }
            if (Values.Length > 2)
            {
                this.PropertySlide.MaxValue = Convert.ToInt32(Values[2]);
                this.PropertyNumber.MaxValue = Convert.ToSingle(Values[2]);
            }
            this.PropertySlide.Value = Convert.ToInt32(Values[0]);
            this.PropertyNumber.Value = Convert.ToSingle(Values[0]);
        }
        private void PropertyNumber_ValueChange()
        {
            if (RefreshFlag) return;
            RefreshFlag = true;
            PropertySlide.Value = Convert.ToInt32(PropertyNumber.Value);
            base.InvokeChange(Convert.ToInt32(this.Tag), PropertySlide.Value.ToString());
            RefreshFlag = false;
        }
        private void PropertySlide_ValueChange()
        {
            if (RefreshFlag) return;
            RefreshFlag = true;
            PropertyNumber.Value = PropertySlide.Value;
            base.InvokeChange(Convert.ToInt32(this.Tag), PropertySlide.Value.ToString());
            RefreshFlag = false;
        }
    }
}
