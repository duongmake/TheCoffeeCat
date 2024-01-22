using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffeeCatBusinessObject.BusinessObject
{
    public class Account
    {
        public Guid AccountID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }

        public Guid RoleID {  get; set; }
        public Role Role {  get; set; }

        public Guid StaffID { get; set; }
         public Staff Staff { get; set; }

        public Guid CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
