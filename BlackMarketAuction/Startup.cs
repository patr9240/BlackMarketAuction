using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlackMarketAuction.Startup))]
namespace BlackMarketAuction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
