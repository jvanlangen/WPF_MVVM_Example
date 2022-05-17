using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace WpfAppDependencyInjection
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection services = new();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            // the MainWindowModel should be added when using DI.
            services.AddSingleton<MainWindowModel>();
            //services.AddLogging(builder =>
            // {
            //     //      builder.AddColorConsoleLogger(config);
            // });
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //var mainWindowModel = new MainWindowModel();

            // using dependency injection.
            var mainWindowModel = _serviceProvider.GetRequiredService<MainWindowModel>();
            
            mainWindowModel.Show();
        }
    }
}