using Application.UseCases.AddCustomer;
using Domain.Contracts.Repositories.AddCustomer;
using Domain.Contracts.UseCases.AddCustomer;
using FluentValidation;
using Infra.Repository.DbContext;
using Infra.Repository.Repositories.AddCustomer;
using Gestao_de_Clientes.Models.AddCustomer;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IDbContext, Infra.Repository.DbContext.DbContext>();
builder.Services.AddScoped<IAddCustomerRepository, AddCustomerRepository>();
builder.Services.AddScoped<IAddCustomerUseCase, AddCustomerUseCase>();
builder.Services.AddTransient<IValidator<AddCustomerInput>, AddCustomerInputValidator>();


// Adicionar HttpClient
builder.Services.AddHttpClient(); // Adicione esta linha

// Add services to the container.
builder.Services.AddControllersWithViews();

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
