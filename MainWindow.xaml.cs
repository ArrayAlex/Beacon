using System.Windows;

namespace Beacon
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowHomePage();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            ShowHomePage();
        }

        private void ChatsButton_Click(object sender, RoutedEventArgs e)
        {
            ShowChatsPage();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            ShowSettingsPage();
        }

        private void ShowHomePage()
        {
            MainContentControl.Content = new HomePage();
        }

        private void ShowChatsPage()
        {
            MainContentControl.Content = new ChatsPage();
        }

        private void ShowSettingsPage()
        {
            MainContentControl.Content = new SettingsPage();
        }
    }
}