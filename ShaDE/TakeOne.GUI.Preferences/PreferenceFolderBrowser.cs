using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI.Preferences
{
    public partial class PreferenceFolderBrowser : PreferenceItem
    {
        public PreferenceFolderBrowser(string Label, string Value)
        {
            InitializeComponent();
            this.PropertyLabel.Text = Label;
            this.PropertyRoot.Text = Value;
        }
        private void PropertyRoot_TextChanged(object sender, EventArgs e)
        {
            base.InvokeChange(Convert.ToInt32(this.Tag), PropertyRoot.Text);
        }
        private void PropertyFindRoot_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialog = new FolderBrowserDialog();
            Dialog.ShowNewFolderButton = true;
            DialogResult Result = Dialog.ShowDialog();
            if (Result == DialogResult.OK) PropertyRoot.Text = Dialog.SelectedPath;
        }
    }
}
