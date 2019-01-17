using System.Web.Mvc;

namespace MVC_5_Skeleton1.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Http404()
        {
            Response.StatusCode = 404;

            return View();
        }
    }
}