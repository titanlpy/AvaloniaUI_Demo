using Avalonia.Controls;
using AvaloniaUIDemo.Models;
using AvaloniaUIDemo.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaUIDemo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public void BtnNotifTest()
        {
            NotificationsPage page = new NotificationsPage();
            page.Width = 400;
            page.Height = 480;
            page.Topmost = true;
            page.WindowState = WindowState.Normal;
            page.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            page.Show();
        }

        public void BtnDockTest()
        {
            var factory = new MainDockFactory(new DemoData());
            var layout = factory.CreateLayout();
            factory.InitLayout(layout);

            var dockViewModel = new DockViewModel()
            {
                Factory = factory,
                Layout = layout
            };

            DockPage dockPage = new DockPage { DataContext = dockViewModel };
            dockPage.Width = 800;
            dockPage.Height = 600;
            dockPage.Topmost = true;
            dockPage.WindowState = WindowState.Normal;
            dockPage.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dockPage.Show();
        }
    }

}
