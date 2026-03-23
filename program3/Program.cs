using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program for calculating compound interest");
            float p, r, n, i,amount;

            Console.Write("enter value of principal: ");
            p = float.Parse(Console.ReadLine());

            Console.Write("enter value of rate of interest: ");
            r = float.Parse(Console.ReadLine());

            Console.Write("enter value for number of year: ");
            n = float.Parse(Console.ReadLine());

            amount = p;
            for(int si = 0; si<n; si++)
            {
                amount += amount * (r / 100);
            }
            i = amount - p;

            Console.WriteLine("compound interest: " + i);
        }
    }
}
