using Equity.Unified.Technologies.Api.Data;
using Equity.Unified.Technologies.Api.Repos;
using Equity.Unified.Technologies.Api.Repos.Contracts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductRepo, ProdRepo>();

//for mysql
builder.Services.AddDbContext<EquityContext>
                (options => options.UseMySql(builder.Configuration.GetConnectionString("equi_conn"), new MySqlServerVersion(new Version())));

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
