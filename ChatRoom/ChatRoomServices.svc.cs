using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatRoom {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChatRoomServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ChatRoomServices.svc or ChatRoomServices.svc.cs at the Solution Explorer and start debugging.
    public class ChatRoomServices:IChatRoomSe1rvices {
        static LinkedList<string> allMessages = new LinkedList<string>();
        static HashSet<string> userNames = new HashSet<string>();
        public void Add(string message) {
            if (allMessages.Count == 50) {
                allMessages.RemoveFirst();
                allMessages.AddLast(message);
            }
            allMessages.AddLast(message);
        }

        public void Delete(string message) {
            var lastMessage = allMessages.FindLast(message);
            if(lastMessage != null) allMessages.Remove(message);
        }

        public bool Login(string userName) {
            return userNames.Add(userName);
        }

        public string Logout(string userName) {
            userNames.Remove(userName);
            return $"User {userName} logout successfully.";
        }

        public IEnumerable<string> ShowMessage() {
            return allMessages;
        }
    }
}
