using DatabaseFirst.Forms.UI;
using DatabaseFirst.Models;
using DatabaseFirst.Repositories;
using DatabaseFirst.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using static DatabaseFirst.Repositories.Interfaces.IProductRepository;

namespace DatabaseFirst
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
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
            services.AddTransient<frmCategories>();
            services.AddTransient<frmProducts>();
            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            var main = serviceProvider.GetRequiredService<frmCategories>();
            Application.Run(main);
          
        }
    }
}

