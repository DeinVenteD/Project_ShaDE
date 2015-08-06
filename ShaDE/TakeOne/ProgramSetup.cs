using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;

namespace TakeOne
{
    public delegate void PreferenceChanged();
    public class ProgramSetup
    {
        private static void OnChange() { }
        public static event PreferenceChanged Changed = new PreferenceChanged(OnChange);
        public static class Input
        {
            private static bool _MemoryCompressUnnamed = false;
            private static bool _ForceBruteStream = true;
            private static bool _ForceSmartStream = false;
            private static bool _RecursiveOpenFolder = false;
            private static string[] _SupportedFileFormats = new string[5] { "C3D", "CAP", "TRC", "TRB", "TOM" };
            private static List<string> _AdditionalFileFormats = new List<string>();
            public static bool MemoryCompressUnnamed
            {
                get { return Input._MemoryCompressUnnamed; }
                set { Input._MemoryCompressUnnamed = value; Changed.Invoke(); }
            }
            public static bool ForceBruteStream
            {
                get { return Input._ForceBruteStream; }
                set 
                { 
                    Input._ForceBruteStream = value;
                    Input._ForceSmartStream = !value; 
                    Changed.Invoke(); 
                }
            }
            public static bool ForceSmartStream
            {
                get { return Input._ForceSmartStream; }
                set
                {
                    Input._ForceBruteStream = !value;
                    Input._ForceSmartStream = value;
                    Changed.Invoke();
                }
            }
            public static bool RecursiveOpenFolder
            {
                get { return Input._RecursiveOpenFolder; }
                set { Input._RecursiveOpenFolder = value; }
            }
            public static string[] SupportedFileFormats
            {
                get { return Input._SupportedFileFormats; }
                set { Input._SupportedFileFormats = value; }
            }
            public static List<string> AdditionalFileFormats
            {
                get { return Input._AdditionalFileFormats; }
                set { Input._AdditionalFileFormats = value; }
            }
        }
        public static class Output
        {
            private static string _FileRoot = "C:\\";
            private static bool _SubFolder = false;
            private static bool _Overwrite = false;
            private static string _FileType = "Original";
            private static bool _TOM_WriteCompressUnnamed = false;
            private static bool _CAP_WriteCompressUnnamed = true;
            private static bool _TRC_WriteCompressUnnamed = false;
            private static int _AxisUp = 0;
            private static string[] _SupportedFileFormats = new string[5] { "C3D", "CAP", "TRC", "TRB", "TOM" };
            private static List<string> _AdditionalFileFormats = new List<string>();
            public static string FileRoot
            {
                get { Changed.Invoke(); return Output._FileRoot; }
                set
                {
                    Output._FileRoot = value;
                    FileRootChanged = true;
                    Changed.Invoke();
                }
            }
            public static bool SubFolder
            {
                get { return Output._SubFolder; }
                set { Output._SubFolder = value; Changed.Invoke(); }
            }
            public static bool Overwrite
            {
                get { return Output._Overwrite; }
                set { Output._Overwrite = value; Changed.Invoke(); }
            }
            public static string FileType
            {
                get { return Output._FileType; }
                set { Output._FileType = value; Changed.Invoke(); }
            }
            public static bool TOM_WriteCompressUnnamed
            {
                get { return Output._TOM_WriteCompressUnnamed; }
                set { Output._TOM_WriteCompressUnnamed = value; Changed.Invoke(); }
            }
            public static bool CAP_WriteCompressUnnamed
            {
                get { return Output._CAP_WriteCompressUnnamed; }
                set { Output._CAP_WriteCompressUnnamed = value; }
            }
            public static bool TRC_WriteCompressUnnamed
            {
                get { return Output._TRC_WriteCompressUnnamed; }
                set { Output._TRC_WriteCompressUnnamed = value; Changed.Invoke(); }
            }
            public static int AxisUp
            {
                get { return Output._AxisUp; }
                set { Output._AxisUp = value; Changed.Invoke(); }
            }
            public static char MarkerSetPrefixSeparator = ':';
            public static string[] SupportedFileFormats
            {
                get { return Output._SupportedFileFormats; }
                set { Output._SupportedFileFormats = value; }
            }
            public static List<string> AdditionalFileFormats
            {
                get { return Output._AdditionalFileFormats; }
                set { Output._AdditionalFileFormats = value; }
            }
            //Hidden
            public static void SetFileRootNonInvoke(string Value)
            {
                _FileRoot = Value;
            }
            public static bool FileRootChanged = false;
            public static bool IgnoreFileType = false;
        }
        public static class Drawing
        {
            private static bool _DrawUnnamed = true;
            private static int _MarkerDrawSize = 10;
            private static int _MarkerDrawSmoothnes = 8;
            private static System.Drawing.Color _NamedMarkerColor = System.Drawing.Color.FromArgb(241, 101, 33);
            private static System.Drawing.Color _NamedMarkerColorSelected = System.Drawing.Color.FromArgb(51, 153, 255);
            private static System.Drawing.Color _UnnamedMarkerColor = System.Drawing.Color.Gray;
            private static System.Drawing.Color _UnnamedMarkerColorSelected = System.Drawing.Color.LightBlue;
            private static bool _DrawGrid = true;
            private static bool _DrawAxis = true;
            private static System.Drawing.Color _BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            private static System.Drawing.Color _GridColor = System.Drawing.Color.FromArgb(82, 82, 82);
            private static bool _OptimizeUnnamedDraw = true;
            public static bool DrawUnnamed
            {
                get { return Drawing._DrawUnnamed; }
                set { Drawing._DrawUnnamed = value; Changed.Invoke(); }
            }
            public static int MarkerDrawSize
            {
                get { return Drawing._MarkerDrawSize; }
                set { Drawing._MarkerDrawSize = value; Changed.Invoke(); }
            }
            public static int MarkerDrawSmoothnes
            {
                get { return Drawing._MarkerDrawSmoothnes; }
                set { Drawing._MarkerDrawSmoothnes = value; Changed.Invoke(); }
            }
            public static System.Drawing.Color NamedMarkerColor
            {
                get { return Drawing._NamedMarkerColor; }
                set { Drawing._NamedMarkerColor = value; Changed.Invoke(); }
            }
            public static System.Drawing.Color NamedMarkerColorSelected
            {
                get { return Drawing._NamedMarkerColorSelected; }
                set { Drawing._NamedMarkerColorSelected = value; Changed.Invoke(); }
            }
            public static System.Drawing.Color UnnamedMarkerColor
            {
                get { return Drawing._UnnamedMarkerColor; }
                set { Drawing._UnnamedMarkerColor = value; Changed.Invoke(); }
            }
            public static System.Drawing.Color UnnamedMarkerColorSelected
            {
                get { return Drawing._UnnamedMarkerColorSelected; }
                set { Drawing._UnnamedMarkerColorSelected = value; Changed.Invoke(); }
            }
            public static bool DrawGrid
            {
                get { return Drawing._DrawGrid; }
                set { Drawing._DrawGrid = value; Changed.Invoke(); }
            }
            public static bool DrawAxis
            {
                get { return Drawing._DrawAxis; }
                set { Drawing._DrawAxis = value; Changed.Invoke(); }
            }
            public static System.Drawing.Color BackColor
            {
                get { return Drawing._BackColor; }
                set { Drawing._BackColor = value; Changed.Invoke(); }
            }
            public static System.Drawing.Color GridColor
            {
                get { return Drawing._GridColor; }
                set { Drawing._GridColor = value; Changed.Invoke(); }
            }
            public static bool OptimizeUnnamedDraw
            {
                get { return Drawing._OptimizeUnnamedDraw; }
                set { Drawing._OptimizeUnnamedDraw = value; }
            }
        }
        public static class Script
        {
            private static bool _ShowLog = true;
            private static bool _WriteLog = true;
            private static bool _BasicScript = true;
            private static bool _TimeCodeStartZero = false;
            public static bool WriteLog
            {
                get { return Script._WriteLog; }
                set { Script._WriteLog = value; Changed.Invoke(); }
            }
            public static bool ShowLog
            {
                get { return Script._ShowLog; }
                set { Script._ShowLog = value; Changed.Invoke(); }
            }
            public static bool BasicScript
            {
                get { return Script._BasicScript; }
                set { Script._BasicScript = value; Changed.Invoke(); }
            }
            public static bool TimeCodeStartZero
            {
                get { return Script._TimeCodeStartZero; }
                set { Script._TimeCodeStartZero = value; }
            }
        }
        public static class Layout
        {
        }
        public static class Shortcuts
        {
            public static string[] PausePlay = new string[1] { "Space" };
            public static string[] PrevFrame = new string[1] { "S" };
            public static string[] NextFrame = new string[1] { "F" };
            public static string[] BeginFrame = new string[1] { "Home" };
            public static string[] EndFrame = new string[1] { "End" };
            public static string[] FocusSelection = new string[1] { "Q" };
            public static string[] FollowSelection = new string[1] { "W" };
            public static string[] OpenFiles = new string[2] { "Control", "O" };
            public static string[] OpenFolder = new string[3] { "Control", "Shift", "O" };
            public static string[] Save = new string[2] { "Control", "S" };
            public static string[] SaveAs = new string[3] { "Control", "Shift", "S" };
            public static string[] Show_Player = new string[2] { "Control", "D1" };
            public static string[] Show_Browser = new string[2] { "Control", "D2" };
            public static string[] Show_Output = new string[2] { "Control", "D3" };
            public static string[] Show_Script = new string[2] { "Control", "D4" };
            public static string[] Show_Data = new string[2] { "Control", "D5" };
            public static string[] Show_Preferences = new string[2] { "Control", "D6" };
            public static string[] Show_Toolbar = new string[2] { "Control", "T" };
            public static string[] SaveScript = new string[3] { "Control", "Alt", "S" };
            public static string[] LoadScript = new string[3] { "Control", "Alt", "L" };
            public static string[] SelectAll = new string[2] { "Control", "A" };
            public static string[] RemoveItems = new string[1] { "Delete" };
        }
        public static class Current
        {
            public static bool MDIChildKeypress = false;
            public static bool DeleteAutomatic = false;
            public static int DeleteIndex = 0;
        }
        public static void LoadDefaults()
        {
            Input.MemoryCompressUnnamed = DefaultProgramSetup.Input.MemoryCompressUnnamed;
            Input.ForceBruteStream = DefaultProgramSetup.Input.ForceBruteStream;
            Input.ForceSmartStream = DefaultProgramSetup.Input.ForceSmartStream;
            Output.FileRoot = DefaultProgramSetup.Output.FileRoot;
            Output.SubFolder = DefaultProgramSetup.Output.SubFolder;
            Output.Overwrite = DefaultProgramSetup.Output.Overwrite;
            Output.FileType = DefaultProgramSetup.Output.FileType;
            Output.TOM_WriteCompressUnnamed = DefaultProgramSetup.Output.TOM_WriteCompressUnnamed;
            Output.CAP_WriteCompressUnnamed = DefaultProgramSetup.Output.CAP_WriteCompressUnnamed;
            Output.TRC_WriteCompressUnnamed = DefaultProgramSetup.Output.TRC_WriteCompressUnnamed;
            Output.FileRootChanged = DefaultProgramSetup.Output.FileRootChanged;
            Drawing.DrawUnnamed = DefaultProgramSetup.Drawing.DrawUnnamed;
            Drawing.MarkerDrawSize = DefaultProgramSetup.Drawing.MarkerDrawSize;
            Drawing.MarkerDrawSmoothnes = DefaultProgramSetup.Drawing.MarkerDrawSmoothnes;
            Drawing.NamedMarkerColor = DefaultProgramSetup.Drawing.NamedMarkerColor;
            Drawing.NamedMarkerColorSelected = DefaultProgramSetup.Drawing.NamedMarkerColorSelected;
            Drawing.UnnamedMarkerColor = DefaultProgramSetup.Drawing.UnnamedMarkerColor;
            Drawing.UnnamedMarkerColorSelected = DefaultProgramSetup.Drawing.UnnamedMarkerColorSelected;
            Drawing.DrawGrid = DefaultProgramSetup.Drawing.DrawGrid;
            Drawing.DrawAxis = DefaultProgramSetup.Drawing.DrawAxis;
            Drawing.BackColor = DefaultProgramSetup.Drawing.BackColor;
            Drawing.GridColor = DefaultProgramSetup.Drawing.GridColor;
            Drawing.OptimizeUnnamedDraw = DefaultProgramSetup.Drawing.OptimizeUnnamedDraw;
            Script.ShowLog = DefaultProgramSetup.Script.ShowLog;
            Script.WriteLog = DefaultProgramSetup.Script.WriteLog;
            Script.BasicScript = DefaultProgramSetup.Script.BasicScript;
            Script.TimeCodeStartZero = DefaultProgramSetup.Script.TimeCodeStartZero;
            Shortcuts.PausePlay = DefaultProgramSetup.Shortcuts.PausePlay;
            Shortcuts.PrevFrame = DefaultProgramSetup.Shortcuts.PrevFrame;
            Shortcuts.NextFrame = DefaultProgramSetup.Shortcuts.NextFrame;
            Shortcuts.FocusSelection = DefaultProgramSetup.Shortcuts.FocusSelection;
            Shortcuts.FollowSelection = DefaultProgramSetup.Shortcuts.FollowSelection;
            Shortcuts.OpenFiles = DefaultProgramSetup.Shortcuts.OpenFiles;
            Shortcuts.OpenFolder = DefaultProgramSetup.Shortcuts.OpenFolder;
            Shortcuts.Save = DefaultProgramSetup.Shortcuts.Save;
            Shortcuts.SaveAs = DefaultProgramSetup.Shortcuts.SaveAs;
            Shortcuts.Show_Player = DefaultProgramSetup.Shortcuts.Show_Player;
            Shortcuts.Show_Browser = DefaultProgramSetup.Shortcuts.Show_Browser;
            Shortcuts.Show_Output = DefaultProgramSetup.Shortcuts.Show_Output;
            Shortcuts.Show_Script = DefaultProgramSetup.Shortcuts.Show_Script;
            Shortcuts.Show_Data = DefaultProgramSetup.Shortcuts.Show_Data;
            Shortcuts.Show_Preferences = DefaultProgramSetup.Shortcuts.Show_Preferences;
            Shortcuts.Show_Toolbar = DefaultProgramSetup.Shortcuts.Show_Toolbar;
            Shortcuts.SaveScript = DefaultProgramSetup.Shortcuts.SaveScript;
            Shortcuts.LoadScript = DefaultProgramSetup.Shortcuts.LoadScript;
            Shortcuts.SelectAll = DefaultProgramSetup.Shortcuts.SelectAll;
            Shortcuts.RemoveItems = DefaultProgramSetup.Shortcuts.RemoveItems;
        }
        public static void LoadConfiguration(string Root)
        {
            try
            {
                FileStream Stream = new FileStream(Root, FileMode.Open);
                StreamReader Reader = new StreamReader(Stream);
                string Line = "";
                string[] LineItems;
                while (!Reader.EndOfStream)
                {
                    Line = Reader.ReadLine();
                    while (Line.Contains("\t\t")) Line.Replace("\t\t", "\t");
                    while (Line.Contains("  ")) Line.Replace("  ", " ");
                    LineItems = Line.Split(new char[2]{' ','\t'});
                    if (LineItems[0].Contains("[")) continue;
                    //Input
                    if (LineItems[0] == "MemoryCompressUnnamed")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Input.MemoryCompressUnnamed = Value;
                        continue;
                    }
                    if (LineItems[0] == "ForceBruteStream")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Input.ForceBruteStream = Value;
                        continue;
                    }
                    if (LineItems[0] == "ForceSmartStream")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Input.ForceSmartStream = Value;
                        continue;
                    }
                    //Output
                    if (LineItems[0] == "OutputRoot")
                    {
                        Output.FileRoot = LineItems[1].Replace('|',' ');
                        Output.FileRootChanged = true;
                        continue;
                    }
                    if (LineItems[0] == "WriteToSubFolder")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Output.SubFolder = Value;
                        continue;
                    }
                    if (LineItems[0] == "Overwrite")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Output.Overwrite = Value;
                        continue;
                    }
                    if (LineItems[0] == "OutputFileType")
                    {
                        if (!(LineItems[1] == "Original" || LineItems[1] == "C3D" || LineItems[1] == "CAP" || LineItems[1] == "TRC" || LineItems[1] == "TOM")) continue;
                        Output.FileType = LineItems[1];
                        continue;
                    }
                    if (LineItems[0] == "CAP_WriteCompressUnnamed")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Output.CAP_WriteCompressUnnamed = Value;
                        continue;
                    }
                    if (LineItems[0] == "TRC_WriteCompressUnnamed")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Output.TRC_WriteCompressUnnamed = Value;
                        continue;
                    }
                    if (LineItems[0] == "TOM_WriteCompressUnnamed")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Output.TOM_WriteCompressUnnamed = Value;
                        continue;
                    }
                    if (LineItems[0] == "AxisUp")
                    {
                        if (!(LineItems[1] == "Original" || LineItems[1] == "Z" || LineItems[1] == "Y")) continue;
                        if (LineItems[1] == "Original") Output.AxisUp = 0;
                        if (LineItems[1] == "Y") Output.AxisUp = 2;
                        if (LineItems[1] == "Z") Output.AxisUp = 3;
                        continue;
                    }
                    //Drawing
                    if (LineItems[0] == "DrawUnnamed")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Drawing.DrawUnnamed = Value;
                        continue;
                    }
                    if (LineItems[0] == "DrawGrid")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Drawing.DrawGrid = Value;
                        continue;
                    }
                    if (LineItems[0] == "DrawAxis")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Drawing.DrawAxis = Value;
                        continue;
                    }
                    if (LineItems[0] == "MarkerDrawSize")
                    {
                        int IValue = 0;
                        if (!Int32.TryParse(LineItems[1], out IValue)) continue;
                        Drawing.MarkerDrawSize = IValue;
                        continue;
                    }
                    if (LineItems[0] == "MarkerDrawSmoothness")
                    {
                        int IValue = 0;
                        if (!Int32.TryParse(LineItems[1], out IValue)) continue;
                        Drawing.MarkerDrawSmoothnes = IValue;
                        continue;
                    }
                    if (LineItems[0] == "NamedMarkerColor")
                    {
                        string[] ValueItems = LineItems[1].Split('-');
                        try
                        {
                            Drawing.NamedMarkerColor = Color.FromArgb(Convert.ToInt32(ValueItems[0]), Convert.ToInt32(ValueItems[1]), Convert.ToInt32(ValueItems[2]));
                        }
                        catch { }
                        continue;
                    }
                    if (LineItems[0] == "NamedMarkerColorSelected")
                    {
                        string[] ValueItems = LineItems[1].Split('-');
                        try
                        {
                            Drawing.NamedMarkerColorSelected = Color.FromArgb(Convert.ToInt32(ValueItems[0]), Convert.ToInt32(ValueItems[1]), Convert.ToInt32(ValueItems[2]));
                        }
                        catch { }
                        continue;
                    }
                    if (LineItems[0] == "UnnamedMarkerColor")
                    {
                        string[] ValueItems = LineItems[1].Split('-');
                        try
                        {
                            Drawing.UnnamedMarkerColor = Color.FromArgb(Convert.ToInt32(ValueItems[0]), Convert.ToInt32(ValueItems[1]), Convert.ToInt32(ValueItems[2]));
                        }
                        catch { }
                        continue;
                    }
                    if (LineItems[0] == "UnnamedMarkerColorSelected")
                    {
                        string[] ValueItems = LineItems[1].Split('-');
                        try
                        {
                            Drawing.UnnamedMarkerColorSelected = Color.FromArgb(Convert.ToInt32(ValueItems[0]), Convert.ToInt32(ValueItems[1]), Convert.ToInt32(ValueItems[2]));
                        }
                        catch { }
                        continue;
                    }
                    if (LineItems[0] == "BackColor")
                    {
                        string[] ValueItems = LineItems[1].Split('-');
                        try
                        {
                            Drawing.BackColor = Color.FromArgb(Convert.ToInt32(ValueItems[0]), Convert.ToInt32(ValueItems[1]), Convert.ToInt32(ValueItems[2]));
                        }
                        catch { }
                        continue;
                    }
                    if (LineItems[0] == "GridColor")
                    {
                        string[] ValueItems = LineItems[1].Split('-');
                        try
                        {
                            Drawing.GridColor = Color.FromArgb(Convert.ToInt32(ValueItems[0]), Convert.ToInt32(ValueItems[1]), Convert.ToInt32(ValueItems[2]));
                        }
                        catch { }
                        continue;
                    }
                    if (LineItems[0] == "OptimizeUnnamed")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Drawing.OptimizeUnnamedDraw = Value;
                        continue;
                    }
                    //Script
                    if (LineItems[0] == "ShowLog")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Script.ShowLog = Value;
                        continue;
                    }
                    if (LineItems[0] == "WriteLog")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Script.WriteLog = Value;
                        continue;
                    }
                    if (LineItems[0] == "BasicScript")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Script.BasicScript = Value;
                        continue;
                    }
                    if (LineItems[0] == "TimeCodeStartZero")
                    {
                        int IValue = 0;
                        bool Value = false;
                        if (Boolean.TryParse(LineItems[1], out Value)) { }
                        else if (Int32.TryParse(LineItems[1], out IValue)) Value = IValue > 0;
                        Script.TimeCodeStartZero = Value;
                        continue;
                    }
                    //Shortcuts
                    if (LineItems[0] == "Pause/Play")
                    {
                        Shortcuts.PausePlay =  LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "PreviousFrame")
                    {
                        Shortcuts.PrevFrame = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "NextFrame")
                    {
                        Shortcuts.NextFrame = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "FocusSelection")
                    {
                        Shortcuts.FocusSelection = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "FollowSelection")
                    {
                        Shortcuts.FollowSelection = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "OpenFiles")
                    {
                        Shortcuts.OpenFiles = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "OpenFolder")
                    {
                        Shortcuts.OpenFolder = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "Save")
                    {
                        Shortcuts.Save = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "SaveAs")
                    {
                        Shortcuts.SaveAs = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "Show_Player")
                    {
                        Shortcuts.Show_Player = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "Show_Browser")
                    {
                        Shortcuts.Show_Browser = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "Show_Output")
                    {
                        Shortcuts.Show_Output = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "Show_Script")
                    {
                        Shortcuts.Show_Script = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "Show_Data")
                    {
                        Shortcuts.Show_Data = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "Show_Toolbar")
                    {
                        Shortcuts.Show_Toolbar = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "SaveScript")
                    {
                        Shortcuts.SaveScript = LineItems[1].Split('+');
                        continue;
                    }
                    if (LineItems[0] == "LoadScript")
                    {
                        Shortcuts.LoadScript = LineItems[1].Split('+');
                        continue;
                    }
                }
                Reader.Close();
            }
            catch
            { }
        }
        public static void SaveConfiguration(string Root)
        {
            try
            {
                FileStream Stream = new FileStream(Root, FileMode.Create);
                StreamWriter Writer = new StreamWriter(Stream);
                Writer.WriteLine("[WARNING! DO NOT EDIT THIS FILE!]");
                Writer.WriteLine("");
                //Input
                Writer.WriteLine("[Input]");
                //Writer.WriteLine("MemoryCompressUnnamed\t" + Input.MemoryCompressUnnamed.ToString());
                Writer.WriteLine("ForceBruteStream\t" + Input.ForceBruteStream);
                Writer.WriteLine("ForceSmartStream\t" + Input.ForceSmartStream);
                Writer.WriteLine("");
                //Output
                Writer.WriteLine("[Output]");
                Writer.WriteLine("OutputRoot\t" + Output.FileRoot.Replace(' ','|'));
                Writer.WriteLine("OutputFileType\t" + Output.FileType);
                Writer.WriteLine("WriteToSubFolder\t" + Output.SubFolder);
                Writer.WriteLine("CAP_WriteCompressUnnamed\t" + Output.CAP_WriteCompressUnnamed);
                if (Output.AxisUp == 0) Writer.WriteLine("AxisUp\tOriginal");
                else if (Output.AxisUp == 2) Writer.WriteLine("AxisUp\tY");
                else if (Output.AxisUp == 3) Writer.WriteLine("AxisUp\tZ");
                Writer.WriteLine("");
                //Drawing
                Writer.WriteLine("[Drawing]");
                Writer.WriteLine("MarkerDrawSize\t" + Drawing.MarkerDrawSize);
                Writer.WriteLine("MarkerDrawSmoothness\t" + Drawing.MarkerDrawSmoothnes);
                Writer.WriteLine("NamedMarkerColor\t" + Drawing.NamedMarkerColor.R+"-"+Drawing.NamedMarkerColor.G+"-"+Drawing.NamedMarkerColor.B);
                Writer.WriteLine("NamedMarkerColorSelected\t" + Drawing.NamedMarkerColorSelected.R + "-" + Drawing.NamedMarkerColorSelected.G + "-" + Drawing.NamedMarkerColorSelected.B);
                Writer.WriteLine("UnnamedMarkerColor\t" + Drawing.UnnamedMarkerColor.R + "-" + Drawing.UnnamedMarkerColor.G + "-" + Drawing.UnnamedMarkerColor.B);
                Writer.WriteLine("UnnamedMarkerColorSelected\t" + Drawing.UnnamedMarkerColorSelected.R + "-" + Drawing.UnnamedMarkerColorSelected.G + "-" + Drawing.UnnamedMarkerColorSelected.B);
                Writer.WriteLine("DrawGrid\t" + Drawing.DrawGrid);
                Writer.WriteLine("DrawAxis\t" + Drawing.DrawAxis);
                Writer.WriteLine("BackColor\t" + Drawing.BackColor.R + "-" + Drawing.BackColor.G + "-" + Drawing.BackColor.B);
                Writer.WriteLine("GridColor\t" + Drawing.GridColor.R + "-" + Drawing.GridColor.G + "-" + Drawing.GridColor.B);
                Writer.WriteLine("OptimizeUnnamed\t" + Drawing.OptimizeUnnamedDraw);
                Writer.WriteLine("");
                //Script
                Writer.WriteLine("[Script]");
                Writer.WriteLine("ShowLog\t" + Script.ShowLog);
                Writer.WriteLine("WriteLog\t" + Script.WriteLog);
                Writer.WriteLine("BasicScript\t" + Script.BasicScript);
                Writer.WriteLine("TimeCodeStartZero\t" + Script.TimeCodeStartZero);
                Writer.WriteLine("");
                //Shortcuts
                Writer.WriteLine("[Shortcuts]");
                Writer.WriteLine("Pause/Play\t" + MergeStrings(Shortcuts.PausePlay,"+"));
                Writer.WriteLine("PreviousFrame\t" + MergeStrings(Shortcuts.PrevFrame, "+"));
                Writer.WriteLine("NextFrame\t" + MergeStrings(Shortcuts.NextFrame, "+"));
                Writer.WriteLine("FocusSelection\t" + MergeStrings(Shortcuts.FocusSelection, "+"));
                Writer.WriteLine("FollowSelection\t" + MergeStrings(Shortcuts.FollowSelection, "+"));
                Writer.WriteLine("OpenFiles\t" + MergeStrings(Shortcuts.OpenFiles, "+"));
                Writer.WriteLine("OpenFolder\t" + MergeStrings(Shortcuts.OpenFolder, "+"));
                Writer.WriteLine("Save\t" + MergeStrings(Shortcuts.Save, "+"));
                Writer.WriteLine("SaveAs\t" + MergeStrings(Shortcuts.SaveAs, "+"));
                Writer.WriteLine("Show_Player\t" + MergeStrings(Shortcuts.Show_Player, "+"));
                Writer.WriteLine("Show_Browser\t" + MergeStrings(Shortcuts.Show_Browser, "+"));
                Writer.WriteLine("Show_Output\t" + MergeStrings(Shortcuts.Show_Output, "+"));
                Writer.WriteLine("Show_Script\t" + MergeStrings(Shortcuts.Show_Script, "+"));
                Writer.WriteLine("Show_Data\t" + MergeStrings(Shortcuts.Show_Data, "+"));
                Writer.WriteLine("Show_Toolbar\t" + MergeStrings(Shortcuts.Show_Toolbar, "+"));
                Writer.WriteLine("SaveScript\t" + MergeStrings(Shortcuts.SaveScript, "+"));
                Writer.WriteLine("LoadScript\t" + MergeStrings(Shortcuts.LoadScript, "+"));
                Writer.WriteLine("SaveAs\t" + MergeStrings(Shortcuts.SaveAs, "+"));
                Writer.WriteLine("");
                Writer.Close();
            }
            catch { }
        }
        public static string MergeStrings(string[] Collection, string InBetwen)
        {
            string Merged = Collection[0];
            for (int i = 1; i < Collection.Length; i++)
            {
                Merged += InBetwen + Collection[i];
            }
            return Merged;
        }
    }
    public class DefaultProgramSetup
    {
        public static class Input
        {
            public static bool MemoryCompressUnnamed = false;
            public static bool ForceBruteStream = true;
            public static bool ForceSmartStream = false;
        }
        public static class Output
        {
            public static string FileRoot = "C:\\";
            public static bool SubFolder = false;
            public static bool Overwrite = false;
            public static string FileType = "Original";
            public static bool TOM_WriteCompressUnnamed = false;
            public static bool CAP_WriteCompressUnnamed = true;
            public static bool TRC_WriteCompressUnnamed = false;
            public static bool FileRootChanged = false;
        }
        public static class Drawing
        {
            public static bool DrawUnnamed = true;
            public static int MarkerDrawSize = 10;
            public static int MarkerDrawSmoothnes = 8;
            public static System.Drawing.Color NamedMarkerColor = System.Drawing.Color.FromArgb(241, 101, 33);
            public static System.Drawing.Color NamedMarkerColorSelected = System.Drawing.Color.FromArgb(51, 153, 255);
            public static System.Drawing.Color UnnamedMarkerColor = System.Drawing.Color.Gray;
            public static System.Drawing.Color UnnamedMarkerColorSelected = System.Drawing.Color.LightBlue;
            public static bool DrawGrid = true;
            public static bool DrawAxis = true;
            public static System.Drawing.Color BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            public static System.Drawing.Color GridColor = System.Drawing.Color.FromArgb(82, 82, 82);
            public static bool OptimizeUnnamedDraw = true;
        }
        public static class Script
        {
            public static bool ShowLog = true;
            public static bool WriteLog = true;
            public static bool BasicScript = true;
            public static bool TimeCodeStartZero = false;
        }
        public static class Layout
        {

        }
        public static class Shortcuts
        {
            public static string[] PausePlay = new string[1] { "Space" };
            public static string[] PrevFrame = new string[1] { "S" };
            public static string[] NextFrame = new string[1] { "F" };
            public static string[] FocusSelection = new string[1] { "Q" };
            public static string[] FollowSelection = new string[1] { "W" };
            public static string[] OpenFiles = new string[2] { "Control", "O" };
            public static string[] OpenFolder = new string[3] { "Control", "Shift", "O" };
            public static string[] Save = new string[2] { "Control", "S" };
            public static string[] SaveAs = new string[3] { "Control", "Shift", "S" };
            public static string[] Show_Player = new string[2] { "Control", "D1" };
            public static string[] Show_Browser = new string[2] { "Control", "D2" };
            public static string[] Show_Output = new string[2] { "Control", "D3" };
            public static string[] Show_Script = new string[2] { "Control", "D4" };
            public static string[] Show_Data = new string[2] { "Control", "D5" };
            public static string[] Show_Preferences = new string[2] { "Control", "D6" };
            public static string[] Show_Toolbar = new string[2] { "Control", "T" };
            public static string[] SaveScript = new string[3] { "Control", "Alt", "S" };
            public static string[] LoadScript = new string[3] { "Control", "Alt", "L" };
            public static string[] SelectAll = new string[2] { "Control", "A" };
            public static string[] RemoveItems = new string[1] { "Delete" };
        }
    }
}