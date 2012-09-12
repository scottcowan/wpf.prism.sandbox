﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using PrismSandbox.Common;
using PrismSandbox.Common.BaseClasses;
using PrismSandbox.Common.Events;
using PrismSandbox.ModuleA.Commands;

namespace PrismSandbox.ModuleA.ViewModels
{
    public class ModuleATaskButtonViewModel : ViewModelBase, INavigationAware
    {
        public ModuleATaskButtonViewModel()
        {
            this.Initialize();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        private void Initialize()
        {
            // Initialize command properties
            this.ShowModuleAView = new ShowModuleAViewCommand(this);

            // Initialize administrative properties
            this.IsChecked = false;

            // Subscribe to Composite Presentation Events
            var eventAggregator = ServiceLocator.Current.GetInstance<IEventAggregator>();
            var navigationCompletedEvent = eventAggregator.GetEvent<NavigationCompletedEvent>();
            navigationCompletedEvent.Subscribe(OnNavigationCompleted, ThreadOption.UIThread);
        }

        private void OnNavigationCompleted(string publisher)
        {
            // Exit if this module published the event
            if (publisher == "ModuleA") return;

            // Otherwise, uncheck this button
            this.IsChecked = false;
        }

        private bool? isChecked;

        public bool? IsChecked
        {
            get { return isChecked; }

            set
            {
                base.RaisePropertyChangingEvent("IsChecked");
                isChecked = value;
                base.RaisePropertyChangedEvent("IsChecked");
            }
        }

        public ICommand ShowModuleAView { get; set; }   
    }
}
