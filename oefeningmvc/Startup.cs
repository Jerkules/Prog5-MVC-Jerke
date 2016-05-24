using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OefeningMVC.Startup))]
namespace OefeningMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
