using System;
using System.Collections;

namespace ProjectOne
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int K = 0;
            Stack pTri = new Stack();
            string nLine = " " ;
            int E = N; // E is for format function
            string spaceToUse = space(N);

            

            for (int i = N; i > 0-1 ; i--)
            {
                K = 0;
                nLine = " ";
            for (int x= 0; x < N+1; x++)
                {
                    int a = 0;           
                    nLine += Convert.ToString( (binomial(N, K) + spaceToUse)  );
                    K = K + 1;
                    a = a + 1;
                }
                string nLinet;
                nLinet = format(N, E) + nLine;
                pTri.Push(nLinet);
                N = N - 1;
            }

            foreach (var stackItem in pTri)
            {
                Console.WriteLine(stackItem);
            }
            Console.ReadLine();
        }
        public static string space(int N)
        {
            string space = "";
            if (N < 5)
            {
                space = " ";
            }
            else if ((N < 10) && (N > 4))
            {
                space = " ";
            }


            return space;



        }
        public static string format(int indent, int N)
        {
            string tab= "";
            for(int i = indent ; i < N+1  ; i++)
            {
                tab = tab + space(N);
            }
            return tab;
        }
    
        public static int binomial(in int N, in int K)
        {
            int expOne, expTwo, expThree, B;
            if (K == 0)
            {
                return 1;
            }
            else if (K == 1)
            {
                return N;
            }
            else if (K == N)
            {
                return 1;
            }
            if (!(N < 0))
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
