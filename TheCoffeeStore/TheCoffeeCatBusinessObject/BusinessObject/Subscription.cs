using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffeeCatBusinessObject
{
    public class Subscription
    {
        [Required]
        public Guid SubscriptionID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public float DiscountPercent { get; set; }
        [Required]
        public List<Customer> Customers { get; set; }

     }
}
