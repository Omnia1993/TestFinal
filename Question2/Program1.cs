using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Question2
{
    class Program1
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 4;
            int num3 = 5;
            int num4 = 6;
            int num5 = 1;

            num3 = num1 + num2;
            Console.WriteLine("{0} was added to {1} and gave a result of {2}", num1, num2, num3);
            num4 = (num3 * num2 * num1) / 5;
            Console.WriteLine("{0} multiply by {1} @ {2}  to gave {3}", num3, num2, num1, num4);
            int add = num1 + num2 * num3;

            Console.WriteLine("{0} added to {1} @ multiply by {2}  to gave {3}", num1, num2, num3, add);
            int addAgain = (num1 + num2) * num3;
            Console.WriteLine("{0} added to {1} @ multiply by {2}  to gave {3}", num1, num2, num3, addAgain);
            double doubleValue = Math.Pow(num1, 2);
            Console.WriteLine("{0} power 2 ={1}", num1, doubleValue);
            int addOne = 1 + num1;
            Console.WriteLine("It's  {0} before add one to its value,and became {1} after added 1 to its value", num1, addOne);
            int addOneAgain = num1 + 1;
            Console.WriteLine("It's  {0} before add one to its value,and became {1} after added 1 to its value", num1, addOneAgain);
            num1 = ++num1;
            Console.WriteLine("It's  {0} before add one to its value,and became {1} after added 1 to its value", num1, num1);
            num1 += 16;
            Console.WriteLine(" become{0} afte adding 16", num1);
            num1 = num1 - 6;
            Console.WriteLine(" become{0} afte decrease by 6", num1);
            int divBy2 = num1 / 2;
            Console.WriteLine("was {0} ,become {1} after cuted by 2", num1, divBy2);
            int divBy3 = num1 / 3;
            Console.WriteLine("was {0} ,become {1} after cuted by 3", num1, divBy3);
            bool divBy8 = num1/2==0;
            Console.WriteLine("its  {0}",divBy8);


            // Declare 5 string variables (just str1, str2,...) and Assign each a different phrase 20 characters of more
            string str1 = "Today is my luky day i feel so happy";
            string str2 = " We are happy family";
            string str3 = " Fight to achive your dream ";
            string str4 = "Do the best and never give up";
            string str5 = "Its going to be hard but it worth it";

            // Append to the end of a string “ the end”. Do this in three different ways
            string join = $"{str3} {str4}";
            Console.WriteLine(join);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(str3);
            stringBuilder.Append(" ");
            stringBuilder.Append(str4);
            Console.WriteLine(stringBuilder);
            string concat = String.Concat(str3, " ", str4);
            Console.WriteLine(concat);
           
            //ii. Prepend to a string “in the beginning ”
            str1.Insert(0,"in the beginning ");
            Console.WriteLine("Current string: "+str1);
            Console.WriteLine("New string: " + str1.Insert(0, "in the beginning "));
           // Join two strings together separated by “-“
            Console.WriteLine( str4 + "_" + str5);
            // Uppercase a variable
            Console.WriteLine("To Upper:  "+str1.ToUpper());
            //.Does str3 contain the letter ‘a’?
            Console.WriteLine("Does ({0}) contain 'a' ? {1}", str1,str1.Contains('a'));
            //What are characters 10 through 20 in str1 ?
            Console.WriteLine("charactor from 10 through 20 is( {0} ) ", str1.Substring(10, 20));
            // Add up the length of all of your strings
            int lenght = str1.Length + str2.Length+ str3.Length + str4.Length;
            Console.WriteLine("all lengths= "+lenght);
            // Does str5 start with “The”
            Console.WriteLine("({0})  does it cotain (The)? {1}",str5, str5.Contains("The"));









        }
    }
}
