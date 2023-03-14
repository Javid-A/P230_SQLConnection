using Microsoft.EntityFrameworkCore;
using P230_SQLConnection.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseSqlServer(@"Server=DESKTOP-NH7SON4\SQLEXPRESS;Database=P230UpConstruction;Integrated Security=true");
});
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(
    pattern: "{controller=home}/{action=index}/{id?}",
    name: "default"
    );

app.Run();
