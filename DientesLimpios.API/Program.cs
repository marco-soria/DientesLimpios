using DientesLimpios.API.Jobs;
using DientesLimpios.API.Middlewares;
using DientesLimpios.Aplicacion;
using DientesLimpios.Identidad;
using DientesLimpios.Identidad.Modelos;
using DientesLimpios.Infraestructura;
using DientesLimpios.Persistencia;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

builder.Services.AgregarServiciosDeAplicacion();
builder.Services.AgregarServiciosDePersistencia();
builder.Services.AgregarServiciosDeInfraestructura();
builder.Services.AgregarServiciosDeIdentidad();

builder.Services.AddHostedService<RecordatorioCitasJob>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapIdentityApi<Usuario>();
app.UseManejadorExcepciones();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
