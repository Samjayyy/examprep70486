using System.Web;
using System.Web.Mvc;

namespace ExamPrep486.StateHelpers
{
    internal class CookieState : IStateHelper
    {
        private readonly Controller _controller;
        public CookieState(Controller controller)
        {
            _controller = controller;
        }

        public string GetLastVisit()
        {
            return (_controller.Request.Cookies["lastvisit"]?.Value ?? "None").ToString();
        }

        public void SetLastVisit(string page)
        {
            _controller.Response.SetCookie(new HttpCookie("lastvisit",page));
        }
    }
}
