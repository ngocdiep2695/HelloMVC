using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week6_Example_Web1.Startup))]
namespace Week6_Example_Web1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
