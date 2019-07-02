using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssetManager.Startup))]
namespace AssetManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
