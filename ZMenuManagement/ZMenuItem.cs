using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMenuManagement
{
    public class ZMenuItem
    {
        public int MenuId { get; set; }
        public int ParentMenuId { get; set; }
        public string MenuTitle { get; set; }
        public int DisplayOrder { get; set; }
        public string MenuAction { get; set; }
        public List<ZMenuItem> Menus { get; set; }

        public ZMenuItem()
        {
            ParentMenuId = 0;
            Menus = new List<ZMenuItem>();
        }

        public override string ToString()
        {
            return MenuTitle;
        }
    }
}
