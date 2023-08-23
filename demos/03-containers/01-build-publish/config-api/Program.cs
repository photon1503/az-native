using System;
using ConfigApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Azure.Identity;

// Configure Services
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the ioc container
IConfiguration Configuration = builder.Configuration;
builder.Services.AddSingleton(Configuration);
var cfg = Configuration.Get<AppConfig>();

if (cfg.App.UseAppConfig)
{
    builder.Configuration.AddAzureAppConfiguration(options =>
    {
        options.Connect(cfg.App.AppConfigConnection)        
        .Select("*", cfg.App.Environment);
    });
}

builder.Services.AddControllers();
builder.Services.AddCors(o => o.AddPolicy("nocors", builder =>
{
    builder
        .SetIsOriginAllowed(host => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials();
}));

// Open Api
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = cfg.App.Title, Version = "v1" });
});

var app = builder.Build();

// Request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// cors
app.UseCors("nocors");

// swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
   {
       c.SwaggerEndpoint("/swagger/v1/swagger.json", cfg.App.Title);
       c.RoutePrefix = string.Empty;
   }
);

app.MapControllers();
app.Run();
