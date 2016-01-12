using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Laboration_1_Client.Startup))]
namespace Laboration_1_Client
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
