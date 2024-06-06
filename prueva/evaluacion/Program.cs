using evaluacion.Data;
using Microsoft.EntityFrameworkCore;
using evaluacion.Services.CursosServices;
using evaluacion.Services.EstudiantesServices;
using evaluacion.Services.MatriculasServices;
using evaluacion.Services.ProfesoresServices;
using evaluacion.Services.ENPmediosServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuraciones para la conexion a la base de datos

builder.Services.AddDbContext<PruevaDbContext>(options =>
options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"),
Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")));

// mapeo controlador
builder.Services.AddControllers();


builder.Services.AddScoped<ICursosRepository, CursosRepository>();
builder.Services.AddScoped<IEstudiantesRepository, EstudiantesRepository>();
builder.Services.AddScoped<IMatriculasRepository, MatriculasRepository>();
builder.Services.AddScoped<IProfesoresRepository, ProfesoresRepository>();
builder.Services.AddScoped<IENPMediosRepository, ENPMediosRepository>();



var app = builder.Build();


//mapeo
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
