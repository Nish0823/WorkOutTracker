using Microsoft.AspNetCore.Mvc;

namespace WorkOutTracker.Controllers.WorkOutController
{
    public class WorkOutController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


    }


}
