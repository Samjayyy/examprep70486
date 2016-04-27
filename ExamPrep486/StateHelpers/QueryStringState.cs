using System.Web.Mvc;

namespace ExamPrep486.StateHelpers
{
    internal class QueryStringState : IStateHelper
    {
        private readonly Controller _controller;
        public QueryStringState(Controller controller)
        {
            _controller = controller;
        }

        public string GetLastVisit()
        {
            return (_controller.Request.QueryString["lastvisit"] ?? "None").ToString();
        }

        public void SetLastVisit(string page)
        {
            // LastVisit meegeven in Url van view
            //_controller.Request.QueryString["lastvisit"] = page;
        }
    }
}
