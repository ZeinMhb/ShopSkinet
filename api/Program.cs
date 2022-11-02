using infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using core.Interfaces;

var builder = WebApplication.CreateBuilder(args);
// var host = CreateHostBuilder(args).Build();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IproductRepository, ProductRepository>();
builder.Services.AddDbContext<StoreContext>(x =>
 x.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

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
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var loggerFactory = services.GetRequiredService<ILoggerFactory>();
    try
    {
        var context = services.GetRequiredService<StoreContext>();
        await context.Database.MigrateAsync();
    }
    catch
    {
        var logger = loggerFactory.CreateLogger<Program>();
        logger.LogError("An error occurred while migrating the database.");
    }
}

app.Run();
