using System.Windows;
using System.Windows.Controls;

namespace Beacon
{
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Example: Save the settings
            string selectedTheme = (ThemeComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            string username = UsernameTextBox.Text.Trim();
            bool notificationsEnabled = NotificationsCheckBox.IsChecked == true;

            // Handle settings saving logic here
            MessageBox.Show($"Settings saved:\nTheme: {selectedTheme}\nUsername: {username}\nNotifications: {notificationsEnabled}");
        }
    }
}