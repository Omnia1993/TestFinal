using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Question7
{
    class Program
    {
        static string keyword;






        static void Main(string[] args)
        {
            string description;
            Console.WriteLine("enter reserved word: ");
            keyword = Console.ReadLine();
                description = CSharpFlashCard(keyword);
                Console.WriteLine($"Definition for {keyword}: {description}");
            
            static String CSharpFlashCard(string reserved)
            {


                switch (reserved.ToLower())
                {

                    case "switch":

                        return ("used to switching after given spesfic condtion");

                    case "if":

                        return ("used to check spesifc condition");
                    case "for":

                        return ("used to loop ");
                    case "int":

                        return ("used to define integer number ");
                    case "break":

                        return ("used to break out of the loop");


                    default:
                        return ("what");

                }


            }
        }
    }
}
