using CityHall.Web.Data;
using CityHall.Web.Services.Extensions;
using Finbuckle.MultiTenant;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = builder.Configuration;
builder.Services.AddControllersWithViews();
builder.Services.AddAuth(configuration);
builder.Services.AddPostgreSqlConnection(configuration);

builder.Services.AddMultiTenant<TenantInfo>()
        .WithEFCoreStore<MultiTenantStoreDbContext, TenantInfo>()
        .WithRouteStrategy();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseMultiTenant();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();



