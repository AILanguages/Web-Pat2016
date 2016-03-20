using Microsoft.Owin;
using Owin;
using PatTuring2016.MVCWeb;

[assembly: OwinStartupAttribute(typeof(Startup))]
namespace PatTuring2016.MVCWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
