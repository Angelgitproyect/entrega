using Core.Dtos;
using Core.Entities;
using Core.Interfaces.Repository;
using Core.Interfaces.Service;
using Core.Services;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Persistence.DataContext;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); 

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //Lee todos los profile de toda la solucion;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//injection dependencies repository
builder.Services.AddScoped<IAdminInterfaces, AdminInterfaces>();
//injection dependencies service
builder.Services.AddTransient<IBaseService<Cars>, CarsService>();
builder.Services.AddTransient<ICarsService, CarsService>();

builder.Services.AddTransient<IBaseService<User>, UserService>();
builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddTransient<IBaseService<VehicleRental>, VehicleRentalService>();
builder.Services.AddTransient<IVehicleRentalService, VehicleRentalService>();

builder.Services.AddTransient<IBaseService<LocationRental>, LocationRentalService>();
builder.Services.AddTransient<ILocationRentalService, LocationRentalService>();
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

var connectionString = builder.Configuration.GetConnectionString("MySqlConnection");
builder.Services.AddDbContext<PruebaTecnicaContext>(options =>
{
    options.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
