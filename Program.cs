using Front_To_Back_Project.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Default")));


var app = builder.Build();

app.MapDefaultControllerRoute();
app.UseStaticFiles();
app.Run();
