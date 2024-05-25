using Gestao_de_Clientes.Conexao;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ConexaoBD>(options =>
    options.UseSqlServer("Server=sql.bsite.net\\MSSQL2016;Database=ozias_gestaoCliente;User Id=ozias_gestaoCliente;Password=12345678;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Cliente/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cliente}/{action=Index}/{id?}");

app.Run();
