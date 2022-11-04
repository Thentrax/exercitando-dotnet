using _13__Primeira_API.Context;
using Microsoft.EntityFrameworkCore;

//Para instalar a ferramenta do Entity Framework (1 vez por máquina): dotnet tool install --global dotnet-ef
//Para instalar o Entity Framework via nuget: dotnet add package Microsoft.EntityFrameworkCore.Design
//Para instalar o Entity Framework para trabalhar com SqlServer: dotnet add package Microsoft.EntityFrameworkCore.SqlServer

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Padrao")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
