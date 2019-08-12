using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTrekNameGen
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup variables
            string[][][] VulcanMaleLetters = new string[][][]
            {
                new string[][] 
                {
                    new string[] { "S", "Sp", "Sk", "St", "T" },
                    new string[] { "a", "e", "i", "o", "u", "y" },
                    new string[] { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" },
                    new string[] { "a", "e", "i", "o", "u", "y" },
                    new string[] { "q", "p", "k", "ck", "l" }
                },
                new string[][]
                {
                    new string[] { "S", "Sp", "Sk", "St", "T" },
                    new string[] { "a", "e", "i", "o", "u", "y" },
                    new string[] { "q", "p", "k", "ck", "l" }
                }
            };
            string[][][] VulcanFemaleLetters = new string[][][]
            {
                new string[][]
                {
                    new string[] { "T'" },
                    new string[] { "P", "K", "Q" },
                    new string[] { "a", "e", "i", "o", "u", "y" },
                    new string[] { "r", "j", "'p", "k", "l" }
                }
            };
            Random random = new Random();

            while(true)
            {
                //get input and parse it
                Console.WriteLine("Skriv først hvilken type navn og derefter antallet af navne");
                Console.WriteLine("Vulcane Male: VM");
                Console.WriteLine("Vulcane Female: VF");
                Console.WriteLine("Eksempel: VM100 ");
                string input = Console.ReadLine();
                if(input.Length < 3)
                {
                    Console.WriteLine("Ugyldigt input!");
                    continue;
                }
                string nameType = input.Substring(0,2);
                int number = 0;
                if(!int.TryParse(input.Substring(2), out number) || number == 0) //parse the number of names to get
                {
                    Console.WriteLine("Ugyldigt input!");
                    continue;
                }

                string[][][] genNameFrom;
                switch(nameType) //parse the name type
                {
                    case "VM":
                        genNameFrom = VulcanMaleLetters;
                        break;
                    case "VF":
                        genNameFrom = VulcanFemaleLetters;
                        break;
                    default:
                        Console.WriteLine("Ugyldigt input!");
                        continue;
                }

                //generate names
                Console.WriteLine("--------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                for(int i = 0; i < number; i++)
                {
                    string[][] nameSyntax = genNameFrom[random.Next(0, genNameFrom.Length)];
                    string name = string.Empty;
                    for(int j = 0; j < nameSyntax.Length; j++)
                    {
                        name += nameSyntax[j][random.Next(0, nameSyntax[j].Length)];
                    }

                    Console.WriteLine(name);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
