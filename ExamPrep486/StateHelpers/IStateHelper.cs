
namespace ExamPrep486.StateHelpers
{
    interface IStateHelper
    {
        void SetLastVisit(string page);
        string GetLastVisit();
    }
}
