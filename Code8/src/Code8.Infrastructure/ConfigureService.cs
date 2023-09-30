using Code8.Application.Common.Interfaces;
using Code8.Infrastructure.Persistance;
using Code8.Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chatverse.Application.Common.Interfaces;
using Code8.Domain.Identity;
using Code8.Application.Common.Security.Jwt;

namespace Code8.Infrastructure;
public static class ConfigureService
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
           options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        services.AddIdentityCore<Admin>(options => options.SignIn.RequireConfirmedAccount = true)
       .AddEntityFrameworkStores<AppDbContext>()
       .AddTokenProvider<DataProtectorTokenProvider<Admin>>(TokenOptions.DefaultProvider);
        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<AppDbContext>());
        services.AddIdentity<Admin, IdentityRole>(options =>
        {
            options.SignIn.RequireConfirmedAccount = true;

            // Diğer Identity ayarlarını burada yapılandırabilirsiniz
        })
.AddEntityFrameworkStores<AppDbContext>()
.AddTokenProvider<DataProtectorTokenProvider<Admin>>(TokenOptions.DefaultProvider);
        services.AddScoped<ITokenHandler, Code8.Infrastructure.Services.TokenHandler>();


        services.AddScoped<ICurrentUserService, CurrentUserService>();

        services.AddTransient<IDateTime, DateTimeService>();
        return services;
    }

}


