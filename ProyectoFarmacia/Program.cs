using Microsoft.EntityFrameworkCore;
using ProyectoFarmacia.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SysContext>(options =>
                options.UseMySql(builder.Configuration.GetConnectionString("conexion"), 
                Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
