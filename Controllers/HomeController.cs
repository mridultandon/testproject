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
    public class HomeController : ControllerBase
    {
        private readonly TestContext _context;
        public HomeController(TestContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<LoginModel>> Get()
        {

            var data = _context.Set<LoginModel>().ToList();
            return data;

            // return new string[] { "value1", "value2" };
        }

        [HttpPost]
        [Route("insertRequest")]
        public IActionResult InsertRequest([FromBody]RequestModel model)
        {
            try
            {

                _context.Add(model);
                _context.SaveChanges();

                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("updateRequest")]
        public IActionResult UpdateRequest([FromBody]RequestModel model)
        {
            try
            {
                var user = _context.Set<RequestModel>().Where(x => x.RequestId == model.RequestId).FirstOrDefault();
                if (user != null)
                {
                    user.Comment = model.Comment;
                    user.IsApproved = model.IsApproved;
                    _context.Update(user);
                    _context.SaveChanges();
                }
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("GetUserList")]
        public IActionResult GetUserList()
        {
            try
            {
                IEnumerable<RequestViewModel> data = from request in _context.Set<RequestModel>()
                                                     join user in _context.Set<LoginModel>() on request.UserId equals user.UserId

                                                     select new RequestViewModel
                                                     {
                                                         RequestId = request.RequestId,
                                                         UserName = user.UserName,
                                                         Comment = request.Comment,
                                                         Description = request.Description,
                                                         IsApproved = request.IsApproved

                                                     };
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


    }
}
