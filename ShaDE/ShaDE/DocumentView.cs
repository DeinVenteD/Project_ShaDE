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
using Alsing.SourceCode;
using Alsing.Windows.Forms;

namespace ShaDE
{
    public partial class DocumentView : ToolForm
    {
        private bool _FileLoaded = false;
        private SyntaxBoxControl _SyntaxBoxControlInstance;
        private SyntaxDocument _CurrentSyntaxDocument;
        public DocumentView()
        {
            InitializeComponent();
        }
        public void SetText(string Title, string Text)
        {
            this.Text = Title;
            this.Title = Title;
            if(this._FileLoaded) this.Controls.RemoveAt(this.Controls.Count - 1);
            this._FileLoaded = true;
            _CurrentSyntaxDocument = new SyntaxDocument();
            _SyntaxBoxControlInstance = new SyntaxBoxControl();
            if (Title.EndsWith(".cs")) _CurrentSyntaxDocument.SyntaxFile = "SyntaxFiles\\C#.syn";
            else if (Title.EndsWith(".vertex") || Title.EndsWith(".fragment")) _CurrentSyntaxDocument.SyntaxFile = "SyntaxFiles\\GLSL.syn";
            else if (Title.EndsWith(".cpp") || Title.EndsWith(".hpp") || Title.EndsWith(".c") || Title.EndsWith(".h")) _CurrentSyntaxDocument.SyntaxFile = "SyntaxFiles\\C++.syn";
            _CurrentSyntaxDocument.Text = Text;
            _SyntaxBoxControlInstance.Document = _CurrentSyntaxDocument;
            _SyntaxBoxControlInstance.Dock = DockStyle.Fill;
            SyntaxDefinition SyntaxD = _SyntaxBoxControlInstance.Document.Parser.SyntaxDefinition;
            TextStyle[] Styles = SyntaxD.Styles;
            _SyntaxBoxControlInstance.LineNumberBackColor = Color.FromArgb(30,30,30);
            _SyntaxBoxControlInstance.LineNumberBorderColor = Color.FromArgb(30, 30, 30);
            _SyntaxBoxControlInstance.LineNumberForeColor = Color.FromArgb(200,200,200);
            _SyntaxBoxControlInstance.ScrollBars = ScrollBars.None;
            if (Title.EndsWith(".cs"))
            {
                for (int i = 0; i < Styles.Length; i++)
                {
                    if (Styles[i].Name == "CS Code")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.White;
                    }
                    if (Styles[i].Name == "CS Comment")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(255, 50, 80);
                    }
                    if (Styles[i].Name == "CS Datatype")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(60, 70, 255);
                    }
                    if (Styles[i].Name == "CS Keyword")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(120, 140, 255);
                    }
                    if (Styles[i].Name == "CS Number")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.ForestGreen;
                    }
                    if (Styles[i].Name == "CS Operator")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(120, 120, 150);
                    }
                    if (Styles[i].Name == "CS Region")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.DarkGray;
                    }
                    if (Styles[i].Name == "CS Scope")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Gray;
                    }
                    if (Styles[i].Name == "CS String")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Orange;
                    }
                    if (Styles[i].Name == "CS URL")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(50, 60, 120);
                    }
                    if (Styles[i].Name == "CS XML Attrib")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Purple;
                    }
                    if (Styles[i].Name == "CS XML Comment")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Purple;
                    }
                    if (Styles[i].Name == "CS XML String")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Purple;
                    }
                    if (Styles[i].Name == "CS XML Tag")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Purple;
                    }
                    if (Styles[i].Name == "CS XML Tag Text")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Purple;
                    }
                }
            }
            else if (Title.EndsWith(".vertex") || Title.EndsWith(".fragment"))
            {
                for (int i = 0; i < Styles.Length; i++)
                {
                    if (Styles[i].Name == "GLSL Code")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.White;
                    }
                    if (Styles[i].Name == "GLSL Comment")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(255, 50, 80);
                    }
                    if (Styles[i].Name == "GLSL Types")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(60, 70, 255);
                    }
                    if (Styles[i].Name == "GLSL Keywords")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(120, 140, 255);
                    }
                    if (Styles[i].Name == "GLSL Special Variables")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 140);
                        Styles[i].ForeColor = Color.FromArgb(120, 140, 255);
                    }
                    if (Styles[i].Name == "GLSL Math Methods")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 140);
                        Styles[i].ForeColor = Color.FromArgb(120, 140, 255);
                    }
                    if (Styles[i].Name == "GLSL Number")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.ForestGreen;
                    }
                    if (Styles[i].Name == "GLSL Operator")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(120, 120, 150);
                    }
                    if (Styles[i].Name == "GLSL Scope")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Gray;
                    }
                }
            }
            else if (Title.EndsWith(".cpp") || Title.EndsWith(".hpp") || Title.EndsWith(".c") || Title.EndsWith(".h"))
            {
                for (int i = 0; i < Styles.Length; i++)
                {
                    if (Styles[i].Name == "cpp Code")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.White;
                    }
                    if (Styles[i].Name == "cpp Comment")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(255, 50, 80);
                    }
                    if (Styles[i].Name == "cpp Keyword")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(60, 70, 255);
                    }
                    if (Styles[i].Name == "cpp Keyword2")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(120, 140, 255);
                    }
                    if (Styles[i].Name == "cpp Keyword3")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(180, 210, 255);
                    }
                    if (Styles[i].Name == "cpp Number")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.ForestGreen;
                    }
                    if (Styles[i].Name == "cpp Operator")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(120, 120, 150);
                    }
                    if (Styles[i].Name == "cpp Region")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.DarkGray;
                    }
                    if (Styles[i].Name == "cpp Scope")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Gray;
                    }
                    if (Styles[i].Name == "cpp String")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Orange;
                    }
                    if (Styles[i].Name == "cpp URL")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.FromArgb(50, 60, 120);
                    }
                    if (Styles[i].Name == "cpp XML Attrib")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Purple;
                    }
                    if (Styles[i].Name == "cpp XML Comment")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Purple;
                    }
                    if (Styles[i].Name == "cpp XML String")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Purple;
                    }
                    if (Styles[i].Name == "cpp XML Tag")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Purple;
                    }
                    if (Styles[i].Name == "cpp XML Tag Text")
                    {
                        Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                        Styles[i].ForeColor = Color.Purple;
                    }
                }
            }
            else
            {
                for (int i = 0; i < Styles.Length; i++)
                {
                    Styles[i].BackColor = Color.FromArgb(40, 40, 40);
                    Styles[i].ForeColor = Color.White;
                }
            }
            this.ContentPanel.Controls.Add(_SyntaxBoxControlInstance);
        }
    }
}
