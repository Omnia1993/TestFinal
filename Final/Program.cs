namespace Question1

{

    class Program

    {
        static void Main(string[] args)
        {


            //  1. What are the C# primitive TYPEs?
            //a.Order them from smallest to largest
            // b.Group them by whole numbers, fractional, other
            // c.Give 5 examples for each type of data (except bool :-) )

            /*    

          Integer number: (byte -short -int  -long)

          Floating point number: (floa,double,decimal) char, bool,object */
            byte age = 12;
            int id = 123456;
            short aptNumber = 252;
            string name = "Omnia";
            double percentage = 10.3;
            char gender = 'F';


            //  2. DECLARE 15 variables that describe you.
            //a.name, age, hariColor , ..., ..., ...
            //b.For instance: string firstName;
            //c.USE PROPER NAMING CONVENSIONS
            string fName = "omnia";
            int myAge = 25;
            string hairColor = "Brown";
            double temp = 37.5;
            char firstChar = 'O';
            byte aptNum = 252;
            bool feelGood = true;
            string race = "Black African";
            string country = "Sudan";
            decimal myWallet = 10000.4m;
            char theGender = 'F';
            string state = "Texas";
            string city = "Euless";
            int studentId = 3456564;
            string phone = "4356789087657";
            System.Console.WriteLine("my name is {0} i'am a {1} from {2} , iam {3} years old ,now i leave in {4} {5} apt# {6} i have{7} in my" +
                " wallet and i feel very good {8}"
                , fName, race, country, myAge, state, city, aptNum, myWallet, feelGood);

            // d.What is the C# naming convention for variables?*
            // (Variable names must start with a letter or an underscore, 
            //camelCase for variables - first letter is lowercase, second word starts with an uppercase letter)
        }
    }
}
