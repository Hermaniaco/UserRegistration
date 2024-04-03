using Microsoft.EntityFrameworkCore;
using UserRegistration.Data;
using UserRegistration.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserRepository, IUserRepository>();

//Configuração do banco de dados
builder.Services.AddEntityFrameworkSqlite()
    .AddDbContext<RegistrationContext>
    (options => options.UseSqlite(builder.Configuration.GetConnectionString("DataBase")));

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
