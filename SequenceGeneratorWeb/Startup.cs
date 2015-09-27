using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SequenceGeneratorWeb.Startup))]
namespace SequenceGeneratorWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
