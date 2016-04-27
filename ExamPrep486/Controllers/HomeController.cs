using ExamPrep486.StateHelpers;
using System.Web.Mvc;

namespace ExamPrep486.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStateHelper _stateHelper;
        public HomeController() : base()
        {
             _stateHelper = new CacheState();
            // _stateHelper = new SessionState(this);
            // _stateHelper = new CookieState(this);
            //_stateHelper = new QueryStringState(this);
            //_stateHelper = new ContextItemsState();
            //_stateHelper = new ProfileState();
        }

        /// <summary>
        /// Example of using state
        /// </summary>
        public ActionResult Index()
        {
            ViewBag.LastVisit = _stateHelper.GetLastVisit();
            _stateHelper.SetLastVisit("Home");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.LastVisit = _stateHelper.GetLastVisit();
            ViewBag.Message = "This page should tell what the application is about.";
            _stateHelper.SetLastVisit("About");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.LastVisit = _stateHelper.GetLastVisit();
            ViewBag.Message = "Your contact page.";
            _stateHelper.SetLastVisit("Contact");
            return View();
        }
    }
}