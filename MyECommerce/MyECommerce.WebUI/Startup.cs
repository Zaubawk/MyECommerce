using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyECommerce.WebUI.Startup))]
namespace MyECommerce.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
