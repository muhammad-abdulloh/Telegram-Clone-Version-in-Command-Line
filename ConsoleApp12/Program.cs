using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp12
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nickname kiriting: ");
                string nickname = Console.ReadLine();

            label:
                Console.WriteLine("Habarni kiriting: ");
                string message = Console.ReadLine();

                Console.Clear();

                AddMessageToChat(nickname, message);
                Console.WriteLine(GetChat());
                goto label;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Habar jo'natilmadi");
            }
        }

        static string GetChat()
        {
            string path = @"\\192.168.2.16\Users\Public\chat.txt";

            string chat = File.ReadAllText(path);

            return chat;
        }


        static void AddMessageToChat(string nickname, string message)
        {
            string path = @"\\192.168.2.16\Users\Public\chat.txt";
            string chat = GetChat();
            chat += nickname + ": " + message + "\n";
            File.WriteAllText(path, chat);
        }
    }
}

