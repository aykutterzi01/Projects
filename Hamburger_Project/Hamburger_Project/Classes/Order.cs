using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Project.Classes
{
    public class Order
    {
        public Order()
        {
            Extras = new List<Extra>();
        }
        public Menus Menu { get; set; }
        public int MenuNumber { get; set; }
        public MenuSize MenuSize { get; set; }
        public List<Extra> Extras { get; set; }

    }
}
