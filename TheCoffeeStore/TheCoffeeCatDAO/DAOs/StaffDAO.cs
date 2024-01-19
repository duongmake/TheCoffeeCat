using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffeeCatBusinessObject;

namespace TheCoffeeCatDAO.DAOs
{
    public class StaffDAO
    {
        private readonly TheCoffeeStoreDBContext _context;

        public StaffDAO() 
        {
            _context = new TheCoffeeStoreDBContext();
        }

        public List<Staff> GetAllStaff()
        {
            try
            {
                return _context.Staffs.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
