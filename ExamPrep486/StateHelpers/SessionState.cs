using System.Web.Mvc;

namespace ExamPrep486.StateHelpers
{
    internal class SessionState : IStateHelper
    {
        private readonly Controller _controller;
        public SessionState(Controller controller)
        {
            _controller = controller;
        }

        public string GetLastVisit()
        {
            return (_controller.Session["lastvisit"] ?? "None").ToString();
        }

        public void SetLastVisit(string page)
        {
            _controller.Session["lastvisit"] = page;
        }
    }
}
