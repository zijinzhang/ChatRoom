using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatRoom;
namespace ServerTest {
    class Program {
        public static string testString = "what sup bae1";
        public static string testString2 = "what sup bae2";
        public static string userName = "Byron";
        static void Main(string[] args) {
            TestAdd();
            TestDelete();
            TestLogin();
            TestLogout();
        }
        public static void TestAdd() {
            ChatRoomServices service = new ChatRoomServices();
            IEnumerable<string> list = new LinkedList<string>();
            service.Add(testString);
            service.Add(testString2);
            list=service.ShowMessage();
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------");
        }
        public static void TestDelete() {
            ChatRoomServices test = new ChatRoomServices();
            test.Delete(testString);


            foreach (var item in test.ShowMessage()) {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
        }
        public static void TestLogin() {
            ChatRoomServices test = new ChatRoomServices();
            Console.WriteLine(test.Login(userName));
            Console.WriteLine(test.Login(userName));
        }
        public static void TestLogout() {
            ChatRoomServices test = new ChatRoomServices();
            Console.WriteLine(test.Logout(userName));
        }
    }
}
