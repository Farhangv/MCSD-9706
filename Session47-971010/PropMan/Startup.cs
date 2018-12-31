using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PropMan.Startup))]
namespace PropMan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
