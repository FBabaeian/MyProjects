using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelManagmentSystem.Startup))]
namespace HotelManagmentSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
