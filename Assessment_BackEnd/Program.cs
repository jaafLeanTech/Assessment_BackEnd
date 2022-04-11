using System;

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
            string message = String.Empty;
            string answer = String.Empty;

            do
            {
                Console.Write("Enter the message: ");
                message = Console.ReadLine();

                message = String.Join("", message.Split('@', ',', '.', ';', '\'', '$', '#', '(', ')', '"', '=', '?', '¿', '¡', '!', '%', '&', '/', '|', '¬', '°', '>', '<'));

                if (message == String.Empty)
                    Console.WriteLine("NA");
                else
                    Console.WriteLine(message);


                Console.WriteLine("Do you want to enter another message? (Yes/No)");
                answer = Console.ReadLine();
            }
            while (answer == "Yes");

            return message;
        }

    }
}
