using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DroneGraphDB.Startup))]
namespace DroneGraphDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
