using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 5 == 0)
                {
                    num = num * 2;
                    Console.WriteLine(num);
                }
                else if (num < 0)
                {
                    num = num * -1;
                    Console.WriteLine(num);
                }
                else if (num > 1 && num < 6)
                {
                    num = num * 7;
                    Console.WriteLine(num);
                }
                else
                    Console.WriteLine("None of the abov {0}is a boring number",num);
                
            }
        }
    }
}
