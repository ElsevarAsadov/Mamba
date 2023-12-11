using Business.Services.implementations;
using Business.Services.Interfaces;
using Core.Repositories.Interfaces;
using Data.DAL;
using Data.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});


builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeerService, EmployeerService>();


builder.Services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();
builder.Services.AddScoped<ISocialMediaAccountService, SocialMediaAccountService>();


builder.Services.AddScoped<IEmployeePositionRepository, EmployeePositionRepository>();
builder.Services.AddScoped<IEmployeePositionService, EmployeePositionService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "admin",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
