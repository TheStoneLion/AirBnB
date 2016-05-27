using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AirBnB.Startup))]
namespace AirBnB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
