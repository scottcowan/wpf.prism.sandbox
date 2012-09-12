using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using WpfStockTrader.Common;
using WpfStockTrader.Modules.News.Article;

namespace WpfStockTrader.Modules.News
{
    public class NewsModule : IModule
    {
        public void Initialize()
        {
            var regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.ResearchRegion, typeof(ArticleView));            

        }
    }
}
