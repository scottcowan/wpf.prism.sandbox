using System.Collections.ObjectModel;

namespace WpfStockTrader.Modules.Position.PositionSummary
{
    class ObservablePosition : IObservablePosition
    {
        public ObservableCollection<PositionSummaryItem> Items { get; private set; }

        public ObservablePosition()
        {
            PopulateItems();
        }

        private void PopulateItems()
        {
            Items = new ObservableCollection<PositionSummaryItem>();
            Items.Add(new PositionSummaryItem(tickerSymbol:"STOCK0"));
            Items.Add(new PositionSummaryItem(tickerSymbol: "STOCK2"));
            Items.Add(new PositionSummaryItem(tickerSymbol: "STOCK3"));
            Items.Add(new PositionSummaryItem(tickerSymbol: "STOCK6"));
            Items.Add(new PositionSummaryItem(tickerSymbol: "STOCK7"));
        }
    }
}