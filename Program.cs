using Microsoft.EntityFrameworkCore;
using PKS;
using PKS.Services;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSingleton<IPKSModelValidator, PKSModelValidator>();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<PKSContext>(options =>
        {
            options.UseLazyLoadingProxies();
            options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
        });

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

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.Run();
    }
}