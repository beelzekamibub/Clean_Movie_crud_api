//depends on the application layer

using CleanMovie.Application;
using CleanMovie.Domain;
using CleanMovie.Infrastructure;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Register Configuration
        ConfigurationManager configuration = builder.Configuration;
        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Add databse service dependency
        builder.Services.AddDbContext<MovieDbContext>(
            opt => opt.UseSqlServer(configuration.GetConnectionString("MovieConnection"),
            b=>b.MigrationsAssembly("CleanMovie.API")));//since we actually migrating in another assembly

        builder.Services.AddScoped<IMovieService, MovieService>();
        builder.Services.AddScoped<IMovieRepository, MovieRepository>();
        

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
}