using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuiteNote3.Startup))]
namespace SuiteNote3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
