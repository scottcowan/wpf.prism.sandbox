using System.Windows;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.UnityExtensions;

namespace WpfStockTrader
{
    public class StockTraderBootstrapper : UnityBootstrapper 
    {
        protected override DependencyObject CreateShell()
        {
            return new ShellWindow();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            var moduleCatalog = new DirectoryModuleCatalog();
            moduleCatalog.ModulePath = @".\Modules";
            return moduleCatalog;
        }

        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            // Call base method
            var mappings = base.ConfigureRegionAdapterMappings();
            if (mappings == null) return null;

            // Set return value
            return mappings;
        }

        protected override ILoggerFacade CreateLogger()
        {
            return new Log4NetLogger();
        }
    }
}
