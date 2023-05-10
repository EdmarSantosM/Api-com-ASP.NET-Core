
using Api_com_ASP.NET_Core.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Inicio da conexao dom Banco de Dados

//string stringConexao = ConnectionString("conexaoMysql");

var stringConexao = builder.Configuration.GetConnectionString("conexaoMysql"); //Validar aqui

builder.Services.AddDbContext<DataContext>(opt => opt.UseMySql(stringConexao,ServerVersion.AutoDetect(stringConexao)));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
