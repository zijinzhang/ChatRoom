using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ChatRoom;

namespace ChatRoomMain
{
    /// <summary>
    /// Interaction logic for ChatRoom.xaml
    /// </summary>
    public partial class ChatRoom : Window
    {
        private string name;
        // Save the previous message been sent.
        private string preMessage;

        public ChatRoom(string name)
        {
            InitializeComponent();
            this.name = name;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }


        private void Send_Click(object sender, RoutedEventArgs e) {
            ChatRoomServices addMessage = new ChatRoomServices();
            string message = this.messageBox.Text;
            string newMessage = $"{name}: {message}";
            addMessage.Add(newMessage);
            preMessage = newMessage;
            messageBox.Text = "";
        }

        private void RecallButton_Click(object sender, RoutedEventArgs e) {
            if (preMessage == "") return;
            ChatRoomServices service = new ChatRoomServices();
            service.Delete(preMessage);
            preMessage = "";
        }
    }
}
