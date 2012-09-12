using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using WpfStockTrader.Common;
using WpfStockTrader.Modules.Watch.AddWatch;
using WpfStockTrader.Modules.Watch.WatchList;

namespace WpfStockTrader.Modules.Watch
{
    public class WatchModule : IModule
    {
        public void Initialize()
        {
            var regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(WatchListView));
            regionManager.RegisterViewWithRegion(RegionNames.MainToolBarRegion, typeof (AddWatchView));
        }
    }
}
