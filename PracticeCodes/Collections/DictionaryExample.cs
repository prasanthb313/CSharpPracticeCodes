using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodes.Collections
{
    public class DictionaryExample
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> exam = new Dictionary<string, string>();
            exam.Add("1", "prasanth");
            exam.Add("2", "nagarjuna");
            exam.Add("3", "baddepudi");
            exam.Add("4", "chowdary");


            foreach(KeyValuePair<string,string> kv in exam)
            {
                Console.WriteLine("Key = {0}, Value = {1}" ,kv.Key , kv.Value);
            }
        }
    }
} 
