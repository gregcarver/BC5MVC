using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BC5MVCGroupProject.Startup))]
namespace BC5MVCGroupProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
