using CapPasCap.Infra;
using Microsoft.EntityFrameworkCore;
using CapPasCap.Infra;
using CapPasCap.Infra.Ports.Primary;
using CapPasCap.UsesCase.Entities;
using Microsoft.EntityFrameworkCore;
using CapPasCap.UsesCase;
using CapPasCap.WebService.Services;
using CapPasCap.WebService;
using CapPasCap.Infra.Dtos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbContext, ProgramContextEF>(c => c.UseInMemoryDatabase("programContextTests"));

builder.Services.AddTransient<UserAdapter>(container => new UserAdapter(container.GetService<IAuthentificationProvider>()));
builder.Services.AddTransient<ChallengeAdapter>(container => new ChallengeAdapter(container.GetService<IChallengeProvider>()));

builder.Services.AddTransient<IAuthentificationProvider, AuthentificationProviderEF>();
builder.Services.AddTransient<IChallengeProvider, ChallengeProviderEF>();

builder.Services.AddTransient<AuthentificationProviderEF>();
builder.Services.AddTransient<ChallengeProviderEF>();

builder.Services.AddTransient<IMonconverter<UserDto, User>, MonUserConverter>();

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