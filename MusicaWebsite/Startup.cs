using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicaWebsite.Startup))]
namespace MusicaWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
