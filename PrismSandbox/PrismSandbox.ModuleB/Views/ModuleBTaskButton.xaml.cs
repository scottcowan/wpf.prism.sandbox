using System.Windows.Controls;
using Microsoft.Practices.Prism.Regions;
using PrismSandbox.ModuleB.ViewModels;

namespace PrismSandbox.ModuleB.Views
{
    /// <summary>
    /// Interaction logic for ModuleBTaskButton.xaml
    /// </summary>
    [ViewSortHint("02")]
    public partial class ModuleBTaskButton : UserControl
    {
        public ModuleBTaskButton(ModuleBTaskButtonViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
