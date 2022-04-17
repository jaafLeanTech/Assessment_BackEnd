using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assessment_BackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveCharacters();
        }

        static string RemoveCharacters()
        {
            string messageInput = String.Empty;
            string messageOutput = String.Empty;
            string answer = String.Empty;
            List<string> casa = new List<string>();

            do
            {
                Console.Write("Enter the message: ");
                messageInput = Console.ReadLine();

                messageOutput = Regex.Replace(messageInput, @"[^\w\-_ ]+", "");

                if (messageOutput == String.Empty)
                    Console.WriteLine("NA");
                else
                    Console.WriteLine(messageOutput);


                Console.WriteLine("Do you want to enter another message? (Yes/No)");
                answer = Console.ReadLine();
            }
            while (answer == "Yes");

            return messageOutput;
        }

    }
}
