using System;
using CityHall.Web.Helpers;
using CityHall.Web.Models.MultiTenant;
using CityHall.Web.Models.Users;
using Finbuckle.MultiTenant;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CityHall.Web.Data
{
    public static class Seed
    {
        public async static Task SetupStore(IMultiTenantStore<Client> store, IConfiguration configuration)
        {
            var client = new Client { Id = Guid.NewGuid().ToString(), Identifier = "CityHall", Name = "CityHall", CityTitle = "CityHall", CitySubtitle = "", Logo = "", HasNewsletter = false, Region = "Italy" };
            var templateConnection = configuration.GetConnectionString("TemplateConnection");
            client.ConnectionString = templateConnection.FormatMe(client.Identifier);
            var item = await store.TryGetByIdentifierAsync("CityHall");
            if (item == null)
            {


                await store.TryAddAsync(client);
            }
            using (var applicationDbContext = new ApplicationDbContext(client))
                await applicationDbContext.Database.EnsureCreatedAsync();

        }

        public static async void SeedDevelopment(this IApplicationBuilder app, IConfiguration config)
        {

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {

                var store = serviceScope.ServiceProvider
                    .GetRequiredService<IMultiTenantStore<Client>>();
                await SetupStore(store, config);

                var accessor = serviceScope.ServiceProvider
                    .GetRequiredService<IMultiTenantContextAccessor>();

                var multiTenantContext = new MultiTenantContext<Client>();
                var item = await store.TryGetByIdentifierAsync("CityHall");
                multiTenantContext.TenantInfo = item;
                accessor.MultiTenantContext = multiTenantContext;

                await CreateRoles(serviceScope);
                
                await CreateUser(serviceScope, "admin", "Westley", "Rotolo", "westley@outlook.it", "Rutino2022.", AppRole.SuperAdmin);


            }
        }

        private static async Task<User> CreateUser(IServiceScope serviceScope, string username, string firstName, string lastName, string email, string password, AppRole role)
        {
            UserManager<User> userManager = serviceScope.ServiceProvider
               .GetRequiredService<UserManager<User>>();

            var user = await userManager.FindByEmailAsync(email);

            if (user == null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = username
                };

                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    if (!await userManager.IsInRoleAsync(user, role.ToString()))
                        await userManager.AddToRoleAsync(user, role.ToString());
                }
            }


            return user;
        }

        private static async Task CreateRoles(IServiceScope serviceScope)
        {
            try
            {
                RoleManager<UserRole> roleManager = serviceScope.ServiceProvider
                             .GetRequiredService<RoleManager<UserRole>>();

                foreach (var appRole in Enum.GetNames(typeof(AppRole)))
                {
                    if (!await roleManager.RoleExistsAsync(appRole))
                    {
                        await roleManager.CreateAsync(new UserRole(appRole));
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

    }
}

