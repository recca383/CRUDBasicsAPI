using CRUDBasicsAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace CRUDBasicsAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DatabaseContext>(o =>
            {
                o.UseNpgsql(
                    "Host=ep-crimson-haze-a1j53ndi-pooler.ap-southeast-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_pNdY78WxaBhM"
                    );
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
