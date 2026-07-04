using Microsoft.AspNetCore.Mvc;
using MVC_App.Models;

namespace MVC_App.Controllers
{
    public class EngineeringController : Controller
    {
        // GET: EngineeringController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CurrentProjects()
        {
            var engineDepartment = new EngineeringDepartment();
            return View(engineDepartment);
        }
    }
}
