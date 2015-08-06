using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI.Preferences
{
    public partial class PreferenceTextBox : PreferenceItem
    {
        public PreferenceTextBox(string Label, string Value)
        {
            InitializeComponent();
            this.PropertyLabel.Text = Label;
            this.PropertyRoot.Text = Value;
        }
        private void PropertyRoot_TextChanged(object sender, EventArgs e)
        {
            base.InvokeChange(Convert.ToInt32(this.Tag), PropertyRoot.Text);
        }
    }
}
