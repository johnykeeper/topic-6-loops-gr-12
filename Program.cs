using System.Reflection;

namespace topic_6__loops_gr_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "q")
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 For Min/Max");
                Console.WriteLine("2 For BoB");
                Console.WriteLine("q To end the program");
                choice = Console.ReadLine().ToLower().Trim();
                if (choice == "1")
                    minMax();
                else if (choice == "2")
                    BoB();
                    Console.Clear();

            }
        }
        public static void minMax()
        {
            int Min, Max, Middle;
            Console.WriteLine("Give me a number to be the minimum");
            while (!Int32.TryParse(Console.ReadLine(), out Min))
                Console.WriteLine("Invalid input");
            Console.WriteLine("Give me a number to be the maximum");
            while (!Int32.TryParse(Console.ReadLine(), out Max))
                Console.WriteLine("Invalid input");
            if (Min > Max)
            {
                Console.WriteLine("Your Max has to be bigger then your Min, press Enter to continue");
                Console.ReadLine();
                Console.Clear();
                minMax();
            }
            while (true)
            {
                Console.WriteLine($"Give me a number in between {Min} and {Max}");
                while (!Int32.TryParse(Console.ReadLine(), out Middle))
                    Console.WriteLine("Invalid input");

                if (Middle >= Max || Middle <= Min)
                {
                    Console.WriteLine($"That number is not between {Min} and {Max}");
                    continue;
                    
                }
                if (Middle <= Max || Middle >= Min)
                {
                    Console.WriteLine("good job!");
                    break;
                }
            }
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public static void BoB()
        {
            string choice = "";
            double balance = 150;
            double depositammount;
            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("ATM menu, enter what you would like to do (there is a 0.75 cents fee for every transaction");
                Console.WriteLine("Deposit");
                Console.WriteLine("withdrawal");
                Console.WriteLine("Bill Payment");
                Console.WriteLine("account balance");
                Console.WriteLine("q To go back to main menu");
                choice = Console.ReadLine().ToLower().Trim();
                Console.Clear();
                if (choice == "deposit")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    while (!double.TryParse(Console.ReadLine(), out depositammount))
                        Console.WriteLine("Invalid input");
                    Console.WriteLine($"your balance is now " +  (depositammount + balance - 0.75).ToString("C"));
                    Console.WriteLine("press Enter to go back to bank menu");
                    Console.ReadLine();


                }
                else if (choice == "withdrawal")
                {

                }
                else if (choice == "bill payment")
                {

                }
                else if (choice == "account balance")
                {

                }
                else if (choice == "w")
                    BoB();
                Console.Clear();

            }
        }
     



    }
}
