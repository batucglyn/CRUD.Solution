using ContactsManager.Core.Domain.IdentityEntities;
using CRUDExample.Middleware;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repositories;
using RepositoryContracts;
using Serilog;
using ServiceContracts;
using Services;

var builder = WebApplication.CreateBuilder(args);
//Serilog
builder.Host.UseSerilog((HostBuilderContext context, IServiceProvider services, LoggerConfiguration loggerConfiguration) =>
{

    loggerConfiguration
    .ReadFrom.Configuration(context.Configuration) //read configuration settings from built-in IConfiguration
    .ReadFrom.Services(services); //read out current app's services and make them available to serilog
});
builder.Services.AddScoped<ICountriesRepository, CountriesRepository>();
builder.Services.AddScoped<IPersonsRepository, PersonsRepository>();

builder.Services.AddScoped<ICountriesService, CountriesService>();



builder.Services.AddScoped<IPersonsAdderService, PersonsAdderService>();
builder.Services.AddScoped<IPersonsGetterService, PersonsGetterService>();
builder.Services.AddScoped<IPersonsDeleterService, PersonsDeleterService>();
builder.Services.AddScoped<IPersonsUpdaterService, PersonsUpdaterService>();
builder.Services.AddScoped<IPersonsSorterService, PersonsSorterService>();

builder.Services.AddDbContext<CrudDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//Identity
builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
{
    options.Password.RequiredLength = 5;



})
    .AddEntityFrameworkStores<CrudDbContext>()
    // 4 generic parametre (TUser, TRole, TContext, TKey)
    .AddUserStore<UserStore<ApplicationUser, ApplicationRole, CrudDbContext, Guid>>()
    .AddRoleStore<RoleStore<ApplicationRole, CrudDbContext, Guid>>()
    .AddDefaultTokenProviders();
builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build(); //enforces authoriation policy (user must be authenticated) for all the action methods
});

builder.Services.ConfigureApplicationCookie(options => {
    options.LoginPath = "/Account/Login";
});

builder.Services.AddControllersWithViews();
var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseExceptionHandlingMiddleware();
}

Rotativa.AspNetCore.RotativaConfiguration.Setup("wwwroot", wkhtmltopdfRelativePath: "Rotativa");
app.UseStaticFiles();          // 1 - statik dosyalar
app.UseRouting();              // 2 - endpoint keþfi (ÖNEMLÝ)
app.UseAuthentication();       // 3 - kimlik doðrulama cookiesi okunur
app.UseAuthorization();        // 4 - [Authorize] / fallback policy çalýþýr
app.MapControllers();          // 5 - MVC endpoint’leri eþlenir
app.Run();
