using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetAngular.Startup))]
namespace AspNetAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
