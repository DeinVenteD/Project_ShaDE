using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI
{
    public delegate void ValueChange(bool value);
        
    public partial class CustomPictureBox : PictureBox
    {
        public event ValueChange Change;
        private bool valueChecked;

        public bool Checked
        {
            get 
            { 
                return valueChecked; 
            }
            set 
            {
                valueChecked = value;
                this.Change.Invoke(valueChecked);
            }
        }
        public CustomPictureBox()
        {
            InitializeComponent();
            OnValueChanged(false);
            this.BackColor = Color.FromArgb(64,64,64);
            this.BackgroundImageLayout = ImageLayout.Center;
            this.Size = new System.Drawing.Size(30, 30);
            valueChecked = false;
            this.Click += new EventHandler(OnClicke);
            this.Change = new ValueChange(OnValueChanged);
        }

        private void OnValueChanged(bool value)
        {
            if (value)
            {
                this.BackgroundImage = global::TakeOne.GUI.Properties.Resources.CheckboxChecked;
            }
            else this.BackgroundImage = global::TakeOne.GUI.Properties.Resources.Checkbox;
            
        }
        private void OnClicke(object sender, EventArgs e)
        {
            this.Checked = !this.Checked;
        }
    }
}
