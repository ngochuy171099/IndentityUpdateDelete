using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserDataT1708M1.Areas.Identity.Data;
using UserDataT1708M1.Models;

[assembly: HostingStartup(typeof(UserDataT1708M1.Areas.Identity.IdentityHostingStartup))]
namespace UserDataT1708M1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UserDataT1708M1Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("UserDataT1708M1ContextConnection")));

                services.AddDefaultIdentity<UserDataT1708M1User>()
                    .AddEntityFrameworkStores<UserDataT1708M1Context>();
            });
        }
    }
}