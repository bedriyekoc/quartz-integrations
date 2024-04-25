using Microsoft.Extensions.DependencyInjection;
using QuartzIntegrations.Core.Configurations;
using QuartzInfrastructure;
var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<JobSettings>(configuration.GetSection("JobSetting"));

builder.Services.RegisterBackgroundServices(configuration.GetSection("JobSetting").Get<JobSettings>() ?? new JobSettings());
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
