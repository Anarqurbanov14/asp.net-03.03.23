using Serilog;
using HomeTask.Data.Context;
using HomeTask.Repository.Abstarct;
using HomeTask.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Serilog;
using HomeTask.Repository;
using FluentValidation.AspNetCore;


// Add services to the container.

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

try
{
    Log.Information("Starting web application");

    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddControllers().AddFluentValidation();
    
    builder.Host.UseSerilog(); // <-- Add this line

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddDbContext<AppDbContext>(opts =>
                                    opts.UseSqlServer(builder.Configuration.GetConnectionString("defaultServer")));

    builder.Services.AddRepositoryLazy();

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
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}




