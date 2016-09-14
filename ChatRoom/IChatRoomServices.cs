using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatRoom {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChatRoomServices" in both code and config file together.
    [ServiceContract]
    public interface IChatRoomSe1rvices {
        /// <summary>
        /// This function is called when a client send a new message.
        /// Add the message to our chatting list.
        /// </summary>
        /// <param name="message"></param>
        [OperationContract]
        void Add(string message);

        /// <summary>
        /// Delete Method: delete users messages
        /// </summary>
        /// <param name="message"></param>
        [OperationContract]
        void Delete(string message);

        /// <summary>
        /// ShowMessage Method: display users messages (max: 50 rows)
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<string> ShowMessage();

        /// <summary>
        /// Login: check if user is already log in, if yes, unable to log in, else log in with his username.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [OperationContract]
        bool Login(string userName);

        /// <summary>
        /// Logout: user logged out
        /// </summary>
        /// <param name="userName"></param>
        [OperationContract]
        string Logout(string userName);
    }
}
