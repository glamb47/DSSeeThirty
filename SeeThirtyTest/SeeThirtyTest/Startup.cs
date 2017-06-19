using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeeThirtyTest.Startup))]
namespace SeeThirtyTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
