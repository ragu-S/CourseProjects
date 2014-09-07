using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mf_intro.Startup))]
namespace mf_intro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
