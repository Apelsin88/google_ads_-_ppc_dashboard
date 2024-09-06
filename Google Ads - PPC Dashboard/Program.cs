using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Google_Ads___PPC_Dashboard.Data;
namespace Google_Ads___PPC_Dashboard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Google_Ads___PPC_DashboardContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Google_Ads___PPC_DashboardContext") ?? throw new InvalidOperationException("Connection string 'Google_Ads___PPC_DashboardContext' not found.")));

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.MapControllers();

            app.Run();
        }
    }
}
