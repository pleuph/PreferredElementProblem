using Microsoft.EntityFrameworkCore;
using PreferredElementApi.Services;
using PreferredElementData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PreferredElementDbContext>(options => 
    options.UseSqlServer("Server=localhost;Database=PreferredElement;Integrated Security=True;"));

builder.Services.AddTransient<IPreferredElementRepository, PreferredElementRepository>();
builder.Services.AddTransient<IPreferredElementService, PreferredElementService>();

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
