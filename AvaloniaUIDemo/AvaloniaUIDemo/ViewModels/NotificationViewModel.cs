using System;
using System.Reactive;
using Avalonia.Controls.Notifications;
using AvaloniaUIDemo.Command;
using ReactiveUI;

namespace AvaloniaUIDemo.ViewModels
{
    public class NotificationViewModel : ViewModelBase
    {
        private IManagedNotificationManager _notificationManager;
        public ReactiveCommand<string, Unit> btnClickCommand { get; }
        public IManagedNotificationManager NotificationManager
        {
            get { return _notificationManager; }
            set { this.RaiseAndSetIfChanged(ref _notificationManager, value); }
        }

        public NotificationViewModel()
        {
            btnClickCommand = ReactiveCommand.Create<string>(DoClickCommand);
        }

        public void DoClickCommand(string parameter)
        {
            switch (parameter)
            {
                case "ShowSuccess":
                    {
                        ShowSuccess();
                    }
                    break;
                case "ShowInformation":
                    {
                        ShowInformation();
                    }
                    break;
                case "ShowErrorCommand":
                    {
                        ShowErrorCommand();
                    }
                    break;
                case "ShowWarning":
                    {
                        ShowWarning();
                    }
                    break;
                default:
                    break;
            }
        }

        private void ShowErrorCommand()
        {
            Avalonia.Controls.Notifications.Notification notification = new Avalonia.Controls.Notifications.Notification
                (
                    "Error",
                    "This is an Error Message Notification",
                    NotificationType.Error,
                    TimeSpan.FromSeconds(5)
                 );
            NotificationManager.Show(notification);
        }

        private void ShowInformation()
        {
            Avalonia.Controls.Notifications.Notification notification = new Avalonia.Controls.Notifications.Notification
                (
                    "Information",
                    "This is an Information Message Notification",
                    NotificationType.Information,
                    TimeSpan.FromSeconds(5)
                 );
            NotificationManager.Show(notification);
        }

        private void ShowSuccess()
        {
            Avalonia.Controls.Notifications.Notification notification = new Avalonia.Controls.Notifications.Notification
               (
                   "Success",
                   "This is an Success Message Notification",
                   NotificationType.Success,
                   TimeSpan.FromSeconds(5)
                );
            NotificationManager.Show(notification);
        }

        private void ShowWarning()
        {
            Avalonia.Controls.Notifications.Notification notification = new Avalonia.Controls.Notifications.Notification
               (
                   "Warning",
                   "This is an Warning Message Notification",
                   NotificationType.Warning,
                   TimeSpan.FromSeconds(5)
                );
            NotificationManager.Show(notification);
        }

    }
}
