using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Specialized;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Utils.GetInput("Enter String: ");
                if (input.Length > 20)
                
                    Console.WriteLine(input.Remove(input.Length / 2));


                else if (input.Contains('z'))
                    
                        Console.WriteLine(input.Insert(input.Length, " found a 'z' in the string "));



                else if (input.StartsWith('a'))
                        
                            Console.WriteLine(input.Insert(0, "!!!!!").Substring(3, 5));



                else
                            
                                Console.WriteLine(input.ToUpper().Replace(' ', '_'));

                            

                        




                    
                
            }
        }
    }
}

