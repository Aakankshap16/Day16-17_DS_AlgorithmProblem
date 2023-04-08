using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BinarySearchTree
{
    public class SearchFromFile
    {
        public static void Check(string path)
        {
            Console.WriteLine("Enter Word for search:");
            string word = Console.ReadLine();
            string value = File.ReadAllText(path);
            string[] str = value.Split(" ");
            foreach (string s in str)
            {
                Console.WriteLine($"{s}");
                if (word == s)
                {
                    Console.WriteLine($"Your word found {word}");
                    return;
                }
            }
            Console.WriteLine($"Your word not found");
        }
    }
}