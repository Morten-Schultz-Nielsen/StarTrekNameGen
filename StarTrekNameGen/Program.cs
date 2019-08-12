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
                //get name type inputs
                Console.WriteLine("\nVælg race:\n1: Vulcane\n2: Talaxian\n3: Klingon");
                char raceKey = Console.ReadKey().KeyChar;

                Console.WriteLine("\nVælg køn:\n1: Hankøn\n2: Hunkøn");
                char genderKey = Console.ReadKey().KeyChar;

                //find letters for the name
                string[][][] genNameFrom;
                if(raceKey == '1' && genderKey == '1')
                {
                    genNameFrom = VulcanMaleLetters;
                }
                else if(raceKey == '1' && genderKey == '2')
                {
                    genNameFrom = VulcanFemaleLetters;
                }
                else if(raceKey == '2' && genderKey == '1')
                {
                    genNameFrom = TalaxianMaleLetters;
                }
                else if(raceKey == '2' && genderKey == '2')
                {
                    genNameFrom = TalaxianFemaleLetters;
                }
                else if(raceKey == '3' && genderKey == '1')
                {
                    genNameFrom = KlingonsMaleLetters;
                }
                else if(raceKey == '3' && genderKey == '2')
                {
                    genNameFrom = KlingonsMaleLetters;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ugyldigt input!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                //chose an amount of names to print
                Console.WriteLine("\nVælg antal:");
                if(!int.TryParse(Console.ReadLine(), out int number) || number == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ugyldigt input!");
                    Console.ForegroundColor = ConsoleColor.White;
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
