using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FireworkApp.Startup))]

namespace FireworkApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.MapSignalR();
            app.MapAzureSignalR(this.GetType().FullName);
        }
    }
}
