using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffeeCatBusinessObject;

namespace TheCoffeeCatService.IServices
{
    public interface IStaffService
    {
        List<Staff> GetAllStaff();
    }
}
