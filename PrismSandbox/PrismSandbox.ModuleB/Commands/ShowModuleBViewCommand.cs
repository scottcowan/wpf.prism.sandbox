using System;
using System.Windows.Input;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using PrismSandbox.Common.Events;
using PrismSandbox.ModuleB.ViewModels;

namespace PrismSandbox.ModuleB.Commands
{
    public class ShowModuleBViewCommand : ICommand
    {
        private ModuleBTaskButtonViewModel viewModel;

        public ShowModuleBViewCommand(ModuleBTaskButtonViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            // Initialize
            var regionManager = (RegionManager)ServiceLocator.Current.GetInstance<IRegionManager>();

            // Show Navigator
            var moduleBNavigator = new Uri("ModuleBNavigator", UriKind.Relative);
            regionManager.RequestNavigate("NavigatorRegion", moduleBNavigator);

            /* We invoke the NavigationCompleted() callback method in the next  
             * navigation request since it is the last request we have to make. */

            // Show Workspace
            var moduleBWorkspace = new Uri("ModuleBWorkspace", UriKind.Relative);
            regionManager.RequestNavigate("WorkspaceRegion", moduleBWorkspace, NavigationCompleted);
        }

        private void NavigationCompleted(NavigationResult result)
        {
            // Exit if navigation was not successful
            if (result.Result != true) return;

            // Publish ViewRequestedEvent
            var eventAggregator = ServiceLocator.Current.GetInstance<IEventAggregator>();
            var navigationCompletedEvent = eventAggregator.GetEvent<NavigationCompletedEvent>();
            navigationCompletedEvent.Publish("ModuleA");
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
