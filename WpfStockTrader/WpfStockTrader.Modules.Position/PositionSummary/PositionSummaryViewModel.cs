using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.ViewModel;
using WpfStockTrader.Common;

namespace WpfStockTrader.Modules.Position.PositionSummary
{
    public class PositionSummaryViewModel : NotificationObject
    {
        private PositionSummaryItem currentPositionSummaryItem;
        private IEventAggregator eventAggregator;

        public IObservablePosition Position { get; set; }

        public PositionSummaryViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            this.Position = new ObservablePosition();

            this.currentPositionSummaryItem = new PositionSummaryItem("NOT SELECTED");
        }

        public string HeaderInfo
        {
            get { return "POSITION"; }
        }

        public PositionSummaryItem CurrentPositionSummaryItem
        {
            get { return currentPositionSummaryItem; }
            set
            {
                if(currentPositionSummaryItem != value)
                {
                    if(currentPositionSummaryItem != value)
                    {
                        currentPositionSummaryItem = value;
                        this.RaisePropertyChanged(()=>this.CurrentPositionSummaryItem);
                        if(currentPositionSummaryItem != null)
                        {
                            eventAggregator.GetEvent<TickerSymbolSelectedEvent>().Publish(
                                CurrentPositionSummaryItem.TickerSymbol);
                        }
                    }
                }
            }
        }

    }
}
