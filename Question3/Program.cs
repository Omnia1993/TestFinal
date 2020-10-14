using System;

namespace Question3
{
	class Program
	{
		static void Main(string[] args)
		{
			//5. Describe what these string methods do and give an example of each:
			//a-IndexOf, Substring, Contains, Equals, CompareTo, EndsWith, Trim, Pad, PadLeft, PadRight, Replace, Remove, ToUpper

			//a-IndexOf:  Returns the index position of first occurrence of specified character.
			//b-substring : returns substring of strings.
			//c- contains: checks whether specified character or string is exists or not in the string value.
			//d- equal: compares two string and returns Boolean value as output
			//e- CompareTo: Compare two strings and returns integer value as output It returns 0 for true and 1 for false.
			//f-EndsWith :checks whether specified character is the last character of string or not.
			//g-trim : It removes extra whitespaces from beginning and ending of string.
			//h-pad :
			//i-PadLeft :
			//j-PadRight :
			//k-Replace :replaces the character.
			//l-Remove:  deletes all the characters from beginning to specified index position.
			//m-ToUpper: Converts String into Upper case based on rules of the current culture
			string firstName = "Omnia";

			Console.WriteLine(firstName.IndexOf("n"));
			Console.WriteLine(firstName.ToUpper());
			Console.WriteLine(firstName.Substring(1,3));
			Console.WriteLine(firstName.Trim());
			Console.WriteLine(firstName.Contains("mni"));
			Console.WriteLine(firstName.EndsWith("a"));
			string pad = firstName.PadLeft(2);
			Console.WriteLine(pad);



		}
	}
}
