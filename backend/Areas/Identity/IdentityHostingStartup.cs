using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(backend.Areas.Identity.IdentityHostingStartup))]
namespace backend.Areas.Identity
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