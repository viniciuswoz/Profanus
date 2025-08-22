using Microsoft.EntityFrameworkCore;
using Profanus.Infrastructure;
using Profanus.Application.Interfaces;
using Profanus.Infrastructure.Repositories;
using Profanus.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? "Server=(localdb)\\mssqllocaldb;Database=ProfanusDb;Trusted_Connection=True;MultipleActiveResultSets=true";

builder.Services.AddDbContext<ProfanusDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<ISensorRepository, SensorRepository>();
builder.Services.AddScoped<SensorService>();
builder.Services.AddScoped<IDeviceService, DeviceService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
