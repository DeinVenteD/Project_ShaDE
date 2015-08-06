using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI.Preferences
{
    public partial class PreferenceSelectionBox : PreferenceItem
    {
        private int Selection = 0;
        public PreferenceSelectionBox(string Label, string Value)
        {
            InitializeComponent();
            string[] Values = Label.Split(';');
            this.PropertyLabel.Text = Values[0];
            this.Selection = Convert.ToInt32(Value);
            int Width = (this.Width - PropertyLabel.Width) / (Values.Length - 1);
            for (int i = 1; i < Values.Length; i++)
            {
                string[] ItemOptions = Values[i].Split('_');
                int NWidth = -1;
                if (ItemOptions.Length > 1)
                {
                    NWidth = Convert.ToInt32(ItemOptions[1]);
                    Values[i] = Values[i].Replace("_" + ItemOptions[1], "");
                }
                Label NewLabel = new Label();
                NewLabel.Text = Values[i];
                NewLabel.ForeColor = Color.Gray;
                if (Selection == i-1) NewLabel.ForeColor = Color.White;
                NewLabel.AutoSize = false;
                NewLabel.Dock = DockStyle.Left;
                NewLabel.TextAlign = ContentAlignment.MiddleCenter;
                NewLabel.Margin = new Padding(0, 0, 0, 0);
                NewLabel.Padding = new Padding(0, 0, 0, 0);
                if(NWidth == -1) NewLabel.Size = new Size(80, NewLabel.Height);
                else NewLabel.Size = new Size(NWidth, NewLabel.Height);
                NewLabel.Tag = i-1;
                NewLabel.Click += new EventHandler(SelectionChange);
                this.Controls.Add(NewLabel);
            }
            this.PropertyLabel.SendToBack();
        }
        private void SelectionChange(object sender, EventArgs e)
        {
            Label CSender = sender as Label;
            this.Controls[Selection].ForeColor = Color.Gray;
            Selection = Convert.ToInt32(CSender.Tag);
            this.Controls[Selection].ForeColor = Color.White;
            base.InvokeChange(Convert.ToInt32(this.Tag), Selection.ToString());
        }
    }
}
