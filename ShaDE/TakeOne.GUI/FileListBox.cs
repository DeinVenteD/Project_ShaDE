using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TakeOne.GUI
{
    public delegate void ListBoxSelectionEventHandler(List<int> SelectedItems);
    public partial class ListViewer : ListBox
    {
        private Size _imageSize;
        private StringFormat _fmt;
        private Font _titleFont;
        private Font _detailsFont;
        private int Value_SortType;
        private int Value_FileTypeFilter;
        private string Value_TextFilter;
        private List<bool> EnabledList;
        private List<int> ShowList;
        private List<long> FileSize;
        private List<string> LoadList;
        private List<FileType> FileTypes;
        public int SortType
        {
            get { return Value_SortType; }
            set 
            { 
                Value_SortType = value;
                GenerateShowList();
            }
        }
        public int FileTypeFilter
        {
            get { return this.Value_FileTypeFilter; }
            set 
            { 
                this.Value_FileTypeFilter = value;
                GenerateShowList();
            }
        }
        public string TextFilter
        {
            get { return this.Value_TextFilter; }
            set 
            { 
                this.Value_TextFilter = value;
                GenerateShowList();
            }
        }
        public List<int> RealSelected
        {
            get 
            {
                List<int> RealSelection = new List<int>();
                for (int i = 0; i < this.SelectedIndices.Count; i++) RealSelection.Add(ShowList[SelectedIndices[i]]);
                return RealSelection;
            }
        }
        public event ListBoxSelectionEventHandler SelectionChange;
        public ListViewer()
        {
            _imageSize = new Size(30, 25);
            this.ItemHeight = _imageSize.Height;
            _fmt = new StringFormat();
            _fmt.Alignment = StringAlignment.Near;
            _fmt.LineAlignment = StringAlignment.Near;
            _titleFont = new Font(this.Font, FontStyle.Bold);
            _detailsFont = new Font(this.Font, FontStyle.Regular);
            this.Value_SortType = 0;
            this.Value_FileTypeFilter = -1;
            this.Value_TextFilter = "";
            this.EnabledList = new List<bool>();
            this.ShowList = new List<int>();
            this.FileSize = new List<long>();
            this.LoadList = new List<string>();
            this.FileTypes = new List<FileType>();
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DrawItem += new DrawItemEventHandler(DrawItems);
            this.SelectedIndexChanged += new EventHandler(SelectionHandle);
            this.SelectionChange = new ListBoxSelectionEventHandler(SelectedChanged);
            this.ItemHeight = 38;
        }
        private void SelectionHandle(object sender, EventArgs e)
        {
            SelectionChange.Invoke(RealSelected);
        }
        public void SelectedChanged(List<int> SelectedItems)
        {
        }
        private string SizeString(long Size)
        {
            if (Size > (1024 * 1024 * 1024)) return ((Size * 1.0) / (1024 * 1024 * 1024)).ToString("0.00") + " GB";
            if (Size > (1024 * 1024)) return ((Size * 1.0) / (1024 * 1024)).ToString("0.00") + " MB";
            if (Size > 1024) return ((Size * 1.0) / 1024).ToString("0.00") + " KB";
            return Size.ToString("0.00") + " B";
        }
        public void AddItem(string Item)
        {
            this.LoadList.Add(Path.GetFileName(Item));
            this.EnabledList.Add(false);
            FileInfo Info = new FileInfo(Item);
            this.FileSize.Add(Info.Length);
            GenerateShowList();
        }
        public void AddItems(List<string> Items)
        {
            for(int i = 0; i < Items.Count; i++)
                this.AddItem(Items[i]);
            GenerateShowList();
        }
        public void AddFileType(FileType FileTypeToAdd)
        {
            FileTypes.Add(FileTypeToAdd);
        }
        public void ClearItems()
        {
            this.EnabledList.Clear();
            this.LoadList.Clear();
            this.FileSize.Clear();
            GenerateShowList();
        }
        public void RemoveItem(int Index)
        {
            this.EnabledList.RemoveAt(Index);
            this.LoadList.RemoveAt(Index);
            this.FileSize.RemoveAt(Index);
            GenerateShowList();
        }
        public void RemoveItems(List<int> Indices)
        {
            for (int i = 0; i < Indices.Count; i++) RemoveItem(Indices[i]);
        }
        private void GenerateShowList()
        {
            List<int> NewShowList = new List<int>();
            for(int i = 0; i < this.LoadList.Count; i++) NewShowList.Add(i);
            List<string> LoadListReference = new List<string>(this.LoadList);
            if (this.Value_TextFilter != "")
            {
                for (int i = NewShowList.Count-1; i >= 0; i--)
                {
                    if (!LoadListReference[i].Contains(this.Value_TextFilter))
                    {
                        NewShowList.RemoveAt(i);
                        LoadListReference.RemoveAt(i);
                    }
                }
            }
            if (this.Value_FileTypeFilter != -1 && this.Value_FileTypeFilter < FileTypes.Count)
            {
                for (int i = NewShowList.Count-1; i >= 0; i--)
                {
                    if (!LoadListReference[i].ToUpper().EndsWith("." + this.FileTypes[Value_FileTypeFilter].Extension))
                    {
                        NewShowList.RemoveAt(i);
                        LoadListReference.RemoveAt(i);
                    }
                }
            }
            this.ShowList = NewShowList;
            if (this.SortType == 1) ShowList.Sort(NameCompare);
            if (this.SortType == 2) ShowList.Sort(SizeCompare);
            if (this.SortType == 3) ShowList.Sort(ExtensionCompare);
            this.Items.Clear();
            for (int i = 0; i < LoadListReference.Count; i++) this.Items.Add(Path.GetFileNameWithoutExtension(this.LoadList[this.ShowList[i]]));
        }
        public void Enable(int Index)
        {
            EnabledList = new List<bool>();
            for (int i = 0; i < LoadList.Count; i++) EnabledList.Add(false);
            if(Index!=-1) EnabledList[Index] = true;
            GenerateShowList();
        }
        private int NameCompare(int x, int y)
        {
            return this.LoadList[x].CompareTo(LoadList[y]);
        }
        private int SizeCompare(int x, int y)
        {
            return (int)(this.FileSize[x] - this.FileSize[y]);
        }
        private int ExtensionCompare(int x, int y)
        {
            return this.LoadList[x].Substring(this.LoadList[x].Length - 3, 3).CompareTo(this.LoadList[y].Substring(this.LoadList[y].Length - 3, 3));
        }
        private Image GetExtensionImage(string Extension, bool Dimed)
        {
            for (int i = 0; i < FileTypes.Count; i++)
                if (Extension == FileTypes[i].Extension)
                {
                    if(!Dimed) return FileTypes[i].DimRepresentationImage;
                    return FileTypes[i].RepresentationImage;
                }
            return null;
        }
        private void Drmr(DrawItemEventArgs e, Padding margin, Font titleFont, Font detailsFont, StringFormat aligment, Size imageSize)
        {
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(117, 117, 117)), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, 64, 64)), e.Bounds);
            }

            string ext = Path.GetExtension(LoadList[ShowList[e.Index]]).Substring(1).ToUpper();

            Image Rep = GetExtensionImage(ext, EnabledList[ShowList[e.Index]]);
            if(Rep!= null) e.Graphics.DrawImage(Rep, e.Bounds.X + margin.Left, e.Bounds.Y + margin.Top, imageSize.Width, imageSize.Height);

            Rectangle titleBounds = new Rectangle(e.Bounds.X + margin.Horizontal - 3 + imageSize.Width,
                                                  e.Bounds.Y + margin.Vertical - 4,
                                                  e.Bounds.Width - margin.Right - imageSize.Width - margin.Horizontal - 3,
                                                  (int)titleFont.GetHeight() + 2);

            Rectangle detailBounds = new Rectangle(e.Bounds.X + margin.Horizontal - 3 + imageSize.Width,
                                                   e.Bounds.Y + (int)titleFont.GetHeight() + margin.Vertical - 4,
                                                   e.Bounds.Width - margin.Right - imageSize.Width - margin.Horizontal - 3,
                                                   e.Bounds.Height - margin.Bottom - (int)titleFont.GetHeight() + 4);

            e.Graphics.DrawString(this.Items[e.Index].ToString(), titleFont, Brushes.White, titleBounds, aligment);
            e.Graphics.DrawString(SizeString(FileSize[ShowList[e.Index]]), detailsFont, Brushes.White, detailBounds, aligment);

            e.DrawFocusRectangle();

        }
        private void DrawItems(object sender, DrawItemEventArgs e)
        {
            if (this.Items.Count > 0 && e.Index != -1)
            {
                this.Drmr(e, this.Margin, _titleFont, _detailsFont, _fmt, this._imageSize);
            }
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
    public class FileType
    {
        private string Value_Extension;
        private Image Value_RepresentationImage;
        private Image Value_DimRepresentationImage;
        public string Extension
        {
            get { return this.Value_Extension; }
            set { this.Value_Extension = value; }
        }
        public Image RepresentationImage
        {
            get { return this.Value_RepresentationImage; }
            set { this.Value_RepresentationImage = value; }
        }
        public Image DimRepresentationImage
        {
            get { return this.Value_DimRepresentationImage; }
            set { this.Value_DimRepresentationImage = value; }
        }
        public FileType(string Extension, Image RepresentationImage, Image DimRepresentationImage)
        {
            this.Value_Extension = Extension;
            this.Value_RepresentationImage = RepresentationImage;
            this.Value_DimRepresentationImage = DimRepresentationImage;
        }
    }
}
