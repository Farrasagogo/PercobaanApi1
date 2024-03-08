using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PercobaanApi1.Models;
namespace PercobaanApi1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("api/person/{id}")]
        public ActionResult FilterId(int id)
        {
            PersonContext context = new PersonContext();
            Person person = context.FilterId(id);
            if (person != null)
            {
                return Ok(person);
            }
            else
            {
                return NotFound();
            }
        }
    }
}