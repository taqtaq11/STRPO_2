using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(STRPO_2.Startup))]
namespace STRPO_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
