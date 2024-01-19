using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TheCoffeeCatBusinessObject;
using TheCoffeeCatService.IServices;
using TheCoffeeCatService.Services;

namespace TheCoffeeCatStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }


        [HttpGet]
        public ActionResult<List<Staff>> GetAllStaff() => _staffService.GetAllStaff();


    }
}
