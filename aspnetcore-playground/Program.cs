using aspnetcore_playground.Models;
using aspnetcore_playground.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BakeryDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:BakeryDbContextConnection"]);
});

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//handle incomming requests correctly: endpoint middleware, route to the views, enables mvc handle incomming requests
app.MapDefaultControllerRoute();

app.Run();
