using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Prism;
using log4net.Config;

namespace PrismSandbox
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Configure Log4Net
            XmlConfigurator.Configure();

            // Configure Bootstrapper
            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }
}
