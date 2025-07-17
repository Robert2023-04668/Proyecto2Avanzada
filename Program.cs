using DatabaseFirst.Forms.UI;
using DatabaseFirst.Models;
using DatabaseFirst.Repositories;
using DatabaseFirst.Repositories.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using System.Reflection;

namespace DatabaseFirst
{
    internal static class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        [STAThread]
        private static void Main()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();

            try
            {
                // Configuración de NLog como proveedor de logging
                LogManager.LoadConfiguration("NLog.config");
              
                services.AddLogging(loggingBuilder =>
                {
                    loggingBuilder.ClearProviders();
                    loggingBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Information);
                    loggingBuilder.AddNLog();
                });

                services.AddSingleton<IConfiguration>(config);
                services.AddDbContext<NorthwindContext>(options =>
                {
                    options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
   
                });

                // Repositorios y formularios
                services.AddScoped<IProductRepository, ProductsRepository>();
                services.AddScoped<ICategoryRepository, CategoryRepository>();
                services.AddScoped<IOrdersRepository, OrdersRepository>();
                services.AddScoped<ISupplierRepository, SupplierRepository>();
                services.AddScoped<CustomerRepository>();
                services.AddScoped<IShipper, ShipperRepository>();
                services.AddScoped<IEmployee, EmployeeRepository>();
                services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

                // Formularios
                services.AddTransient<frmSuppliers>();
                services.AddTransient<frmCategories>();
                services.AddTransient<frmProducts>();
                services.AddTransient<frmOrders>();
                services.AddTransient<frmInicio>();

                var serviceProvider = services.BuildServiceProvider();

                logger.Info("Aplicación iniciada correctamente.");
                ApplicationConfiguration.Initialize();
                var mainForm = serviceProvider.GetRequiredService<frmInicio>();
                Application.Run(mainForm);
                logger.Info("Aplicación cerrada normalmente.");
            }
            catch (Exception ex)
            {
                logger.Fatal(ex, "Error fatal en el inicio de la aplicación.");
                MessageBox.Show("Ha ocurrido un error crítico. Revisa los logs para más información.");
            }
            finally
            {
                LogManager.Shutdown();
            }
        }
    }
}
