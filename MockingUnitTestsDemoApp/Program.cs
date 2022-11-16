using MockingUnitTestsDemoApp.Implementation.Repositories.Interfaces;
using MockingUnitTestsDemoApp.Implementation.Repositories;
using MockingUnitTestsDemoApp.Implementation.Services.Interfaces;
using MockingUnitTestsDemoApp.Implementation.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<ILeagueRepository, LeagueRepository>();
builder.Services.AddTransient<ITeamRepository, TeamRepository>();
builder.Services.AddTransient<IPlayerRepository, PlayerRepository>();
builder.Services.AddTransient<IPlayerService, PlayerService>();
builder.Services.AddTransient<ITeamService, TeamService>();
builder.Services.AddTransient<ILeagueService, LeagueService>();

builder.Services.AddControllersWithViews();

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
