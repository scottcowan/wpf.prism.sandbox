using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using WpfStockTrader.Common;
using WpfStockTrader.Modules.Market.TrendLine;

namespace WpfStockTrader.Modules.Market
{
    public class MarketModule : IModule
    {
        public void Initialize()
        {
            var regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.ResearchRegion, typeof(TrendLineView));            
        }
    }
}
