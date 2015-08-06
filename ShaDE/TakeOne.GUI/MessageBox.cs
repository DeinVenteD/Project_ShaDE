using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TakeOne.WindowSuite;

namespace TakeOne.GUI
{
    public partial class MessageDisplay : ToolForm
    {
        public MessageDisplay(string Text)
        {
            InitializeComponent();
            MessageLabel.Text = Text;
        }
        public MessageDisplay(string Text, string Title)
        {
            InitializeComponent();
            MessageLabel.Text = Text;
            this.Title = Title;
            this.CalculateSize(Text);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CalculateSize(string Text)
        {
            int FWidth = System.Windows.Forms.TextRenderer.MeasureText(Text, MessageLabel.Font).Width;
            int FHeight = System.Windows.Forms.TextRenderer.MeasureText(Text, MessageLabel.Font).Height;
            if (FWidth < 200) FWidth = 200;
            if (FHeight < 100) FHeight = 100;
            this.Size = new Size(FWidth + 20 + 10, FHeight + 20 + 72);
            this.OK.Location = new Point(MessageLabel.Width / 2 - OK.Width / 2, OK.Location.Y);
        }
    }
}
