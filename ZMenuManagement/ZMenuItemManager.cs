using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMenuManagement
{
    public class ZMenuItemManager
    {
        public ZMenuBase MenuReader { get; set; }
        public List<ZMenuItem> Menus { get; set; }

        public ZMenuItemManager(ZMenuBase injector)
        {
            MenuReader = injector;
        }

        public List<ZMenuItem> Load()
        {
            Menus = MenuReader.Load();
            return Menus;
        }
    }
}
