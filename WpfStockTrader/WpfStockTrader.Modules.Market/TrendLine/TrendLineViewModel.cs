using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.ViewModel;
using WpfStockTrader.Common;

namespace WpfStockTrader.Modules.Market.TrendLine
{
    public class TrendLineViewModel : NotificationObject
    {
        public TrendLineViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<TickerSymbolSelectedEvent>().Subscribe(this.TickerSymbolChanged);
        }

        private void TickerSymbolChanged(string newTickerSymbol)
        {
            this.TickerSymbol = newTickerSymbol;
        }

        string tickerSymbol;
        public string TickerSymbol
        {
            get
            {
                return tickerSymbol;
            }
            set
            {
                if(tickerSymbol != value)
                {
                    tickerSymbol = value;
                    this.RaisePropertyChanged(()=>this.TickerSymbol);
                }
            }
        }
    }
}
