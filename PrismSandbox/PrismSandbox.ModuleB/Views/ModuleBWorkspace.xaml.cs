using System.Windows.Controls;
using Microsoft.Practices.Prism.Regions;

namespace PrismSandbox.ModuleB.Views
{
    /// <summary>
    /// Interaction logic for ModuleBWorkspace.xaml
    /// </summary>
    public partial class ModuleBWorkspace : UserControl, IRegionMemberLifetime
    {
        public ModuleBWorkspace()
        {
            InitializeComponent();
        }

        public bool KeepAlive { get { return false; } }
    }
}
