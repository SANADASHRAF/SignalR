using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Security.Claims;
using System.Security.RightsManagement;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(signalRWebSecure.Startup1))]

namespace signalRWebSecure
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use(async (context, next) =>
            {
                //take username from quary of the rquest
                string userName = context.Request.Query["username"];

                if (!string.IsNullOrEmpty(userName) && userName != "undefined" && userName!="null")
                {
                    var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationType);
                    identity.AddClaim(new Claim (ClaimTypes.Name,userName));
                    if(userName.Contains("admi"))
                    {
                        identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));
                    }
                    context.Request.User =new  ClaimsPrincipal(identity);
                }
                await next();
            });
            app.MapSignalR();
        }
    }
}
