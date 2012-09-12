using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Practices.Prism.Regions;

namespace WpfStockTrader.Modules.Position.PositionSummary
{
    /// <summary>
    /// Interaction logic for PositionPieChartView.xaml
    /// </summary>
    [ViewSortHint("02")]
    public partial class PositionPieChartView : UserControl
    {
        public PositionPieChartView(PositionPieChartViewModel viewModel)
        {
            InitializeComponent();
        }
    }
}
