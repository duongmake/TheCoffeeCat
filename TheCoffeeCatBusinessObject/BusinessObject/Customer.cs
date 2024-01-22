using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffeeCatBusinessObject.BusinessObject;

namespace TheCoffeeCatBusinessObject
{
    public class Customer
    {
        public Guid CustomerID {  get; set; }   
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public Subscription? Subscriptions { get; set; } 

        public Guid? SubscriptionID { get; set; }

        public  List<Order> Orders { get; set; }
        public List<Comment> Comments { get; set; }
        public List<CustomerPackage> CustomerPackages { get; set; }

    }
}
