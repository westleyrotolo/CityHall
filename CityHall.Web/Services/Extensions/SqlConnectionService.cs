using System;
using System.Globalization;
using CityHall.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace CityHall.Web.Services.Extensions
{
	public static class SqlConnectionService
	{
        public static void AddPostgreSqlConnection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("CityHallDbPgSqlConnection");
                options.UseNpgsql(connectionString, npgsqlOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 3,
                        maxRetryDelay: TimeSpan.FromSeconds(Math.Pow(2, 3)),
                        errorCodesToAdd: null);
                })
                .UseSnakeCaseNamingConvention(CultureInfo.InvariantCulture);
            });
        }
    }
}

