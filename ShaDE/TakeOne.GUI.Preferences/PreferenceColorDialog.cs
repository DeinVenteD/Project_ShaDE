using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI.Preferences
{
    public partial class PreferenceColorDialog : PreferenceItem
    {
        public PreferenceColorDialog(string Label, string Value)
        {
            string[] Values = Value.Split('_');
            InitializeComponent();
            this.PropertyLabel.Text = Label;
            if (Values.Length == 3) ColorValue.BackColor = Color.FromArgb(Convert.ToInt32(Values[0]), Convert.ToInt32(Values[1]), Convert.ToInt32(Values[2]));
        }
        private void ColorValue_Click(object sender, EventArgs e)
        {
            ColorDialog Dialog = new ColorDialog();
            Dialog.AllowFullOpen = true;
            Dialog.AnyColor = true;
            Dialog.Color = ColorValue.BackColor;
            Dialog.SolidColorOnly = true;
            if (Dialog.ShowDialog() == DialogResult.OK) ColorValue.BackColor = Dialog.Color;
            base.InvokeChange(Convert.ToInt32(this.Tag), ColorValue.BackColor.R.ToString() + "_" + ColorValue.BackColor.G.ToString() + "_" + ColorValue.BackColor.B.ToString());
        }
    }
}
