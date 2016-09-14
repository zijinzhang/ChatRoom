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
using System.Threading;
using System.Windows.Threading;

namespace ChatRoomMain
{
    /// <summary>
    /// Interaction logic for ChatRoom.xaml
    /// </summary>
    public partial class ChatRoom : Window
    {
        private string name;
        private string preMessage;

        public ChatRoom(string name)
        {
            InitializeComponent();
            this.name = name;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.RecallButton.IsEnabled = false;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e) {
            listBox.Items.Clear();
            ChatRoomServices CRS = new ChatRoomServices();
            IEnumerable<string> messages = new LinkedList<string>();
            messages = CRS.ShowMessage();
            foreach (var item in messages) {
                listBox.Items.Add(item);
            }
        }

        //send message when click send button
        private void Send_Click(object sender, RoutedEventArgs e) {
            if (this.messageBox.Text != "") {
                ChatRoomServices addMessage = new ChatRoomServices();
                string message = this.messageBox.Text;
                string newMessage = $"{name}: {message}";
                addMessage.Add(newMessage);
                this.listBox.Items.Add(newMessage);
                preMessage = newMessage;
                messageBox.Text = "";
                this.RecallButton.IsEnabled = true;
            }
        }

        //delete user's last message
        private void RecallButton_Click(object sender, RoutedEventArgs e) {
            if (preMessage == "") return;
            ChatRoomServices service = new ChatRoomServices();
            service.Delete(preMessage);
            preMessage = "";
            this.RecallButton.IsEnabled = false;
        }

        //send message when press Enter + control
        private void messageBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control){
                Send_Click(sender, e);
            }
        }
    }
}
