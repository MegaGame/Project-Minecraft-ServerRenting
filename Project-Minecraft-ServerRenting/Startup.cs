using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_Minecraft_ServerRenting.Startup))]
namespace Project_Minecraft_ServerRenting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
