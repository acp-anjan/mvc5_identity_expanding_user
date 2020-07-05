using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Expanding_Register_User.Startup))]
namespace Expanding_Register_User
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
