using Dock.Model;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaUIDemo.ViewModels
{
    public class DockViewModel: ViewModelBase
    {
        private IFactory _factory;
        private IDock _layout;
        private string _currentView;

        public IFactory Factory
        {
            get => _factory;
            set => this.RaiseAndSetIfChanged(ref _factory, value);
        }

        public IDock Layout
        {
            get => _layout;
            set => this.RaiseAndSetIfChanged(ref _layout, value);
        }

        public string CurrentView
        {
            get => _currentView;
            set => this.RaiseAndSetIfChanged(ref _currentView, value);
        }
    }
}
