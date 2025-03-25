using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using W11D1Assignment11._1.Data;

namespace W11D1Assignment11._1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private ServiceProvider _serviceProvider;

        public App() {
            var services = new ServiceCollection();
            services.AddDbContext<BookContext>(options =>
                options.UseSqlite("Data Source=Books.db"));
            services.AddSingleton<MainWindow>();
            _serviceProvider = services.BuildServiceProvider();
        }

        private void OnStartup(object sender, StartupEventArgs e) {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
