using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {



            //Ask the user for a letter. Switch on the letter and for each letter create 
            //a assign a message variable with something like  “A is for Apple”, “B is for ...”
          
            while (true)
            {
               
                
                string x = Utils.GetInput("Input character: ");
                var choice = Convert.ToChar(x);
                
                switch (Char.ToUpper(choice))
                {
                    case 'A':
                        Console.WriteLine("A for Apple");
                        break;
                    case 'B':
                        Console.WriteLine("B for Bed");
                        break;
                    case 'C':
                        Console.WriteLine("C for Cat");
                        break;
                    case 'D':
                        Console.WriteLine("D for Dog");
                        break;
                    case 'E':
                        Console.WriteLine("E for Egg");
                        break;
                    case 'F':
                        Console.WriteLine("F for Fish");
                        break;
                    case 'G':
                        Console.WriteLine("G for Girl");
                        break;
                    case 'H':
                        Console.WriteLine("H for Horse");
                        break;
                    case 'I':
                        Console.WriteLine("I for Iglo");
                        break;
                    case 'J':
                        Console.WriteLine("J for Juce");
                        break;
                    case 'K':
                        Console.WriteLine("K for Kit");
                        break;
                    case 'L':
                        Console.WriteLine("L for Lion");
                        break;
                    case 'M':
                        Console.WriteLine("M for Monkey");
                        break;
                    case 'N':
                        Console.WriteLine("N for Nancy");
                        break;
                    case 'O':
                        Console.WriteLine("O for Orange");
                        break;
                    case 'P':
                        Console.WriteLine("P for Pall");
                        break;
                    case 'Q':
                        Console.WriteLine("Q for Queen");
                        break;
                    case 'R':
                        Console.WriteLine("R for Ropot");
                        break;
                    case 'S':
                        Console.WriteLine("S for Sun");
                        break;
                    case 'T':
                        Console.WriteLine("T for Table");
                        break;
                    case 'U':
                        Console.WriteLine("U for umbrella");
                        break;
                    case 'V':
                        Console.WriteLine("V for viola");
                        break;
                    case 'W':
                        Console.WriteLine("W for Water");
                        break;
                    case 'X':
                        Console.WriteLine("X for Xray");
                        break;
                    case 'Y':
                        Console.WriteLine("Y for Yoyo");
                        break;
                    case 'Z':
                        Console.WriteLine("Z for Zepra");
                        break;
                    default:
                        Console.WriteLine("out of range");
                        break;
                             }
               
                int num = Utils.GetNumber("Enter number: ");
               


                switch (num)
                {
                    case 12:
                    case 1:

                    case 2:
                        Console.WriteLine("Winter");
                        break;
                    case 3:

                    case 4:

                    case 5:
                        Console.WriteLine("Spring");
                        break;
                    case 6:

                    case 7:

                    case 8:
                        Console.WriteLine("Summer");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Fall");
                        break;
                    default:
                        Console.WriteLine("not month");
                        break;
                        

                }
                if (num > 12 && num < 1)
                    break;

            }
            





        }
    }
}
