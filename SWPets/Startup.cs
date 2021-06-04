using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SWPets.Startup))]
namespace SWPets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
