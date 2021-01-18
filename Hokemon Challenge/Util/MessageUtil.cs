using System;

namespace Hokemon_Challenge.Util {
    
    public class MessageUtil {

        public static void Msg(string message) {
            Console.WriteLine(message);
        }

        public static void Msg(string message, params string[] args) {
            Console.WriteLine(message, args);
        }

        public static void MsgSpacer() {
            Console.WriteLine("------------------------------------");
        }

        public static object getInput(string question) {
            Console.Write(question);
            return Console.ReadLine();
        }

        public static int getInt(string question) {
            Console.Write(question);
            return Convert.ToInt32(Console.ReadLine());
        }
        
        
    }
}