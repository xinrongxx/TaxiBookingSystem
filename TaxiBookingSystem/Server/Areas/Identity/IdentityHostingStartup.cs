using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaxiBookingSystem.Server.Data;
using TaxiBookingSystem.Server.Models;

[assembly: HostingStartup(typeof(TaxiBookingSystem.Server.Areas.Identity.IdentityHostingStartup))]
namespace TaxiBookingSystem.Server.Areas.Identity
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