using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ulatina.avanzada.calentamiento.Startup))]
namespace ulatina.avanzada.calentamiento
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
