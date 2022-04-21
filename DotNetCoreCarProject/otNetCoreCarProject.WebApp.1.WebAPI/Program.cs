using DotNetCoreCarProject.WebApp._2.Services.IServices;
using DotNetCoreCarProject.WebApp._2.Services.ServiceLogic;
using DotNetCoreCarProject.WebApp._3.BusinessLogic.BusinessLogic;
using DotNetCoreCarProject.WebApp._3.BusinessLogic.IBusinessLogic;
using DotNetCoreCarProject.WebApp._4.DataAccess;
using DotNetCoreCarProject.WebApp._4.DataAccess.IRepository;
using DotNetCoreCarProject.WebApp._4.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ICar, CarService>();
builder.Services.AddTransient<ICarBusinessLogic, CarBusinessLogic>();
builder.Services.AddTransient<ICarRepository, CarRepository>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Context>(x => x.UseSqlServer(connectionString));


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
