using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Database_Application.Classes
{
    public class Order
    {
        public int Id { get; set; }

        public Food Food { get; set; }

        public Size Size { get; set; }

        public int FoodQuantity { get; set; }

        public string ExtraNames { get; set; }

        public ICollection<Extra> Extras { get; set; }
    }
}
