using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Build the service provider
            _serviceProvider = ConfigureServices();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the main form (MainForm as the startup form)
            Application.Run(_serviceProvider.GetRequiredService<Startup>());
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Register DbContext and other services
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ProjectArchitecture;Trusted_Connection=True;"),
    ServiceLifetime.Scoped);

            // Register other controllers and dependencies
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
            services.AddScoped<Startup>(); // Replace with your main form

            // Build the service provider
            return services.BuildServiceProvider();
        }
    }
}