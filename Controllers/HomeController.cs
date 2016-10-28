using System;
using System.Web.Mvc;

namespace _0001_DemonstracaoMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

       [HandleError(View="EmConstrucao", ExceptionType=typeof(NotImplementedException))]
        public ActionResult Index()
        {
            throw new NotImplementedException();
            return View();
        }

    }
}
