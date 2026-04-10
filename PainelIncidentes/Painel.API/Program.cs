using Microsoft.EntityFrameworkCore;
using Painel.Infrastructure.Data; // Importante para encontrar o ApplicationDbContext

var builder = WebApplication.CreateBuilder(args);

// 1. Configurar o banco de dados (SQL Server para o MonsterASP)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// 2. Swagger e API Explorer
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

// No futuro, aqui chamaremos nossas Controllers ou Minimal APIs de Incidentes
app.MapGet("/", () => "Painel de Incidentes API rodando!");

app.Run();