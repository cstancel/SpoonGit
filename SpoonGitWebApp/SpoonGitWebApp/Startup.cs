using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpoonGitWebApp.Startup))]
namespace SpoonGitWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
