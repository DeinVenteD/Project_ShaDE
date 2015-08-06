using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShaDE.Solutions
{
    public class Solution
    {
        private string _Name;
        private List<Project> _Projects;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public List<Project> Projects
        {
            get { return _Projects; }
            set { _Projects = value; }
        }
        public Solution()
        {
            _Projects = new List<Project>();
        }
    }
}
