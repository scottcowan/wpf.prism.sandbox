using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.ViewModel;

namespace WpfStockTrader.Modules.Position.PositionSummary
{
    public class PositionSummaryViewModel : NotificationObject
    {
        public string HeaderInfo
        {
            get { return "POSITION"; }
        }

    }
}
