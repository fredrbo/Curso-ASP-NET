using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.Controllers
{
    public class ProfessorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
