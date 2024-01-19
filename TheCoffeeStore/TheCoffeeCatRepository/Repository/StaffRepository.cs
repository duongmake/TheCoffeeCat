using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffeeCatBusinessObject;
using TheCoffeeCatDAO.DAOs;
using TheCoffeeCatRepository.IRepository;

namespace TheCoffeeCatRepository.Repository
{
    public class StaffRepository: IStaffRepository
    {
        StaffDAO dao = new StaffDAO();

        public List<Staff> GetAllStaff() => dao.GetAllStaff();

    }
}
