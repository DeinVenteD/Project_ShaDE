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
    public partial class ErrorDisplay : ToolForm
    {
        public ErrorDisplay()
        {
            InitializeComponent();
            this.SetTitle("Error");
            ErrorText.Text = "";
        }
        public ErrorDisplay(string Header, string Text)
        {
            InitializeComponent();
            this.SetTitle(Header);
            ErrorText.Text = Text;
        }
    }
}
