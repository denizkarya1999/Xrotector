using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using cis_476_project.Models;
using Microsoft.EntityFrameworkCore;

namespace Xrocter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ProjectArchitecture;Trusted_Connection=True;"));
                });

    }
}