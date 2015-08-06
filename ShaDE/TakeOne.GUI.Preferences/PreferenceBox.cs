using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TakeOne.GUI.Preferences
{
    public delegate void ValueChangeHandler(int Index, string Value);
    public partial class PropertyList : UserControl
    {
        private List<PropertyItem> Items;
        public event ValueChangeHandler ValueChange;
        public PropertyList()
        {
            InitializeComponent();
            ValueChange = new ValueChangeHandler(OnValueChange);
        }
        public void OnValueChange(int Index, string Value)
        {
        }
        public void GeneratePropertyList(List<PropertyItem> Items)
        {
            if (Items == null) this.Items = new List<PropertyItem>();
            else this.Items = Items;
            GenerateItems();
        }
        public void ClearPropertyList()
        {
            this.Items = new List<PropertyItem>();
            this.Controls.Clear();
        }
        public void AddNewItem(int Type, string Label, string DefaultValue)
        {
            Items.Add(new PropertyItem(Type,Label,DefaultValue));
            GenerateItems();
        }
        public void GenerateItems()
        {
            this.Controls.Clear();
            for (int i = Items.Count-1; i >= 0; i--)
            {
                if (Items[i].Type == -1)
                {
                    Label NewLabel = new Label();
                    NewLabel.BackColor = Color.DimGray;
                    NewLabel.ForeColor = Color.White;
                    NewLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    NewLabel.Text = Items[i].Label;
                    NewLabel.TextAlign = ContentAlignment.MiddleLeft;
                    NewLabel.Dock = DockStyle.Top;
                    NewLabel.Padding = new Padding(120, 0, 0, 0);
                    this.Controls.Add(NewLabel);
                }
                else
                {
                    PreferenceItem NewPreference = new PreferenceItem(Items[i].Label, Items[i].Value);
                    if (Items[i].Type == 0) NewPreference = new PreferenceCheckBox(Items[i].Label, Items[i].Value);
                    else if (Items[i].Type == 1) NewPreference = new PreferenceTextBox(Items[i].Label, Items[i].Value);
                    else if (Items[i].Type == 2) NewPreference = new PreferenceFolderBrowser(Items[i].Label, Items[i].Value);
                    else if (Items[i].Type == 3) NewPreference = new PreferenceSelectionBox(Items[i].Label, Items[i].Value);
                    else if (Items[i].Type == 4) NewPreference = new PreferenceNumericUpDown(Items[i].Label, Items[i].Value);
                    else if (Items[i].Type == 5) NewPreference = new PreferenceTrackbar(Items[i].Label, Items[i].Value);
                    else if (Items[i].Type == 6) NewPreference = new PreferenceColorDialog(Items[i].Label, Items[i].Value);
                    else if (Items[i].Type == 7) NewPreference = new PreferenceTimeCodeBox(Items[i].Label, Items[i].Value);
                    else if (Items[i].Type == 8) NewPreference = new PreferenceSetShortcutDialog(Items[i].Label, Items[i].Value);
                    NewPreference.Dock = DockStyle.Top;
                    NewPreference.ValueChange += new ValueChangeHandler(ChangeHandler);
                    NewPreference.Tag = i;
                    this.Controls.Add(NewPreference);
                }
                
            }
        }
        private void ChangeHandler(int Index, string Value)
        {
            this.ValueChange.Invoke(Index, Value);
        }
    }
    public class PropertyItem
    {
        private int _Type;
        private string _Label;
        private string _Value;
        public string Label
        {
            get { return this._Label; }
            set { this._Label = value; }
        }
        public int Type
        {
            get { return this._Type; }
            set { this._Type = value; }
        }
        public string Value
        {
            get { return this._Value; }
            set { this._Value = value; }
        }
        public PropertyItem(int Type, string Label, string Value)
        {
            this._Type = Type;
            this._Label = Label;
            this._Value = Value;
        }
    }
}
