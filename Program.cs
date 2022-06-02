using System;

namespace PoolPuzzle
{
    class program
    {
        public static void Main(string[] args)
        {
            Q q = new Q(Q.R.Next(2) == 1);
            while (true)
            {
                Console.WriteLine($"{q.N1} {q.Op} {q.N2} = ");
                if (!int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine("Thanks for playing! Come back again.");
                    return;
                }
                if (q.Check(i))
                {
                    Console.WriteLine("Congratulations! You are Right.");
                    q = new Q(Q.R.Next(2) == 1);
                }
                else Console.WriteLine("Wrong! Better Luck Next Time Please Try Again.");
            }

        }
    }
}