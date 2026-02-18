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
                Console.WriteLine("2 For parking cost");
                Console.WriteLine("3 For parking cost");
                Console.WriteLine("q To end the program");
                choice = Console.ReadLine().ToLower().Trim();
                if (choice == "1")
                    minMax();

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
                    Console.WriteLine("Your Max has to be bigger then your Min, press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    minMax();
            do
            {
                Console.WriteLine("Give me a number in between these two numbers");
                while (!Int32.TryParse(Console.ReadLine(), out Middle))
                    Console.WriteLine("Invalid input");

                if (Middle > Max || Middle < Min)
                {
                    Console.WriteLine("That number is not between the min and the max");

                }
            }while( Middle > Max ||  Middle < Min);
            Console.WriteLine("good job! Press ENTER to continue");
            Console.Clear();
        }
       

    }
}
