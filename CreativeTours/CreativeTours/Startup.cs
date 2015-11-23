using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreativeTours.Startup))]
namespace CreativeTours
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
