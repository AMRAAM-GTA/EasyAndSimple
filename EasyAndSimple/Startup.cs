using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyAndSimple.Startup))]
namespace EasyAndSimple
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
