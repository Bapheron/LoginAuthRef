using LoginAuthRef.Models;
using LoginAuthRef.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace LoginAuthRef
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();

            services.AddTransient<MyTestDbContext>();

            services.AddTransient<AuthService>();

            services.AddTransient<LoginWindow>();

            var privateServiceProvider = services.BuildServiceProvider();

            var StartWindow = privateServiceProvider.GetRequiredService<LoginWindow>();
            StartWindow.Show();
        }
    }

}
