using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReactDevelopment.Startup))]
namespace ReactDevelopment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
