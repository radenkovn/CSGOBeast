using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(CSGOBeast.Web.Startup))]

namespace CSGOBeast.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
