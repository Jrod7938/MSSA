using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using W11D1C1.Data;

namespace W11D1C1 {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private ServiceProvider _serviceProvider;

        public App() {
            // Collection of Services, add more if needed here
            ServiceCollection services = new ServiceCollection();
            services.AddDbContext<ProductContext>(option => {
                option.UseSqlite("Data Source=Products.db");
                }
            );

            services.AddSingleton<MainWindow>();
            _serviceProvider = services.BuildServiceProvider();
        }

        private void OnStartUp(object sender, StartupEventArgs e) {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}


