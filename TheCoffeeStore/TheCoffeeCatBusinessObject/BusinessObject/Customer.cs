using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffeeCatBusinessObject
{
    public class Customer
    {
        public Guid CustomerID {  get; set; }   
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }

        public Subscription? Subscriptions { get; set; } 

        public Guid? SubscriptionID { get; set; }

      public  List<Order> Orders { get; set; }

    }
}
