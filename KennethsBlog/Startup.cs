using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KennethsBlog.Startup))]
namespace KennethsBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
