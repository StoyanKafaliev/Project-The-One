using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_WorkingWIthData.Startup))]
namespace MVC_WorkingWIthData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
