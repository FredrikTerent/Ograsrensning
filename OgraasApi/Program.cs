using Microsoft.EntityFrameworkCore;
using OgraasApi.Data;
using OgraasApi.Logic;
using OgraasApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AppContext")));
builder.Services.AddTransient<IPlayer, PlayerRepository>();
builder.Services.AddTransient<IWeed, WeedRepository>();
builder.Services.AddTransient<IBoard, BoardRepository>();
builder.Services.AddTransient<ICell, CellRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var GameLogic = new GameLogic();
GameLogic.TestGame();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
