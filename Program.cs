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
                Console.WriteLine("3 For dice");
                Console.WriteLine("q To end the program");
                choice = Console.ReadLine().ToLower().Trim();
                if (choice == "1")
                    minMax();
                else if (choice == "2")
                    BoB();
                else if (choice == "3")
                    Dice();
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
            double depositammount, withdrawammount, paymentAmmount;
            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("ATM menu, enter what you would like to do (there is a 0.75 cents fee for every transaction)");
                Console.WriteLine("Deposit");
                Console.WriteLine("withdrawal");
                Console.WriteLine("Bill Payment");
                Console.WriteLine("account balance");
                Console.WriteLine("q To go back to main menu");
                choice = Console.ReadLine().ToLower().Trim();
                Console.Clear();
                if(balance < 0.75 && choice != "deposit")
                {
                    Console.WriteLine("Your balance is lower then the transaction fee of 75 cents, that's sad");
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (choice == "deposit")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    while (!double.TryParse(Console.ReadLine(), out depositammount))
                        Console.WriteLine("Invalid input");
                    if ((balance + depositammount) < 0.75)
                    {
                        balance = balance - balance;
                        Console.WriteLine("you cannot afford the transaction fee");
                        Console.WriteLine("your balance is now " + balance.ToString("C"));
                        Console.WriteLine("Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if ((balance + depositammount) >= 0.75)
                    {
                        balance = balance + depositammount - 0.75;

                        Console.WriteLine($"your balance is now " + balance.ToString("C"));
                        Console.WriteLine("press Enter to go back to bank menu");
                        Console.ReadLine();
                    }



                }
                else if (choice == "withdrawal")
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    while (!double.TryParse(Console.ReadLine(), out withdrawammount))
                        Console.WriteLine("Invalid input");
                    if (withdrawammount <= (balance - 0.75))
                    {
                        balance = balance - withdrawammount - 0.75;
                        Console.WriteLine($"your balance is now " + balance.ToString("C"));
                        Console.WriteLine("press Enter to go back to bank menu");
                        Console.ReadLine();
                    }
                    else if(withdrawammount > (balance - 0.75))
                    {
                        balance -= 0.75;
                        Console.WriteLine("You can't withdraw more than " + balance.ToString("C"));
                        Console.WriteLine("You have been charged $0.75 for this transaction");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        Console.Clear ();
                    }
                }
                else if (choice == "bill payment")
                {
                    Console.WriteLine("How much do you owe?");
                    while (!double.TryParse(Console.ReadLine(), out paymentAmmount))
                        Console.WriteLine("Invalid input");
                    if (paymentAmmount <= (balance - 0.75))
                    {
                        balance = balance - paymentAmmount - 0.75;
                        Console.WriteLine($"you paid {paymentAmmount:C} your balance is now {balance:C}");

                        Console.WriteLine("press Enter to go back to bank menu");
                        Console.ReadLine();
                    }
                    else if (paymentAmmount > (balance - 0.75))
                    {
                        balance -= 0.75;
                        Console.WriteLine("You can't afford to pay more than " + balance.ToString("C"));
                        Console.WriteLine("You have been charged $0.75 for this transaction");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }

                }
                else if (choice == "account balance")
                {
                    Console.WriteLine($"you have {balance} in your account, you will be charged 75 cents for this transaction");
                    balance = balance - 0.75;
                    Console.WriteLine("press ENTER to go back to the menu");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("wrong menu input, press ENTER to go back");
                    Console.ReadLine();
                }
                Console.Clear();

            }
        }
        public static void Dice()
        {
            Random generator = new Random();
            int Dice1,Dice2;
            Console.WriteLine("Press enter to roll two dice until it has rolled doubles");
            Console.ReadLine() ;
            Dice1 = 0;
            Dice2 = 1;
            int attemps = 0;
            while (Dice1 != Dice2)
            {
                Dice1 = generator.Next(1, 7);
                Dice2 = generator.Next(1, 7);
                attemps++;
                Console.WriteLine($"{Dice1},{Dice2}");
            }
            Console.WriteLine($"it took {attemps} rolls to get doubles");

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            
        }




    }
}
