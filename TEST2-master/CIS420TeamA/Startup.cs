using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIS420TeamA.Startup))]
namespace CIS420TeamA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
