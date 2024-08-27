using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media; 
using Beacon.Models;

namespace Beacon
{
    public partial class ChatsPage : UserControl
    {
        public ObservableCollection<ChatMessage> Messages { get; set; } = new ObservableCollection<ChatMessage>();

        public ChatsPage()
        {
            InitializeComponent();
            ChatListBox.ItemsSource = Messages;
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            var message = MessageTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                var chatMessage = new ChatMessage
                {
                    UserName = "User", // Replace this with actual user data
                    Message = message,
                    Timestamp = DateTime.Now
                };
                Messages.Add(chatMessage);

                // Clear the message box and focus it
                MessageTextBox.Clear();
                MessageTextBox.Focus();

                // Scroll to the bottom
                ScrollToBottom();
            }
        }

        private void ScrollToBottom()
        {
            // Scroll to the bottom of the ListBox
            var scrollViewer = GetVisualChildOfType<ScrollViewer>(ChatListBox);
            if (scrollViewer != null)
            {
                scrollViewer.ScrollToEnd();
            }
        }

        private T GetVisualChildOfType<T>(Visual visual) where T : Visual
        {
            if (visual == null) return null;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(visual); i++)
            {
                var child = VisualTreeHelper.GetChild(visual, i) as Visual;
                if (child is T t)
                {
                    return t;
                }
                var result = GetVisualChildOfType<T>(child);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }
    }

    
}
