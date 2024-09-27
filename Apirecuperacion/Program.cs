using Microsoft.EntityFrameworkCore;
using tallerrecuperaciondawa.Entidades;
using tallerrecuperaciondawa.Repositorio;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddCors(options => options.AddPolicy("PeliApp",
    builder => builder.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()));

builder.Services.AddDbContext<AplicationDbContext>(options =>
options.UseSqlServer("name=DefaultConnection"));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepositorioReferencia, RepositorioReferencia>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("PeliApp");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
