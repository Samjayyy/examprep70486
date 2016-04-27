using System.Web;

namespace ExamPrep486.StateHelpers
{
    internal class ProfileState : IStateHelper
    {
        public string GetLastVisit()
        {
            var profile = HttpContext.Current.Profile;
            return (profile.GetPropertyValue("lastvisit") ?? "None").ToString();
        }

        public void SetLastVisit(string page)
        {
            var profile = HttpContext.Current.Profile;
            profile.SetPropertyValue("lastvisit",page);
            profile.Save();
        }
    }
}
