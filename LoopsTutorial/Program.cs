using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Hello!");
            }
            Console.WriteLine(" ");
            for (int j = 1; j <= 10;)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine(" ");
            for (int x = 10; x >= 1;)
            {
                Console.WriteLine(x);
                x--;
            }
            Console.WriteLine(" ");
            for (int m = 5; m <= 50;)
            {
                Console.WriteLine(m);
                m = m + 5;
            }
            Console.WriteLine(" ");
            for (int x = 99; x >= 55;)
            {
                Console.WriteLine(x);
                x--;
            }
            Console.WriteLine(" ");
            int evenNumber = 0;
            int oddNumber = 0;
            for (int x = 20; x <= 40; x++)
            {
                if (x % 2 == 0)
                {
                    evenNumber += x;
                }
                else
                {
                    oddNumber += x;
                }
            }
            Console.WriteLine($"Your total odd number is : {oddNumber}");
            Console.WriteLine($"Your total even number is : {evenNumber}");
            Console.WriteLine(" ");
            int factorial = 1;
            for (int f = 5; f >= 1; f--)
            {
                factorial *= f;
            }
            Console.WriteLine($"5! = {factorial}");
            Console.WriteLine(" ");
            int numEven = 0;
            int input;
            Console.WriteLine("Enter 5 numbers and the amount of even numbers will be printed");
            for (int g = 0; g <= 9; g++)
            {
                Console.WriteLine("Please enter 10 numbers");
                if (Int32.TryParse(Console.ReadLine(), out input))
                {
                    if (input % 2 == 0)
                    {
                        numEven += 1;
                    }
                }
                else
                {
                    Console.WriteLine("That is not an integer! Try again.");
                }


            }
            Console.WriteLine($"You entered {numEven} even numbers");
            Console.WriteLine(" ");
            Console.WriteLine("While Questions");
            int l = 1;
            while (l <= 10)
            {
                Console.WriteLine(l);
                l = l + 1;
            }
            Console.WriteLine(" ");
            int v = 10;
            while (v >= 1)
            {
                Console.WriteLine(v);
                v = v - 1;
            }
            Console.WriteLine(" ");
            int k = 10;
            while (k >= 2)
            {
                Console.WriteLine(k);
                k = k - 2;
            }
            Console.WriteLine(" ");
            double number;
            Console.WriteLine("Please enter a number");
            while (!Double.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Invalid double, try again.");
            Console.WriteLine($"Thanks for {number}");
            Console.WriteLine(" ");
            bool stop = true;
            while(stop)
            {
                Console.WriteLine("Will it ever stop?");
                stop = false;
            }
            Console.WriteLine(" ");
            int selection;
            do
            {
                Console.WriteLine("Who is the better captain?");
                Console.WriteLine("1 - Captain Picard");
                Console.WriteLine("2 - Captain Kirk");
                selection = Convert.ToInt32(Console.ReadLine());
            } while (selection != 1);
            Console.WriteLine("Correct");

            Console.ReadLine();
        }
    }
}
