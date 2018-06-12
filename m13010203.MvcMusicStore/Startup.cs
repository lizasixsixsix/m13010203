using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(m13010203.MvcMusicStore.Startup))]
namespace m13010203.MvcMusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            ConfigureApp(app);
        }
    }
}
