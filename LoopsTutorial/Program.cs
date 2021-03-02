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
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Hello!");       
            }
            for(int j = 1; j <= 10;)
            {
                Console.WriteLine(j);
                j++;
            }
            for (int x = 10; x >= 1;)
            {
                Console.WriteLine(x);
                x--;
            }
            Console.ReadLine();

        }
    }
}
