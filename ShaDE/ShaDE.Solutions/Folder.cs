using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShaDE.Solutions
{
    public class Folder
    {
        private string _Name;
        private List<File> _Files;
        private List<Folder> _Subfolders;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public List<File> Files
        {
            get { return _Files; }
            set { _Files = value; }
        }
        public List<Folder> Subfolders
        {
            get { return _Subfolders; }
            set { _Subfolders = value; }
        }
        public Folder()
        {
            _Files = new List<File>();
            _Subfolders = new List<Folder>();
        }
    }
}
