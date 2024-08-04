using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Alapu
{
    public class ChatApp
    {
        static ChatService chatService = new ChatService();
        static string currentUser;

        public ChatApp()
        {
            chatService = new ChatService();
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the ChatRoom!");
            while (true)
            {
                if (string.IsNullOrEmpty(currentUser))
                {
                    Console.WriteLine("Enter your username (or type 'exit' to quit): ");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "exit")
                    {
                        break;
                    }
                    currentUser = input;
                    Console.WriteLine($"Greetings, {currentUser}");
                }
                else
                {
                    ShowMainMenu();
                }
            }
            Console.WriteLine("Goodbye!");
        }

        private void ShowMainMenu()
        {
            Console.WriteLine("Main Menu: ");
            Console.WriteLine("1. Create a new chat");
            Console.WriteLine("2. List chats");
            Console.WriteLine("3. Enter a chat");
            Console.WriteLine("4. Exit");
        }
    }
}
