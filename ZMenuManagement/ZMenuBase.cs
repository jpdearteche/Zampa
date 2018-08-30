using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZMenuManagement
{
    public abstract class ZMenuBase
    {
        public string Location { get; set; }
        public abstract List<ZMenuItem> Load();

        public ZMenuBase()
        {
            Location = string.Empty;
        }

        public ZMenuBase(string location)
        {
            Location = location;
        }

    }
}
