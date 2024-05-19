using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(ExxerIoT.UI.Web.Areas.Identity.IdentityHostingStartup))]
namespace ExxerIoT.UI.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}