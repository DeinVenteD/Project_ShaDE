using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShaDE.Solutions
{
    public class File
    {
        private int _Type;
        private string _Name;
        private string _Root;
        public int Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Root
        {
            get { return _Root; }
            set { _Root = value; }
        }
        public File()
        {
            this._Name = "";
            this._Root = "";
            this._Type = 0;
        }
    }
}
