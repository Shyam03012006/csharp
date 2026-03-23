using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using u4p1;

namespace unit1program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle r1 = new rectangle();
            r1.cal();
            r1.dis();
            rectangle r2 = new rectangle(30,40);
            r2.cal();
            r2.dis();
        }
    }
}
