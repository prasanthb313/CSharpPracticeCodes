using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodes.Strings
{
    public class RefExample
    {
        
        public static void Main(string[] args)
        {
            int a = 5;
            login(ref a);
            Console.WriteLine(a);
            

        }
        public static void login(ref int a)
        {
            a = 100;
        }
    }
}
