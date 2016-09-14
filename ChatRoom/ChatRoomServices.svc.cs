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
        public void Add(string message) {
            throw new NotImplementedException();
        }

        public void Delete(string message) {
            throw new NotImplementedException();
        }

        public void DoWork() {
        }

        public bool Login(string userName) {
            throw new NotImplementedException();
        }

        public void Logout(string userName) {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ShowMessage() {
            throw new NotImplementedException();
        }
    }
}
