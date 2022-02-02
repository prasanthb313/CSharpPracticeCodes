using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodes.Collections
{
    public class ListExample
    {
        public static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("prasanth");
            names.Add("nagarjuna");
            foreach(string na in names)
            {
                Console.WriteLine(na);
                Console.WriteLine(names.Count);
            }
        }
    }
}
