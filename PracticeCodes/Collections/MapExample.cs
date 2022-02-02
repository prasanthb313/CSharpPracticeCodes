using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodes.Collections
{
    public class MapExample
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> exam = new Dictionary<string, string>();
            exam.Add("1", "prasanth");
            exam.Add("1", "nagarjuna");
            exam.Add("2", "baddepudi");
            exam.Add("1", "chowdary");

            foreach (KeyValuePair<string, string> kv in exam)
            {
                Console.WriteLine(kv.Key + "is  " + kv.Value);
            }
        }
    }
}
