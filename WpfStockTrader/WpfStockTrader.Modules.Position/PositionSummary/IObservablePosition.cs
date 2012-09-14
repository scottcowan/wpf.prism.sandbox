using System.Collections.ObjectModel;

namespace WpfStockTrader.Modules.Position.PositionSummary
{
    public interface IObservablePosition
    {
        ObservableCollection<PositionSummaryItem> Items { get; }
    }
}