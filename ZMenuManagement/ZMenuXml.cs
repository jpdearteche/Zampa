using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZMenuManagement
{
    public class ZMenuXml : ZMenuBase
    {
        public ZMenuXml(string location)
            : base(location)
        {

        }
        public override List<ZMenuItem> Load()
        {
            XElement menus = XElement.Load(Location);
            List<ZMenuItem> ret = new List<ZMenuItem>();
            ret = LoadMenus(menus, 0);
            return ret;
        }

        private List<ZMenuItem> LoadMenus(XElement menus, int parentMenuId)
        {
            var nodes = new List<ZMenuItem>();

            nodes = (from node in menus.Elements("Menu")
                     where Convert.ToInt32(node.Element("ParentMenuId").Value) == parentMenuId
                     orderby Convert.ToInt32(node.Element("DisplayOrder").Value)
                     select new ZMenuItem()
                     {
                         MenuId = Convert.ToInt32(node.Element("MenuId").Value),
                         ParentMenuId = Convert.ToInt32(node.Element("ParentMenuId").Value),
                         MenuTitle = node.Element("MenuTitle").Value,
                         DisplayOrder = Convert.ToInt32(node.Element("DisplayOrder").Value),
                         MenuAction = node.Element("MenuAction").Value,
                         Menus = (parentMenuId != Convert.ToInt32(node.Element("MenuId").Value) ? LoadMenus(menus, Convert.ToInt32(node.Element("MenuId").Value)) : new List<ZMenuItem>())
                     }).ToList();
            return nodes;
        }
    }
}
