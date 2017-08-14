using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpenseReport.Startup))]
namespace ExpenseReport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
