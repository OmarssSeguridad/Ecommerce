using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_CommerceF.Startup))]
namespace E_CommerceF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
