using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
//helloworl
namespace Stock
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureServices(services => {
                    services.AddControllersWithViews();
                })
                .Configure(app => {
                var env = app.ApplicationServices.GetRequiredService<IWebHostEnvironment>();
                if (!env.IsDevelopment())
                {
                        app.UseExceptionHandler("/Home/Error");
                    }
                    app.UseStaticFiles();
                    app.UseRouting();
                    app.UseAuthorization();
                    app.UseEndpoints(endpoints =>
                    {
                        
                        endpoints.MapControllerRoute(
                           name: "default",
                           pattern: "{controller=Home}/{action=Index}/{id?}");
                    });



                });
    }
}


