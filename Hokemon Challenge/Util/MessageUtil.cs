using System;

namespace HokemonChallenge.Util {
    
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

        public static void TypewriterMsg(string message) {
            foreach(char c in message) {
                Console.Write(c);
                System.Threading.Thread.Sleep(60);
            }
            MessageUtil.Msg("");
        }

        public static void TypewriterMsg(string message, params string[] args) {
            string newMsg = String.Format(message, args);
            TypewriterMsg(newMsg);
        }
        
        
    }
}