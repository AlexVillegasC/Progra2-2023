using Infrastructure.Shared.Files;
using Infrastructure.Shared.Repositories;
using Proyecto.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddTransient<IFileRepository, FileRepository>();
builder.Services.AddTransient<IWeatherSummaryRepository, WeatherSummaryRepository>();
builder.Services.AddTransient<WeatherSummaryService, WeatherSummaryService>();

// Los demás servicios y repositorios de cada grupo se agregan abajo.




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
