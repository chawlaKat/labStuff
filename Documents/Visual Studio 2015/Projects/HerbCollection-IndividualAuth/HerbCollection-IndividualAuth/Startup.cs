using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HerbCollection_IndividualAuth.Startup))]
namespace HerbCollection_IndividualAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
