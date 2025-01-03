using Microsoft.EntityFrameworkCore;
using Rutro.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    //string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;
    string connectionString = builder.Configuration.GetValue<string>("MyConnectionStrings:DefaultConnection")!;
    options.UseSqlServer(connectionString);

});
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
    name: "areas",
    pattern: "{area=User}/{controller=Home}/{action=Index}/{id?}");

app.Run();
