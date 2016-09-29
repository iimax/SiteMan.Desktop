using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteMan
{
    public class Site
    {
        public string Name
        {
            get;
            set;
        }
        public string Url
        {
            get;
            set;
        }
        public string Status
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public Site()
        {
        }
        public Site(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }
    }
}
