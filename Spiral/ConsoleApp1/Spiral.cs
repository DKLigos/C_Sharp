using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, m = 1;
            int[,] a = new int[n, n];

            if (n % 2 != 0)
            {
                a[(n / 2),(n / 2)] = (n * n);
            }

            for (int i = 0; i < (n / 2); i++)
            {
                for (int j = i; j < (n - i); j++)
                { 
                    a[i,j] = m;
                    m++;
                }
                for (int j = 1; j < (n - i - i); j++)
                { 
                    a[(j + i),(n - i) - 1] = m; 
                    m++;
                }
                for (int j = (n - 2) - i; j >= i; j--)
                { 
                    a[(n - i) - 1, j ] = m; 
                    m++;
                }

                for (int j = ((n - i) - 2); j > i; j--)
                {
                    a[j,i] = m;
                    m++;
                }

            }



            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write ( a[i,j]+" ");
                }

                Console.WriteLine(a[i,n - 1]) ;

            }
            Console.Read();

        }
    }

}
    

