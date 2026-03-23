using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENETER YOUR AGE");
            int a = int.Parse(Console.ReadLine());

            if (a < 12)
            {
                Console.WriteLine("YOU ARE A KID");
            }
            else if (a >= 12 && a < 18)
            {
                Console.WriteLine("YOU ARE A TEENAGER");
            }
            else if (a >= 18 && a < 60)
            {
                Console.WriteLine("YOU ARE AN ADULT");
            }
            else if (a >= 60) ;
            {
                Console.WriteLine("YOU ARE A SINOR CITIZEN");
            }
            
        }
    }
}
