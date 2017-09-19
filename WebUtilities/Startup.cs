using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebUtilities.Startup))]
namespace WebUtilities
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
