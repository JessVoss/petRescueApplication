using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(petRescueApplication.Startup))]
namespace petRescueApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
