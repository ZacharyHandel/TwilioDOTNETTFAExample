using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TFAExample.Startup))]
namespace TFAExample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
