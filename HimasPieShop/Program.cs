//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddRazorPages();

//var app = builder.Build();

//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();

//using HimasPieShop;

//CreateHostBuilder(args).Build().Run();

//public static IHostBuilder CreateHostBuilder(string[] args) =>
//    Host.CreateDefaultBuilder(args)
//    .ConfigureWebHostDefaults(webBuilder =>
//    {
//        webBuilder.UseStartup<Startup>();
//    });
namespace BethanysPieShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}