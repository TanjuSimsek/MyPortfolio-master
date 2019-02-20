using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPortfolio.Admin.Startup))]
namespace MyPortfolio.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
