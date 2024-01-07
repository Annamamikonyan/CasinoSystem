using AutoMapper;
using Casino.BLL.Contracts;
using Casino.BLL.Services;
using Casino.DAL.EntityModels;
using Casino.DAL.Repositories.PlayerRepository;
using Microsoft.EntityFrameworkCore;

namespace Casino.API.Extensions
{
    public static class CasinoServicesRegistrations
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {   
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            // here must be all the used service injections
            // .......
            services.AddScoped<IPlayerBLL, PlayerBLL>();

        }
        public static void AddSqlServer(this WebApplicationBuilder builder)
        {
            var connectionString = string.Empty;

            ConfigurationManager configuration = builder.Configuration;
            if (configuration != null)
                connectionString = configuration.GetValue<string>("ConnectionStrings:CasinoConnectionString");

            if (!string.IsNullOrEmpty(connectionString))
            {
                builder.Services.AddDbContext<CasinoContext>(options =>
                           options.UseSqlServer(connectionString));
            }
        }
    }
}
