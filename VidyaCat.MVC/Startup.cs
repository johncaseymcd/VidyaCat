using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidyaCat.MVC.Startup))]
namespace VidyaCat.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
