using System;
using System.Text;
using CityHall.Web.Data;
using CityHall.Web.Models;
using CityHall.Web.Models.Users;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace CityHall.Web.Services.Extensions
{
	public static class AuthenticationService
	{
        public static void AddAuth(this IServiceCollection services, IConfiguration configuration)
        {
            // JWT
            var audience = configuration["Jwt-Audience"];
            var issuer = configuration["Jwt-Issuer"];
            var key = configuration["Jwt-SecretKey"];
            var keyBytes = Encoding.UTF8.GetBytes(key);

            services
                .AddAuthentication(options =>
                {
                    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                })
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
                {
                    options.LoginPath = "/backOffice/account/";
                    options.LogoutPath = "/backOffice/account/logout";
                    options.ExpireTimeSpan = TimeSpan.FromHours(2);
                    options.SlidingExpiration = true;

                    options.Events = new CookieAuthenticationEvents
                    {
                        OnRedirectToLogin = (context) =>
                        {
                            context.Response.Redirect("/backOffice/account" + context.Request.QueryString);
                            return Task.CompletedTask;
                        },
                    };
                })
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.SaveToken = true;

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidAudience = audience,
                        ValidIssuer = issuer,
                        ValidateLifetime = true,
                        RequireExpirationTime = true,
                        ClockSkew = TimeSpan.Zero,
                    };
                });

            // JWT + MVC
            services.AddAuthorization();
        }


        public static void SetupUserIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, UserRole>((options) =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.SignIn.RequireConfirmedEmail = true;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // Password
                options.Password.RequiredLength = 8;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);

                // User settings.
                options.User.RequireUniqueEmail = true;
            });
        }
    }
}

