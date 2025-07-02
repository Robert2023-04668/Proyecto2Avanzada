using DatabaseFirst.Forms.UI;
using DatabaseFirst.Models;
using DatabaseFirst.Repositories;
using DatabaseFirst.Repositories.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DatabaseFirst
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(configuration);
            services.AddDbContext<NorthwindContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
            );
            services.AddScoped<IProductRepository, ProductsRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IOrdersRepository, OrdersRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient<frmSuppliers>();
            services.AddTransient<frmCategories>();
            services.AddTransient<frmProducts>();
            services.AddTransient<frmOrders>();
            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            var main = serviceProvider.GetRequiredService<frmProducts>();
            Application.Run(main);

        }
    }
}

