using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodes.Numbers
{
    public class FibonacciSeries
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 1, c;
            Console.Write(a + "  " + b+" ");
            for(int i=1;i<=10;i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
