using System;
using System.IO;

namespace Lab_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("/Users/rs/Desktop/MishaLNU:LNU_Epam");

            int dir_num = 0; 
            DirectoryInfo[] directories = dir.GetDirectories(); 
            foreach (var v in directories)
            {
                dir_num++; 
                Console.WriteLine($"{dir_num}. {v}");
                DirectoryInfo dirhas = new DirectoryInfo(v.FullName); 
                DirectoryInfo[] directoryHas = dirhas.GetDirectories(); 
              
                int files_in_num = 0;
                foreach (var item in directoryHas) 
                {
                    files_in_num++;
                    Console.WriteLine($"  {files_in_num}. {item.FullName}");
                }
            }
            Console.WriteLine("\nAll files shown:");
            FileInfo[] files = dir.GetFiles();
            foreach (var value in files)
            {
                Console.WriteLine(value);
            }

        }

    }

}