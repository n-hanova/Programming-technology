using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OlympMotors.Startup))]
namespace OlympMotors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
