using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using Avalonia.Markup.Xaml;
using AvaloniaUIDemo.ViewModels;

namespace AvaloniaUIDemo.Views
{
    public class NotificationsPage : Window
    {
        private WindowNotificationManager _notificationArea;
        NotificationViewModel _viewModel = new NotificationViewModel();

        public NotificationsPage()
        {
            InitializeComponent();
            _notificationArea = new WindowNotificationManager(this)
            {
                Position = NotificationPosition.TopRight,
                MaxItems = 3
            };
            _viewModel.NotificationManager = _notificationArea;
            DataContext = _viewModel;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
