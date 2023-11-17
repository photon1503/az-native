using FoodApp;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add configuration
IConfiguration Configuration = builder.Configuration;
builder.Services.AddSingleton<IConfiguration>(Configuration);
var cfg = Configuration.Get<AppConfig>();

// Application Insights
builder.Services.AddApplicationInsightsTelemetry();
builder.Services.AddSingleton<AILogger>();

// Add cosmos db service
CookingRepository cosmosDbService = new CookingRepository(cfg.CosmosDB.ConnectionString, cfg.CosmosDB.DBName, cfg.CosmosDB.Container);
builder.Services.AddSingleton<ICookingRepository>(cosmosDbService);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.EnableAnnotations();
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cooking Service", Version = "v1" });
});

// Cors
builder.Services.AddCors(o => o.AddPolicy("nocors", builder =>
{
    builder
        .SetIsOriginAllowed(host => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cooking Service");
    c.RoutePrefix = string.Empty;
});

app.UseCors("nocors");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();