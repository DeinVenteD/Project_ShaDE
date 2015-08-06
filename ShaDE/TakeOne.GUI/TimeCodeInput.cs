using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeOne.GUI
{
    public delegate void TimeCodeInputEvent(string Value);
    public partial class TimeCodeInput : UserControl
    {
        public TimeCodeInputEvent ValueChange;
        public TimeCodeInput()
        {
            InitializeComponent();
            ValueChange = new TimeCodeInputEvent(OnValueChange);
        }
        private void OnValueChange(string Value)
        {
        }
        private void TimeCodeInput_Resize(object sender, EventArgs e)
        {
            InputH.Width = this.Width / 5;
            InputM.Width = this.Width / 5;
            InputS.Width = this.Width / 5;
            InputF.Width = this.Width / 5;
        }
        private void ValueUpdated()
        {
            string NewValue = InputH.Value.ToString("00") + ":";
            NewValue += InputM.Value.ToString("00") + ":";
            NewValue += InputS.Value.ToString("00") + ":";
            NewValue += InputF.Value.ToString("00");
            if (InputSF.Value > 0) NewValue += "(" + InputSF.Value.ToString("00") + ")";
            ValueChange.Invoke(NewValue);
        }
    }
}
