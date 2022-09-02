
using Data;
using Microsoft.EntityFrameworkCore;
using Utils;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(opt =>
    opt.UseInMemoryDatabase(databaseName: "startup"));

builder.Services.AddSingleton<DevelopmentData>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Services.GetRequiredService<DevelopmentData>().AddDevelopmentData();

app.Run();
