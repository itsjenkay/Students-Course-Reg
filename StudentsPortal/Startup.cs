using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentsPortal.Startup))]
namespace StudentsPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
