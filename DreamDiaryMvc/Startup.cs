using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DreamDiaryMvc.Startup))]
namespace DreamDiaryMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
