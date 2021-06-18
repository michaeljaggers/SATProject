using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SATProject.UI.Startup))]
namespace SATProject.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
