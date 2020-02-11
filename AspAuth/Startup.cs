using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspAuth.Startup))]
namespace AspAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
