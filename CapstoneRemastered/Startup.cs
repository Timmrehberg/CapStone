using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapstoneRemastered.Startup))]
namespace CapstoneRemastered
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
