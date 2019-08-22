using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TestProject.Entities;
using TestProject.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProject.Controllers
{
    [EnableCors("AllowAllHeaders")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly TestContext _context;
        public LoginController(TestContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<LoginModel>> Get()
        {
            var data = _context.Set<LoginModel>().ToList();
            return data;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult UserLogin([FromBody]LoginViewModel model)
        {
            try{
                var user = _context.Set<LoginModel>().Where(x => x.UserName == model.UserName && x.Password == model.Password).FirstOrDefault();
                if (user == null)
                {
                    model.UserType = 0;
                }
                else
                {
                    model.UserType = user.UserType;
                }
                return Ok(user);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
