using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShaDE.Solutions
{
    public class Project
    {
        private Folder _ProjectFolder;
        private List<string> _References;
        public Folder ProjectFolder
        {
            get { return _ProjectFolder; }
            set { _ProjectFolder = value; }
        }
        public List<string> References
        {
            get { return _References; }
            set { _References = value; }
        }
        public Project()
        {
            _ProjectFolder = new Folder();
            _References = new List<string>();
        }
    }
}
