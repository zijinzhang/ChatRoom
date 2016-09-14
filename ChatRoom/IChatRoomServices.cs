using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatRoom {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChatRoomServices" in both code and config file together.
    [ServiceContract]
    public interface IChatRoomServices {
        [OperationContract]
        void Add(string message);
        [OperationContract]
        void Delete(string message);
        [OperationContract]
        IEnumerable<string> ShowMessage(); 
    }
}
