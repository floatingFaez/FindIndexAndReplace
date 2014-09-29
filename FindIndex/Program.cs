using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string foo = "Hello world";
            int index = foo.IndexOf("l", foo.IndexOf("l")+ 1);
            int bar = foo.LastIndexOf("l");
            string sub = foo.Substring(6);
            string remove = foo.Remove(5,6);
            string replac = foo.Replace("l", "r");
            string empty = foo.Replace("Hello ", string.Empty);

            Console.WriteLine("index of l is = " + index);

            Console.WriteLine("index of second l is = " + bar);

            Console.WriteLine("substring is = " + sub);

            Console.WriteLine("remove operation is = " + remove);

            Console.WriteLine("replace string is = " + replac);

            Console.WriteLine("empty remove operation is = " + empty);

            Console.ReadKey();

        }
    }
}
