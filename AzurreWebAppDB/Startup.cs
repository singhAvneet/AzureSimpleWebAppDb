using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzurreWebAppDB.Startup))]
namespace AzurreWebAppDB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
