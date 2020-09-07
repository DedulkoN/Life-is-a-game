using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Life_is_a_game.Startup))]
namespace Life_is_a_game
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);           
        }
    }
}
