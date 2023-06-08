using Infrastructure.Shared.Files;
using Infrastructure.Shared.Repositories;
using Proyecto.ApplicationLayer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Grupo 0
builder.Services.AddTransient<WeatherSummaryService, WeatherSummaryService>();
builder.Services.AddTransient<IFileRepository, FileRepository>();
builder.Services.AddTransient<IWeatherFileRepository, WeatherFileRepository>();

// Agregar los demás servicios abajo.





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
