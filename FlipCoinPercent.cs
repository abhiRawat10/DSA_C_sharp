using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class FlipCoin
    {
        public void entry()
        {
            Console.WriteLine("Enter the number of times to flip the coin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            int[] res = new int[n];
            Random random = new Random();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Press any key to flip the coin");
                Console.ReadKey();
                double flip = random.Next(0, 11) / 10; //to make sure we get 1 in output
                if (flip <= 0.5)
                {
                    res[i] = 0;//0 means head
                    Console.WriteLine("You got Head");
                }
                else
                {
                    res[i] = 1;//1 means tails
                    Console.WriteLine("You got Tail");
                }

            }

            //we can do this without array but we use array to practice
            int head = 0, tail = 0;
            for (int i = 0;i < n; i++)
            {
                if (res[i] == 0) head++;
                else tail++;
            }

            Console.WriteLine($"Head: {(double)head*100/(head+tail)}%, Tail: {(double)tail * 100 / (head + tail)}%");
        }
    }
}
