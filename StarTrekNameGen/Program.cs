using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                //generate names
                Console.WriteLine("--------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                List<string> names = new List<string>();
                for(int i = 0; i < genNameFrom.Length; i++)
                {
                    string[][] nameSyntax = genNameFrom[i];
                    string name = string.Empty;
                    int[] indexes = new int[nameSyntax.Length];
                    int letterNumber = 0;
                    bool done = false;
                    while(true)
                    {
                        name += nameSyntax[letterNumber][indexes[letterNumber]];
                        letterNumber++;
                        if(letterNumber >= nameSyntax.Length)
                        {
                            //when name is done. Get ready for next name
                            names.Add(name);
                            name = string.Empty;
                            letterNumber = 0;
                            int changeIndex = 0;
                            while(true)
                            {
                                //add one to an index to get the next possible name
                                indexes[changeIndex]++;
                                if(indexes[changeIndex] >= nameSyntax[changeIndex].Length)
                                {
                                    indexes[changeIndex] = 0;
                                    changeIndex++;
                                    if(changeIndex >= nameSyntax.Length)
                                    {
                                        done = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        if(done)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("Sorting " + names.Count + " names...");
                names.Sort();

                //write names
                foreach(string name in names)
                {
                    Console.WriteLine(name);
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(names.Count + " names!");
                Console.WriteLine("--------------------------------");

                //print document
                PrintPreviewDialog dialog = new PrintPreviewDialog();
                dialog.Document = new PrintDocument();
                string namesString = string.Join(" ", names);
                Font font = new Font("arial", 12);
                dialog.Document.PrintPage += delegate (object sender, PrintPageEventArgs e)
                {
                    e.Graphics.MeasureString(namesString.Substring(0,Math.Min(namesString.Length,10000)), font, e.PageBounds.Size, StringFormat.GenericDefault, out int maxChars, out int lines);

                    string write = namesString.Substring(0, maxChars);
                    namesString = namesString.Substring(maxChars);
                    e.Graphics.DrawString(write, font, new SolidBrush(Color.Black), new Rectangle(0, 0, e.PageBounds.Width, e.PageBounds.Height));
                    e.HasMorePages = namesString.Length > 0;
                };
                dialog.ShowDialog();

                PrintDialog print = new PrintDialog();
                print.Document = dialog.Document;
                print.ShowDialog();
            }
        }
    }
}
