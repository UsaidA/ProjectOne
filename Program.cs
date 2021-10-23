using System;

namespace ProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("K: ");
            int K = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(binomial(N,K));
            Console.ReadLine();
        }
        public static int binomial(in int N, in int K)
        {
            int expOne, expTwo, expThree, B;
            if ((N !> 0))
            {
                if ((K > -1) && (K < (N + 1)))
                {
                    expOne = factorial(N);
                    expTwo = factorial(K);
                    expThree = factorial(N - K);
                    expTwo = expTwo * expThree;
                    B = expOne / expTwo;
                    return B;
                }
                else
                    return 1;
            }
            else
                return 0;

        }
        public static int factorial(in int f)
        {
            int factorial = f;
            for (int i = factorial -1; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
