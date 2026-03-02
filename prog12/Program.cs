using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int no = int.Parse(Console.ReadLine());
            int m;
            int sum = 0;

            while (no > 0)
            {
                m = no % 10;
                no =  no/10;
                sum = sum + m;
               
            }
            Console.WriteLine("sum=" + sum);
        }
    }
}
