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
            string[][][] TalaxianMaleLetters = new string[][][]
            {
                new string[][] 
                {
                    new string[] { "B", "Br", "D", "J", "L", "N", "P", "T", "W" },
                    new string[] { "e", "i", "u", "a" },
                    new string[] { "x" },
                    new string[] { "i", "ia", "e", "o" },
                    new string[] { "th", "n", "m" }
                },
                new string[][]
                {
                    new string[] { "B", "Br", "D", "J", "L", "N", "P", "T", "W" },
                    new string[] { "e", "i", "u", "a" },
                    new string[] { "x", "xa", "x", "xe" },
                }
            };
            string[][][] TalaxianFemaleLetters = new string[][][]
            {
                                new string[][]
                {
                    new string[] { "A", "E", "O" },
                    new string[] { "l", "ld" },
                    new string[] { "i", "a" },
                    new string[] { "x" },
                    new string[] { "i", "ia", "e", "o" },
                    new string[] { "th", "n", "m" }
                },
                new string[][]
                {
                    new string[] { "A", "E", "O" },
                    new string[] { "x" },
                    new string[] { "e", "i", "u", "a" },
                    new string[] { "l", "ld" },
                    new string[] { "i", "ia", "e", "o" },
                    new string[] { "th", "n", "m" }
                }
            };
            string[][][] KlingonsMaleLetters = new string[][][]
            {
                new string[][]
                {
                    new string[] { "K", "Kr", "B", "Br", "Ch", "L", "D", "Dr", "M", "G", "H", "J", "N", "K", "Kl", "P", "R", "S", "Sh", "St", "T" },
                    new string[] { "o", "e", "ee", "u", "a", "i", "y", "aa" },
                    new string[] { "rt", "nt", "r", "t", "lg", "rk", "nn", "ggr", "hl", "v" },
                    new string[] { "o", "e", "u", "a", "i", "y" },
                    new string[] { "r", "n", "t", "l", "x" },
                    new string[] { "o", "e", "u", "a", "i", "y" },
                    new string[] { "r", "k", "ng", "n", "x", "q", "g" }
                },
                new string[][]
                {
                    new string[] { "K", "Kr", "B", "Br", "Ch", "L", "D", "Dr", "M", "G", "H", "J", "N", "K", "Kl", "P", "R", "S", "Sh", "St", "T" },
                    new string[] { "o", "e", "ee", "u", "a", "i", "y", "aa" },
                    new string[] { "rt", "nt", "r", "t", "lg", "rk", "nn", "ggr", "hl", "v" },
                    new string[] { "o", "e", "u", "a", "i", "y" },
                    new string[] { "r", "n", "t", "l", "x", "q", "g" },
                },
                new string[][]
                {
                    new string[] { "K", "Kr", "B", "Br", "Ch", "L", "D", "Dr", "M", "G", "H", "J", "N", "K", "Kl", "P", "R", "S", "Sh", "St", "T" },
                    new string[] { "o", "e", "ee", "u", "a", "i", "y", "aa" },
                    new string[] { "rt", "nt", "r", "t", "lg", "rk", "nn", "rg", "hl", "v" },
                },
                new string[][]
                {
                    new string[] { "A", "O" },
                    new string[] { "rt", "nt", "r", "t", "lg", "rk", "nn", "ggr", "hl", "v" },
                    new string[] { "o", "e", "ee", "u", "a", "i", "y", "aa" },
                    new string[] { "r", "k", "ng", "n", "x", "q", "g" }
                }
            };
            string[][][] KlingonsFemaleLetters = new string[][][]
            {
                new string[][]
                {
                    new string[] { "K'", "B'", "Ch'", "D'", "L'", "G'", "M'", "N'", "J'", "T'", "Hij'" },
                    new string[] { "K", "Kr", "B", "Br", "Ch", "L", "D", "Dr", "M", "G", "H", "J", "N", "K", "Kl", "P", "R", "S", "Sh", "St", "T" },
                    new string[] { "o", "e", "ee", "u", "a", "i", "y", "aa" },
                    new string[] { "rt", "nt", "r", "t", "lg", "rk", "nn", "ggr", "hl", "v" },
                    new string[] { "o", "e", "u", "a", "i", "y" },
                    new string[] { "r", "n", "t", "l", "x", "q", "g" },
                },
                new string[][]
                {
                    new string[] { "K'", "B'", "Ch'", "D'", "L'", "G'", "M'", "N'", "J'", "T'" },
                    new string[] { "K", "Kr", "B", "Br", "Ch", "L", "D", "Dr", "M", "G", "H", "J", "N", "K", "Kl", "P", "R", "S", "Sh", "St", "T" },
                    new string[] { "o", "e", "ee", "u", "a", "i", "y", "aa" },
                    new string[] { "rt", "nt", "r", "t", "lg", "rk", "nn", "rg", "hl", "v" },
                },
            };
            Random random = new Random();

            while(true)
            {
                //get input and parse it
                Console.WriteLine("Skriv først hvilken type navn og derefter antalet af navne");
                Console.WriteLine("Vulcane Male: VM");
                Console.WriteLine("Vulcane Female: VF");
                Console.WriteLine("Talaxian Male: TM");
                Console.WriteLine("Talaxian Female: TF");
                Console.WriteLine("Klingon Male: KM");
                Console.WriteLine("Klingon Female: KF");
                Console.WriteLine("Eksempel: VM100 ");
                string input = Console.ReadLine();
                if(input.Length < 3)
                {
                    Console.WriteLine("Ugyldigt input!");
                    continue;
                }
                string nameType = input.Substring(0,2);
                if(!int.TryParse(input.Substring(2), out int number) || number == 0) //parse the number of names to get
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
                    case "TM":
                        genNameFrom = TalaxianMaleLetters;
                        break;
                    case "TF":
                        genNameFrom = TalaxianFemaleLetters;
                        break;
                    case "KM":
                        genNameFrom = KlingonsMaleLetters;
                        break;
                    case "KF":
                        genNameFrom = KlingonsFemaleLetters;
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
