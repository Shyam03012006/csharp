using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float p, r, n, i;

            Console.Write("enter principal value");
            p = float.Parse(Console.ReadLine());

            Console.Write("enter principal value");
            r = float.Parse(Console.ReadLine());

            Console.Write("enter principal value");
            n = float.Parse(Console.ReadLine());

            i = p * r * n;
            i = i / 100;

            Console.WriteLine("simple intrest" + i);
        }
    }
}
