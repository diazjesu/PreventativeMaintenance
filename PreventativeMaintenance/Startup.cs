using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PreventativeMaintenance.Startup))]
namespace PreventativeMaintenance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
