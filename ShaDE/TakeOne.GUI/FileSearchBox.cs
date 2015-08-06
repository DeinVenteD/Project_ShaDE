using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI
{
    public delegate void DoubleClickedHandler(object sender, EventArgs e);
    public partial class FileView : UserControl
    {
        public event ListBoxSelectionEventHandler SelectionChange;
        public event DoubleClickedHandler DClick;
        public FileView()
        {
            InitializeComponent();
            List.AddFileType(new FileType("C3D", global::TakeOne.GUI.Properties.Resources.C3D, global::TakeOne.GUI.Properties.Resources.C3D_OFF));
            List.AddFileType(new FileType("CAP", global::TakeOne.GUI.Properties.Resources.CAP, global::TakeOne.GUI.Properties.Resources.CAP_OFF));
            List.AddFileType(new FileType("TRC", global::TakeOne.GUI.Properties.Resources.TRC, global::TakeOne.GUI.Properties.Resources.TRC_OFF));
            List.AddFileType(new FileType("TRB", global::TakeOne.GUI.Properties.Resources.TRB, global::TakeOne.GUI.Properties.Resources.TRB_OFF));
            List.AddFileType(new FileType("TOM", global::TakeOne.GUI.Properties.Resources.TOM, global::TakeOne.GUI.Properties.Resources.TOM_OFF));
            List.AddFileType(new FileType("PT3", global::TakeOne.GUI.Properties.Resources.PT3, global::TakeOne.GUI.Properties.Resources.PT3_OFF));
            List.AddFileType(new FileType("TAK", global::TakeOne.GUI.Properties.Resources.TAK, global::TakeOne.GUI.Properties.Resources.TAK_OFF));
            List.AddFileType(new FileType("HDF", global::TakeOne.GUI.Properties.Resources.HDF, global::TakeOne.GUI.Properties.Resources.HDF_OFF));
            this.SelectionChange = new ListBoxSelectionEventHandler(List.SelectedChanged);
            List.SelectionChange += new ListBoxSelectionEventHandler(SelectionHandle);
            DClick = new DoubleClickedHandler(OnDClick);
            ToolSortTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }
        private void SelectionHandle(List<int> Selection)
        {
            this.SelectionChange.Invoke(Selection);
        }
        public void AddItem(string NewItem)
        {
            List.AddItem(NewItem);
        }
        public void AddItems(List<string> NewItems)
        {
            List.AddItems(NewItems);
        }
        public void ClearItems()
        {
            List.ClearItems();
        }
        public void RemoveItem(int Index)
        {
            List.RemoveItem(Index);
        }
        public void RemoveItems(List<int> Indices)
        {
            List.RemoveItems(Indices);
        }
        public void Enable(int Index)
        {
            List.Enable(Index);
        }
        public List<int> SelectedIndices
        {
            get 
            { 
                return List.RealSelected; 
            }
        }
        public bool TextFocus
        {
            get
            {
                return TextFilterBox.Focused;
            }
        }
        private void TextFilterBox_TextChanged(object sender, EventArgs e)
        {
            List.TextFilter = TextFilterBox.Text;
        }
        private void ToolSort_Click(object sender, EventArgs e)
        {
            Control TControl = sender as Control;
            List.SortType = Convert.ToInt32(TControl.Tag);
        }
        private void ColorTools(object sender)
        {
            Control ControlT = sender as Control;
            if (ControlT.Tag.ToString() == "0") ControlT.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortByTime_Blue;
            else if (ControlT.Tag.ToString() == "1") ControlT.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortByName_Blue;
            else if (ControlT.Tag.ToString() == "2") ControlT.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortBySize_Blue;
            else if (ControlT.Tag.ToString() == "3") ControlT.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortByType_Blue;
            ControlT.ForeColor = Color.FromArgb(51, 153, 255);
        }
        private void Tool_MouseEnter(object sender, EventArgs e)
        {
            ColorTools(sender);
        }
        private void Tool_MouseLeave(object sender, EventArgs e)
        {
            Control ControlT = sender as Control;
            if (ControlT.Tag.ToString() == "0") ControlT.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortByTime;
            else if (ControlT.Tag.ToString() == "1") ControlT.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortByName;
            else if (ControlT.Tag.ToString() == "2") ControlT.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortBySize;
            else if (ControlT.Tag.ToString() == "3") ControlT.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortByType;
            ControlT.ForeColor = Color.White;
        }
        private void Tool_MouseUp(object sender, MouseEventArgs e)
        {
            ColorTools(sender);
        }
        private void Tool_MouseDown(object sender, MouseEventArgs e)
        {
            Control ControlT = sender as Control;
            if (ControlT.Tag.ToString() == "0") ControlT.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortByTime_Orange;
            else if (ControlT.Tag.ToString() == "1") ControlT.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortByName_Orange;
            else if (ControlT.Tag.ToString() == "2") ControlT.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortBySize_Orange;
            else if (ControlT.Tag.ToString() == "3") ControlT.BackgroundImage = global::TakeOne.GUI.Properties.Resources.SortByType_Orange;
            ControlT.ForeColor = Color.FromArgb(241, 101, 33);
        }
        private void Tool_MouseHover(object sender, EventArgs e)
        {
            ToolTip NewTooltip = new ToolTip();
            Control ControlT = sender as Control;
            if (ControlT.Tag.ToString() == "0") NewTooltip.SetToolTip(ControlT, "Sort By Open Time");
            else if (ControlT.Tag.ToString() == "1") NewTooltip.SetToolTip(ControlT, "Sort By File Name");
            else if (ControlT.Tag.ToString() == "2") NewTooltip.SetToolTip(ControlT, "Sort By File Size");
            else if (ControlT.Tag.ToString() == "3") NewTooltip.SetToolTip(ControlT, "Sort By File Type");
        }
        public int Count
        {
            get { return List.Items.Count; }
        }
        public void Sort(int Num)
        {
            List.SortType = Num;
        }
        private void FilesView_DoubleClick(object sender, EventArgs e)
        {
            DClick.Invoke(sender, e);
        }
        private void OnDClick(object sender, EventArgs e)
        {
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            ProgramSetup.Current.MDIChildKeypress = true;
            if (keyData == (Keys.Control | Keys.A))
            {
                List.SelectedIndices.Clear();
                for (int i = 0; i < List.Items.Count; i++)
                {
                    List.SelectedIndices.Add(i);
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
