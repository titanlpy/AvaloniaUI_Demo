using System;
using Dock.Model;
using Dock.Model.Controls;

namespace AvaloniaUIDemo.ViewModels
{
    public class DockMainViewModel : RootDock
    {
        public override IDockable Clone()
        {
            var dockMainViewModel = new DockMainViewModel();

            CloneHelper.CloneDockProperties(this, dockMainViewModel);
            CloneHelper.CloneRootDockProperties(this, dockMainViewModel);

            return dockMainViewModel;
        }
    }
}
