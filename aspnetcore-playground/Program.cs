using aspnetcore_playground.Models;
using aspnetcore_playground.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//handle incomming requests correctly: endpoint middleware, route to the views, enables mvc handle incomming requests
app.MapDefaultControllerRoute();

app.Run();
