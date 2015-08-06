using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI.Preferences
{
    public partial class PreferenceItem : UserControl
    {
        public event ValueChangeHandler ValueChange;
        public PreferenceItem()
        {
            InitializeComponent();
        }
        public PreferenceItem(string Label, string Value)
        {
            InitializeComponent();
            this.PropertyLabel.Text = Label;
            this.ValueChange = new ValueChangeHandler(OnValueChange);
        }
        public virtual void OnValueChange(int Index, string Value)
        {
        }
        protected void InvokeChange(int Index, string Value)
        {
            if (this.ValueChange != null) this.ValueChange.Invoke(Index, Value);
        }
    }
}
