using System;
using System.Windows.Input;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using PrismSandbox.ModuleA.ViewModels;

namespace PrismSandbox.ModuleA.Commands
{
    public class ShowModuleAViewCommand : ICommand
    {
        //private ModuleATaskButtonViewModel viewModel;

        public ShowModuleAViewCommand(ModuleATaskButtonViewModel viewModel)
        {
            //this.viewModel = viewModel;
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
            var moduleBNavigator = new Uri("ModuleANavigator", UriKind.Relative);
            regionManager.RequestNavigate("NavigatorRegion", moduleBNavigator);

            /* We invoke the NavigationCompleted() callback method in the next  
             * navigation request since it is the last request we have to make. */

            // Show Workspace
            var moduleBWorkspace = new Uri("ModuleAWorkspace", UriKind.Relative);
            regionManager.RequestNavigate("WorkspaceRegion", moduleBWorkspace);//, NavigationCompleted);
        }

        private void NavigationCompleted(NavigationResult result)
        {
            // Exit if navigation was not successful
            if (result.Result != true) return;

            // Publish ViewRequestedEvent
            //var eventAggregator = ServiceLocator.Current.GetInstance<IEventAggregator>();
            //var navigationCompletedEvent = eventAggregator.GetEvent<NavigationCompletedEvent>();
            //navigationCompletedEvent.Publish("ModuleA");
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
