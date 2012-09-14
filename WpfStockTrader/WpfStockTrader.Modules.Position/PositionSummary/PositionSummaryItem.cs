using Microsoft.Practices.Prism.ViewModel;

namespace WpfStockTrader.Modules.Position.PositionSummary
{
    public class PositionSummaryItem : NotificationObject
    {
        public PositionSummaryItem(string tickerSymbol)
        {
            this.tickerSymbol = tickerSymbol;
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
                if(value == null)
                {
                    tickerSymbol = value;
                } else if(tickerSymbol != value)
                {
                    tickerSymbol = value;
                    this.RaisePropertyChanged(()=>this.TickerSymbol);
                }
            }
        }
    }
}