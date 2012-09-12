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
using PrismSandbox.ModuleA.ViewModels;

namespace PrismSandbox.ModuleA.Views
{
    /// <summary>
    /// Interaction logic for ModuleATaskButton.xaml
    /// </summary>
    [ViewSortHint("01")]
    public partial class ModuleATaskButton : UserControl
    {
        public ModuleATaskButton(ModuleATaskButtonViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
