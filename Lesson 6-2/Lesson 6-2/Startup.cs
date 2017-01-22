using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson_6_2.Startup))]
namespace Lesson_6_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
