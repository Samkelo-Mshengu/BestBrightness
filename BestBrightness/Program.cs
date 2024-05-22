
using BestBrightness.Logic;
using BusinesssLogic.AppSetting;
using BusinesssLogic.BranchLogic;
using BusinesssLogic.CountryLogic;
using BusinesssLogic.LogicInterface;
using BusinesssLogic.ProvincesLogic;
using BusinesssLogic.SettingLogic;
using DataLogic;
using DataLogic.LogicInterfaces;
using ElmahCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Repository.BranchRepository;
using Repository.CountriesRepository;
using Repository.ProductRepository;
using Repository.ProvinceRepository;
using Repository.RepositoryInterfaces;
using Repository.SettingsRepository;


IConfiguration Configuration;
IWebHostEnvironment webHostEnvironment;
void SetupEnviornment(IConfiguration configuration, IWebHostEnvironment env)
{
    var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
        .AddEnvironmentVariables();

    Configuration = configuration;
    webHostEnvironment = env;
}
void SetupCorsPolicy(IServiceCollection services)
{
    services.AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder.WithOrigins(AppSettings.BaseUrl)
                .WithMethods("GET,HEAD,PUT,PATCH,POST,DELETE")
                .WithHeaders("Content-Type, Accept");
        });

        options.AddPolicy("ReportGetPolicy",
            builder =>
            {
                builder.WithOrigins(AppSettings.BaseUrl)
                    .WithMethods("GET")
                    .WithHeaders("Content-Type, Accept");
            });

        options.AddPolicy("AllowAllGet",
            builder =>
            {
                builder.AllowAnyOrigin()
                    .WithMethods("GET")
                    .WithHeaders("Content-Type, Accept");
            });
    });
}
void SetupInjectionDependency(WebApplicationBuilder webApplicationBuilder)
{
    webApplicationBuilder.Services.AddScoped<DefaultContext>();
    webApplicationBuilder.Services.AddTransient<iProducts, ProductRepo>();
    webApplicationBuilder.Services.AddTransient<IProductLogic, ProductLogic>();

    webApplicationBuilder.Services.AddTransient<iSettingsRepository, SettingsRepository>();
    webApplicationBuilder.Services.AddTransient<ISettingsLogic, SettingsLogic>();

    webApplicationBuilder.Services.AddTransient<iProvince, ProvinceRepo>();
    webApplicationBuilder.Services.AddTransient<IProvinceLogic, ProvinceLogic>();


    webApplicationBuilder.Services.AddTransient<iCountry, CountriesRepository>();
    webApplicationBuilder.Services.AddTransient<ICountriesLogic, CountriesLogic>();


    webApplicationBuilder.Services.AddTransient<IBranchLogic, BranchLogic>();
    webApplicationBuilder.Services.AddTransient<iBranch, BranchRepo>();

}
var builder = WebApplication.CreateBuilder(args);

SetupEnviornment(builder.Configuration, builder.Environment);
builder.Services.AddDbContext<DefaultContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddElmah();
//builder.Services.InqolaConnectionStringService(AppSettings.ConnectionString);

//builder.Services.AddDbContext<DefaultContext>(options => options.UseSqlServer(AppSettings.ConnectionString));


SetupInjectionDependency(builder);
SetupCorsPolicy(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseStatusCodePages(async context =>
{
    if (context.HttpContext.Request.Path.StartsWithSegments("/api"))
    {
        if (!context.HttpContext.Response.ContentLength.HasValue || context.HttpContext.Response.ContentLength == 0)
        {
            // You can change ContentType as json serialize
            context.HttpContext.Response.ContentType = "text/plain";
            await context.HttpContext.Response.WriteAsync($"Status Code: {context.HttpContext.Response.StatusCode} - {ReasonPhrases.GetReasonPhrase(context.HttpContext.Response.StatusCode)}");
        }
    }
    else
    {
        // You can ignore redirect
        context.HttpContext.Response.Redirect($"/Error/{context.HttpContext.Response.StatusCode}");
    }
});

app.UseRouting();

app.UseAuthorization();
app.UseElmah();
app.MapRazorPages();
app.MapDefaultControllerRoute();
app.UseCors();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});
app.MapControllers();

app.Run();
