using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MonashUWCC.Startup))]
namespace MonashUWCC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
