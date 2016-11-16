using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GlucoStamp.Startup))]
namespace GlucoStamp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
