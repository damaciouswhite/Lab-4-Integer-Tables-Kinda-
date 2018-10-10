using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the start of the program. Just asking the user to enter their name 
            Console.WriteLine("Welcome to Lab 4!");
            Console.WriteLine("Please Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Hey {0}", name);

            //This is where we get into the program asking the user for the integer while still using their name
            Console.WriteLine("Please enter an Integer");
            int Answer = int.Parse(Console.ReadLine());
            Console.WriteLine("{0},you Enterered " + Answer, name);

            //Now asking the user if they would like to continue
            Console.WriteLine("Woud you like to see that number Squared and Cubed? (Y or N");
            string Choice = (Console.ReadLine());

            //if they click yes we jump to this portion
            if (Choice == "Y" || Choice == "y")
            {
                int Square = (Answer * Answer);
                int Cubed = (Answer * Answer * Answer);

                Console.WriteLine("Number         Squared         Cubed");
                Console.WriteLine("======         =======         ======");
                Console.WriteLine("   " + Answer + "              " + Square + "             " + Cubed);
            }

            //if they push anything besides Y or y then it ends the program here
            else
            {
                Console.WriteLine("Thanks! Until Next Time!");
            }
        }
    }
}
