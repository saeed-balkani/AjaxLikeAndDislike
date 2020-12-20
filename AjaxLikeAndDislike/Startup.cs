using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxLikeAndDislike.Startup))]
namespace AjaxLikeAndDislike
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
