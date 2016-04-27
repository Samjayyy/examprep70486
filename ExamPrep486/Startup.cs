using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamPrep486.Startup))]
namespace ExamPrep486
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
