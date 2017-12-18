using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DidlyVidly.Startup))]
namespace DidlyVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
