using System.Web;

namespace ExamPrep486.StateHelpers
{
    internal class ContextItemsState : IStateHelper
    {
        public string GetLastVisit()
        {
            return (HttpContext.Current.Items["lastvisit"] ?? "None").ToString();
        }

        public void SetLastVisit(string page)
        {
            HttpContext.Current.Items["lastvisit"] = page;
        }
    }
}
