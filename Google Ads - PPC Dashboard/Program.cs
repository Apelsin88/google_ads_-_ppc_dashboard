using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Google_Ads___PPC_Dashboard.Data;
using Google_Ads___PPC_Dashboard.Services; // Inkludera tjänsterns namnrymd
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Google_Ads___PPC_Dashboard.Models;
using System.Text;
using Microsoft.AspNetCore.Identity.Data;

namespace Google_Ads___PPC_Dashboard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Skapa en builder för att konfigurera tjänster och appen
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddTransient<AuthService>();

            builder.Services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.PrivateKey)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
                options.AddPolicy("PPCAnalystPolicy", policy => policy.RequireRole("PPC-Analyst"));
                options.AddPolicy("CustomerPolicy", policy => policy.RequireRole("Customer"));
            });

            // Konfigurera Entity Framework och databaskontexten
            builder.Services.AddDbContext<Google_Ads___PPC_DashboardContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("Google_Ads___PPC_DashboardContext")));

            // Lägg till MVC-relaterade tjänster
            builder.Services.AddRazorPages();
            builder.Services.AddControllers();



            // Registrera alla dina tjänster för Dependency Injection
            builder.Services.AddScoped<IAdService, AdService>();
            builder.Services.AddScoped<IAdGroupService, AdGroupService>();
            builder.Services.AddScoped<AuthService>();
            builder.Services.AddScoped<IApplicationUserService, ApplicationUserService>();
            builder.Services.AddScoped<ICampaignService, CampaignService>();
            builder.Services.AddScoped<ICampaignPerformanceService, CampaignPerformanceService>();
            builder.Services.AddScoped<IConversionGoalService, ConversionGoalService>();
            builder.Services.AddScoped<ICustomReportService, CustomReportService>();
            builder.Services.AddScoped<IKeywordService, KeywordService>();
            builder.Services.AddScoped<IRefreshTokenService, RefreshTokenService>();
            builder.Services.AddScoped<IRoleService, RoleService>();
            builder.Services.AddScoped<IUserDashboardSettingService, UserDashboardSettingService>();
            builder.Services.AddScoped<IUserRoleService, UserRoleService>();

            // Bygg appen
            var app = builder.Build();

            // Konfigurera HTTP request pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            // alternativ 1
            //app.MapGet("/login", (AuthService service) =>
            //{
            //    var user = new ApplicationUser(
            //        1,
            //        "bruno.bernardes",
            //        "Bruno Bernardes",
            //        "bruno@gmail.com",
            //        "q1w2e3r4t5",
            //        ["developer"]);

            //    return service.Create(user);
            //});

            // alternativ 2
            //app.MapPost("/login", async (AuthService service, /*[FromBody]*/ LoginRequest loginRequest) =>
            //{
            //    var user = await service.AuthenticateUser(loginRequest.Username, loginRequest.Password);
            //    if (user == null)
            //    {
            //        return Results.Unauthorized();
            //    }

            //    var token = service.Create(user);
            //    return Results.Ok(new { Token = token });
            //});

            app.MapGet("/admin", () => "Admin content")
                .RequireAuthorization("AdminPolicy");

            app.MapGet("/ppc-analyst", () => "PPC Analyst content")
                .RequireAuthorization("PPCAnalystPolicy");

            app.MapGet("/customer", () => "Customer content")
                .RequireAuthorization("CustomerPolicy");

            // Mappa Razor Pages och Controllers
            app.MapRazorPages();
            app.MapControllers();

            // Kör appen
            app.Run();
        }
    }
}
