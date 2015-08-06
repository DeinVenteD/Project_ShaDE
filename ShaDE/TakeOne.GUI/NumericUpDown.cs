using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI
{
    public delegate void NumericEventHandler();
    public partial class Numeric : UserControl
    {
        private bool _FormatValue = false;

        public bool FormatValue
        {
            get { return _FormatValue; }
            set { _FormatValue = value; }
        }
        private bool ColorCheck = true;
        private float Value_Value;
        private float _MinValue;
        private float _MaxValue;
        private int _DecimalNum;
        public int DecimalNum
        {
            get { return _DecimalNum; }
            set { _DecimalNum = value; }
        }
        public float Value
        {
            get { return this.Value_Value; }
            set
            {
                if (value > MaxValue) this.Value_Value = MaxValue;
                else if (value < MinValue) this.Value_Value = MinValue;
                else this.Value_Value = value;

                if (ValueChange != null)
                    ValueChange.Invoke();

                if (FormatValue && DecimalNum == 0) this.NumericInput.Text = this.Value.ToString("00");
                else this.NumericInput.Text = this.Value.ToString();
            }
        }
        public float MinValue
        {
            get { return _MinValue; }
            set 
            { 
                _MinValue = value;
                if (Value_Value < MinValue) this.Value_Value = MinValue;
            }
        }
        public float MaxValue
        {
            get { return _MaxValue; }
            set 
            { 
                _MaxValue = value;
                if (Value_Value > MaxValue) this.Value_Value = MaxValue;
            }
        }
        public event NumericEventHandler ValueChange;
        public Numeric()
        {
            InitializeComponent();
            MinValue = -10000;
            MaxValue = 10000;
            Value = 0;
            DecimalNum = 2;
            if (FormatValue && DecimalNum == 0) this.NumericInput.Text = "00";
            else this.NumericInput.Text = "0";
            ValueChange = new NumericEventHandler(OnValueChange);
        }
        private void OnValueChange()
        {
            if (ColorCheck)
            {
                this.NumericInput.BackColor = this.BackColor;
                ColorCheck = false;
            }
        }
        public void SetDecimalNum(int num)
        {
            this.DecimalNum = num;
            CheckDecimal();
        }
        private void upArrow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Value++;
                if (FormatValue && DecimalNum == 0) this.NumericInput.Text = this.Value.ToString("00");
                else this.NumericInput.Text = this.Value.ToString();
            }
        }
        private void downArrow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Value--;
                if (FormatValue && DecimalNum == 0) this.NumericInput.Text = this.Value.ToString("00");
                else this.NumericInput.Text = this.Value.ToString();
            }
        }
        public void CheckDecimal()
        {
            string[] num = this.NumericInput.Text.Split('.');
            if (num.Length == 2 && num[1].Length > DecimalNum)
            {
                num[1] = num[1].Substring(0, DecimalNum);

                this.NumericInput.Text = num[0] + "." + num[1];
                float.TryParse(this.NumericInput.Text, out Value_Value);
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }
        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode == Keys.OemPeriod))
            {
                float newValue;

                if (float.TryParse(this.NumericInput.Text, out newValue))
                {
                    if (newValue < MinValue)
                        newValue = MinValue;
                    else if (newValue > MaxValue)
                        newValue = MaxValue;

                    this.Value = newValue;
                    this.NumericInput.Text = this.Value + "";
                }
                CheckDecimal();
            }
            else
            {
                string[] num = this.NumericInput.Text.Split('.');
                if (num.Length > 2)
                {
                    this.NumericInput.Text = num[0] + "." + num[1];
                    float.TryParse(this.NumericInput.Text, out Value_Value);
                }
            }
        }

        private void Numeric_Resize(object sender, EventArgs e)
        {
            NumericInput.Location = new Point(0,this.Height / 2 - NumericInput.Height / 2);
            NumericInput.Size = new Size(this.Width - ArrowPanel.Width, NumericInput.Height);
        }
    }
}
