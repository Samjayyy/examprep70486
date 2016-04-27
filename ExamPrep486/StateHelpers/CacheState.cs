using System.Web;

namespace ExamPrep486.StateHelpers
{
    internal class CacheState : IStateHelper
    {
        public string GetLastVisit()
        {
            return (HttpRuntime.Cache.Get("lastvisit") ?? "None").ToString();
        }

        public void SetLastVisit(string page)
        {
            HttpRuntime.Cache.Insert("lastvisit", page);
        }
    }
}
