using Microsoft.EntityFrameworkCore;
using ProjetoKatuak.Components;
using ProjetoKatuak.Data;
using ProjetoKatuak.Components.Pages;
using SQLitePCL;

var builder = WebApplication.CreateBuilder(args);

Batteries.Init();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=ProjetoKatuak.db"));

builder.Services.AddSingleton<StateContainer>();

builder.Services.AddRazorComponents().AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
