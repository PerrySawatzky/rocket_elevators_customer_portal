using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using rocket_elevators_customer_portal.Areas.Identity.Data;


[assembly: HostingStartup(typeof(rocket_elevators_customer_portal.Areas.Identity.IdentityHostingStartup))]
namespace rocket_elevators_customer_portal.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                // services.AddDbContext<rocket_elevators_customer_portalIdentityDbContext>(options =>
                //     options.UseSqlServer(
                //         context.Configuration.GetConnectionString("rocket_elevators_customer_portalIdentityDbContextConnection")));
                // Replace with your connection string.
        var connectionString = "server=codeboxx.cq6zrczewpu2.us-east-1.rds.amazonaws.com;port=3306;database=PerrySawatzky_CP;uid=codeboxx;password=Codeboxx1!";

        // Replace with your server version and type.
        // Use 'MariaDbServerVersion' for MariaDB.
        // Alternatively, use 'ServerVersion.AutoDetect(connectionString)'.
        // For common usages, see pull request #1233.
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 25));

        // Replace 'YourDbContext' with the name of your own DbContext derived class.
        services.AddDbContext<rocket_elevators_customer_portalIdentityDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(connectionString, serverVersion)
                .EnableSensitiveDataLogging() // <-- These two calls are optional but help
                .EnableDetailedErrors()       // <-- with debugging (remove for production).
        );
                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<rocket_elevators_customer_portalIdentityDbContext>();
            });
        }
    }
}