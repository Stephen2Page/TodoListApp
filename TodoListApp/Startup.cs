using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoListApp.Startup))]
namespace TodoListApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
