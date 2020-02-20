using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstndlastname
{
    class Program
    {
        static void Main(string[] args)
        {
            fullname("Supraja", "Baratam");
        }

        static void fullname(string fn, string ln)
        {
            string s = string.Concat(fn, " ", ln);
            Console.WriteLine(s); 
        }
    }
}
