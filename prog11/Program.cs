using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end;
            Console.Write("starting range:");
            start = int.Parse(Console.ReadLine());
            Console.Write("ending range:");
            end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int a = 0;
                for (int j = 2; j <= i; j++)
                {
                    if(j%i == 0)
                    {
                        a++;
                        Console.WriteLine(a);
                        break;
                    }
                    else if(j == start)
                    {
                        Console.WriteLine("prime numbers:" + i);
                        break;
                    }
                }
            }


        }
    }
}
