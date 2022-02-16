using CityHall.Web.Data;
using CityHall.Web.Models.MultiTenant;
using CityHall.Web.Models.Users;
using CityHall.Web.Services.Extensions;
using Finbuckle.MultiTenant;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using CityHall.Web.Repositories.Interfaces;
using CityHall.Web.Models;
using CityHall.Web.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = builder.Configuration;
builder.Services.AddControllersWithViews();
builder.Services.AddAuth(configuration);
builder.Services.AddPostgreSqlConnection(configuration);
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddMultiTenant<Client>()
        .WithEFCoreStore<MultiTenantStoreDbContext, Client>()
        .WithHostStrategy()
        .WithPerTenantAuthentication();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddAppServices();
builder.Services.AddTransient<IGenericRepository<Office>, GenericRepository<Office>>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddApiVersioning(
options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;

});

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "ToDo API",
        Description = "An ASP.NET Core Web API for managing ToDo items",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseMultiTenant();
app.UseAuthentication();
app.UseAuthorization();
/*
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");
*/
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{__tenant__=}/{controller=Home}/{action=Index}");
    endpoints.MapSwagger();
});
app.MapFallbackToFile("index.html");
app.SeedDevelopment(configuration);
app.Run();



