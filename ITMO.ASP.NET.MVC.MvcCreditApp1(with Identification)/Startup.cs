using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITMO.ASP.NET.MVC.MvcCreditApp1_with_Identification_.Startup))]
namespace ITMO.ASP.NET.MVC.MvcCreditApp1_with_Identification_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
