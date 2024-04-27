
using BestBrightness.Logic;
using DataLogic;
using DataLogic.LogicInterfaces;
using Microsoft.EntityFrameworkCore;
using Repository.ProductRepository;
using Repository.RepositoryInterfaces;

void SetupInjectionDependency(WebApplicationBuilder webApplicationBuilder)
{
    webApplicationBuilder.Services.AddScoped<DefaultContext>();
    webApplicationBuilder.Services.AddTransient<iProducts, ProductRepo>();
    webApplicationBuilder.Services.AddTransient<IProductLogic, ProductLogic>();
    
}
var builder = WebApplication.CreateBuilder(args);
SetupInjectionDependency(builder);

builder.Services.AddDbContext<DefaultContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddRazorPages();

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

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
