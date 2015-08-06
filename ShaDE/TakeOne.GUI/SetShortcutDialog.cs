using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI
{
    public partial class EnterKeyDialog : Form
    {
        public List<string> Values;
        public EnterKeyDialog()
        {
            InitializeComponent();
            Values = new List<string>();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys Key)
        {
            if (Values.Count > 4) return true;
            string[] SubValues = Key.ToString().Split(',');
            if(!Values.Contains(SubValues[SubValues.Length-1].Trim())) Values.Add(SubValues[SubValues.Length-1].Trim());
            GenerateDisplay();
            return true;
        }
        private void GenerateDisplay()
        {
            string NValue = "";
            for (int i = 0; i < Values.Count; i++)
            {
                if (i > 0) NValue += " + ";
                NValue += Values[i];
            }
            KeysText.Text = NValue;
        }
        private void ResultOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Values.Count; i++)
            {
                string[] SubValues = Values[i].Split(',');
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        private void ResultCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
