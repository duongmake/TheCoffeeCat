using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffeeCatBusinessObject.BusinessObject;

namespace TheCoffeeCatBusinessObject
{
    public class Table
    {
        public Guid TableID { get; set; }
        public bool Status { get; set; }

        public CoffeeShop CoffeeShop { get; set; }
        public Guid CoffeeID { get; set; }
    }
}
