using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SiteMan
{
    public class Data
    {
        public List<Site> List(string path)
        {
            List<Site> list = new List<Site>();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path + "data.xml");
            XmlNodeList childNodes = xmlDocument.DocumentElement.ChildNodes;
            foreach (XmlNode xmlNode in childNodes)
            {
                XmlNode xmlNode2 = xmlNode.SelectSingleNode("label");
                XmlNode xmlNode3 = xmlNode.SelectSingleNode("url");
                XmlNode xmlNode4 = xmlNode.SelectSingleNode("status");
                XmlNode xmlNode5 = xmlNode.SelectSingleNode("type");
                if (xmlNode2 != null && xmlNode3 != null && xmlNode4 != null)
                {
                    if (xmlNode4.InnerText == "OK")
                    {
                        Site site = new Site();
                        site.Name = xmlNode2.InnerText;
                        site.Url = xmlNode3.InnerText;
                        site.Status = xmlNode4.InnerText;
                        if (xmlNode5 != null)
                        {
                            site.Type = xmlNode5.InnerText;
                        }
                        else
                        {
                            site.Type = "ACG";
                        }
                        list.Add(site);
                    }
                    
                }
            }
            return list;
        }
    }
}
