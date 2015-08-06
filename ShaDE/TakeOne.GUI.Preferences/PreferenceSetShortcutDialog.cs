using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI.Preferences
{
    public partial class PreferenceSetShortcutDialog : PreferenceItem
    {
        private string[] Values;
        public PreferenceSetShortcutDialog(string Label, string Value)
        {
            InitializeComponent();
            this.PropertyLabel.Text = Label;
            string[] Values = Value.Split('_');
            this.Values = Values;
            GenerateDisplay();
        }
        private void GenerateDisplay()
        {
            string NValue = "";
            for (int i = 0; i < Values.Length; i++)
            {
                if (i > 0) NValue += " + ";
                NValue += Values[i];
            }
            this.PropertyShow.Text = NValue;
        }
        private void PropertyShow_Click(object sender, EventArgs e)
        {
            EnterKeyDialog Dialog = new EnterKeyDialog();
            if (Dialog.ShowDialog() == DialogResult.OK && Dialog.Values.Count > 0)
            {
                Values = Dialog.Values.ToArray();
                GenerateDisplay();
                string NValue = "";
                for (int i = 0; i < Values.Length; i++)
                {
                    if (i > 0) NValue += "_";
                    NValue += Values[i];
                }
                base.InvokeChange(Convert.ToInt32(this.Tag), NValue);
            }
        }
    }
}
