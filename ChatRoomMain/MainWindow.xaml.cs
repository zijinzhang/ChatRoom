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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChatRoomMain.ChatRoomServices;

namespace ChatRoomMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            ChatRoomSe1rvicesClient service = new ChatRoomSe1rvicesClient();
            if (textBox.Text == "") {
                MessageBox.Show("Please enter your username");
                return;
            }
            string userName = this.textBox.Text;
            bool success = service.Login(userName);

            if (!success) {
                MessageBox.Show("This user name is already been used.");
                return;
            }
            ChatRoom chatRoom = new ChatRoom(userName);
            App.Current.MainWindow = chatRoom;
            this.Close();
            chatRoom.Show();
        }

        private void button_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                Login(sender, e);
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                Login(sender, e);
            }
        }
    }
}
