using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("1.kelimeyi girin:");
            string word1 = Console.ReadLine();
            Console.Write("2.kelimeyi girin:");
            string word2 = Console.ReadLine();

            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);

            if (NewWord1 == NewWord2)
            {
                Console.WriteLine("Anagramdır \"{0}\" ve \"{1}\" ", word1, word2);
            }
            else
            {
                Console.WriteLine("Anagram değildir \"{0}\" ve \"{1}\"", word1, word2);
            }

   
            Console.ReadLine();
        }
    }
}
