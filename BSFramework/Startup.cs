using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BSFramework.Startup))]
namespace BSFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
