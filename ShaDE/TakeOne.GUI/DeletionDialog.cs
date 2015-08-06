using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TakeOne.WindowSuite;

namespace TakeOne.GUI
{
    public partial class DeletionDialog : ToolForm
    {
        private int _ResultIndex;
        private bool _DontAsk;
        public int ResultIndex
        {
            get { return _ResultIndex; }
            set { _ResultIndex = value; }
        }
        public bool DontAsk
        {
            get { return _DontAsk; }
            set { _DontAsk = value; }
        }
        public DeletionDialog()
        {
            InitializeComponent();
        }

        private void DeleteFileEntries_Click(object sender, EventArgs e)
        {
            _DontAsk = DontAskCheck.Checked;
            ResultIndex = 0;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void DeleteScriptEntries_Click(object sender, EventArgs e)
        {
            _DontAsk = DontAskCheck.Checked;
            ResultIndex = 1;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
