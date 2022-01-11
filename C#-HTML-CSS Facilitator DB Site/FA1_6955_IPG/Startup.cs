using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FA1_6955_IPG.Startup))]
namespace FA1_6955_IPG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
