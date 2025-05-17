using Microsoft.Extensions.Configuration;
using PokeBLL.Component.Pokemon.PokemonImplement;
using PokeDataSource.Component.Pokemon.DataSourceImplement;
using PokeDataSource.Component.Pokemon.DataSourceInterfaces;
using PokeDataSource.Configuration;
using PokeSERVICE.API_Integration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<PokeConfiguration>(
    builder.Configuration.GetSection("PokeConfiguration"));

// DAL
builder.Services.AddScoped<IApiConnection, ApiConnection>();
builder.Services.AddScoped<IPokemonListApiConnectionImp, PokemonListApiConnectionImp>();

// BLL
builder.Services.AddScoped<PokemonListImpl>();



// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<ApiConnection>();

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

app.MapGet("/", context =>
{
    context.Response.Redirect("/Pokemon/Home/PokemonList");
    return Task.CompletedTask;
});

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=PokemonList}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
