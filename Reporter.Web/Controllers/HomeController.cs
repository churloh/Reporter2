using System.Web.Mvc;

namespace Reporter.Web.Controllers
{
    public class HomeController : ReporterControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}