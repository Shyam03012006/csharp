using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:-");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 2; i < n; i++) 
            {

                if (n % i == 0)
                {
                    Console.WriteLine("Not A Prime Number");
                    break;
                }
                
                
            }
            if(i==n)
            {
                Console.WriteLine("Number is Prime");
            }
        }
    }
}
