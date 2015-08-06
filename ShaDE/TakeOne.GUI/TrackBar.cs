using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace TakeOne.GUI
{
    public delegate void TracklineEventHandler();
    public partial class TrackBar : UserControl
    {
        private bool ShowSelectors;
        private int Value_Value;
        private int _MinValue;

        public int MinValue
        {
            get { return _MinValue; }
            set { _MinValue = value; }
        }
        private int _MaxValue;

        public int MaxValue
        {
            get { return _MaxValue; }
            set { _MaxValue = value; }
        }
        private bool Move;
        private int StartX;
        private int CurrentX;
        public int Value
        {
            get { return this.Value_Value; }
            set 
            {
                if (value > MaxValue) this.Value_Value = MinValue;
                else if (value < MinValue) this.Value_Value = MaxValue;
                else this.Value_Value = value;
                RedrawPosition();
            }
        }
        public event TracklineEventHandler ValueChange;
        public TrackBar()
        {
            InitializeComponent();
            MinValue = 0;
            MaxValue = 100;
        }       
        public void SetBound(int MinValue, int MaxValue)
        {
            this.MinValue = MinValue;
            this.MaxValue = MaxValue;
            this.Value = MinValue;
        }
        private void RedrawPosition()
        {
            Point NewPosition = new Point(10 + (int)(((Value_Value - MinValue) * 1.0 / (MaxValue - MinValue)) * (Bar.Width-20)), Pointer.Location.Y);
            if (NewPosition.X > this.Width - 20) NewPosition.X = this.Width - 20;
            Pointer.Location = NewPosition;
        }
        private void Pointer_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs e1 = new MouseEventArgs(e.Button, e.Clicks, e.X + Pointer.Location.X, e.Y + Pointer.Location.Y, e.Delta);
            Trackline_MouseDown(sender, e1);
        }
        private void Pointer_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs e1 = new MouseEventArgs(e.Button, e.Clicks, e.X + Pointer.Location.X, e.Y + Pointer.Location.Y, e.Delta);
            Trackline_MouseMove(sender, e1);
        }
        private void Pointer_MouseUp(object sender, MouseEventArgs e)
        {
            MouseEventArgs e1 = new MouseEventArgs(e.Button, e.Clicks, e.X + Pointer.Location.X, e.Y + Pointer.Location.Y, e.Delta);
            Trackline_MouseUp(sender, e1);
        }
        private void Bar_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void Bar_MouseUp(object sender, MouseEventArgs e)
        {
            MouseEventArgs e1 = new MouseEventArgs(e.Button, e.Clicks, e.X, e.Y, e.Delta);
            Trackline_MouseUp(sender, e1);
        }
        private void Bar_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs e1 = new MouseEventArgs(e.Button, e.Clicks, e.X, e.Y, e.Delta);
            Trackline_MouseMove(sender, e);
        }
        private void Trackline_MouseDown(object sender, MouseEventArgs e)
        {
            Move = true;
            this.Capture = true;
            StartX = e.X;
        }
        private void Trackline_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move)
            {
                if (Pointer.Location.X + (e.X - CurrentX) < 10) Pointer.Location = new Point(10, Pointer.Location.Y);
                else if (Pointer.Location.X + (e.X - CurrentX) > this.Width - 30) Pointer.Location = new Point(this.Width - 30, Pointer.Location.Y);
                else Pointer.Location = new Point(Pointer.Location.X + (e.X - CurrentX), Pointer.Location.Y);
                this.Value_Value = (int)(MinValue + (((Pointer.Location.X) * 1.0) / (Bar.Width-10)) * (MaxValue - MinValue));
                if (Pointer.Location.X == 10) this.Value_Value = this.MinValue;
                ValueChange.Invoke();
            }
            if (e.X > 10 && e.X < this.Width-10) CurrentX = e.X; 
        }
        private void Trackline_MouseUp(object sender, MouseEventArgs e)
        {
            Move = false;
            this.Capture = false;
        }
        private void Trackline_Resize(object sender, EventArgs e)
        {
            RedrawPosition();
        }
    }
}
