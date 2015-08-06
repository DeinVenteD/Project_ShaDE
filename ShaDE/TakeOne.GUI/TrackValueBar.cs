using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI
{
    public partial class TrackValueBar : UserControl
    {
        public TrackBar TrackControl
        {
            get { return this.Track; }
        }
        public TrackValueBar()
        {
            InitializeComponent();
        }
        private void Track_ValueChange()
        {
            this.CurrentValueLabel.Text = Track.Value.ToString();
        }
        public void SetBound(int MinValue, int MaxValue)
        {
            MinValueLabel.Text = MinValue.ToString();
            MaxValueLabel.Text = MaxValue.ToString();
            CurrentValueLabel.Text = MinValue.ToString();
            Track.SetBound(MinValue, MaxValue);
        }
        public void SetValue(int newValue)
        {
            CurrentValueLabel.Text = newValue.ToString();
        }
        private void Trackbar_Resize(object sender, EventArgs e)
        {
            CurrentValueLabel.Location = new Point(this.Width / 2 - 50, CurrentValueLabel.Location.Y);
        }
    }
}
