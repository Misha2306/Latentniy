using System.IO;
using System;

namespace Lab_8._2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the name of file you want to find: ");
            string from_user = Console.ReadLine();
            string DirectoryName = "/Users/rs/Desktop/University:Learning/Theory/Literature";
            DirectoryInfo directory = new DirectoryInfo(DirectoryName);
            string[] requestedfiles = Directory.GetFiles(DirectoryName, $"*{from_user}*.txt", SearchOption.AllDirectories);
            
            if (requestedfiles.Length == 0)
            {
                Console.WriteLine("Can not find file. Try one more time.");
            }
            else
            {
                foreach (string file in requestedfiles)
                {
                    Console.WriteLine("Yay, we found it!" + file);
                }
            }
        }
    }
}