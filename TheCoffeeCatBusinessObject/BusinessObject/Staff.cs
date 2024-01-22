using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffeeCatBusinessObject.BusinessObject;

namespace TheCoffeeCatBusinessObject
{
    public class Staff
    {
        public Guid StaffID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
    

        public CoffeeShop CoffeeShop { get; set; }
        public Guid CoffeeID { get; set; }
    }
}
