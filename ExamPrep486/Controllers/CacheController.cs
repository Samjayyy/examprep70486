using System.Web.Mvc;

namespace ExamPrep486.Controllers
{
    public class CacheController : Controller
    {
        /// <summary>
        /// Example of using caching
        /// </summary>
        [OutputCache(Duration=10, NoStore = true)]
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 10, Location = System.Web.UI.OutputCacheLocation.ServerAndClient)]
        public ActionResult About()
        {
            ViewBag.Message = "This page should tell what the application is about.";
            return View();
        }

        [OutputCache(Duration = 120, VaryByParam = "samwiser")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        [ChildActionOnly]
        [OutputCache(Duration = 20000)]
        public ActionResult Welcome()
        {
            ViewBag.Message = "You are so welcome, and you will always be";
            return View();
        }


    }
}