using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EvaluadoUtec2015.Startup))]
namespace EvaluadoUtec2015
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
