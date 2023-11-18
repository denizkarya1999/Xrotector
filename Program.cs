using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using Xrocter.Controllers;
using Xrocter.Controllers.VaultControllers;
using Xrocter.Controllers.VaultControllers.IDControllers;
using Xrocter.Models;

namespace Xrocter
{
    internal static class Program
    {
        private static IServiceProvider _serviceProvider;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            // Build the service provider
            _serviceProvider = ConfigureServices();

            // Run the main form
            Application.Run(_serviceProvider.GetRequiredService<Form1>());
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Register services and dependencies
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ProjectArchitecture;Trusted_Connection=True;"));
            services.AddScoped<VaultController>();
            services.AddScoped<UserAccountController>();
            services.AddScoped<SecurityQuestionController>();
            services.AddScoped<CreditCardController>();
            services.AddScoped<LoginController>();
            services.AddScoped<SecurityNoteController>();
            services.AddScoped<DriversLicenseController>();
            services.AddScoped<LocalIdController>();
            services.AddScoped<PassportController>();
            services.AddScoped<SSNController>();

            // Register your forms
            services.AddScoped<Form1>(); // Replace Form1 with your main form

            // Build the service provider
            return services.BuildServiceProvider();
        }
    }
}
