using ExamOne.DataAccesLayer;
using Microsoft.EntityFrameworkCore;

namespace ExamOne;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<SperingContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
        var app = builder.Build();
        app.UseStaticFiles();
        app.MapControllerRoute("areas", pattern: "{area:exists}/{controller=Category}/{action=Index}/{id?}");

        app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
