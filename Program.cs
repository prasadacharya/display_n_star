using System;

namespace display_n_star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide your input number");

            string N = Console.ReadLine();

            int n = Convert.ToInt32(N);


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
