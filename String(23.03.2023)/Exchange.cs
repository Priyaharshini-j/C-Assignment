using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Exchange
    {
        public static void Main(string[] args)
        {
            //Write a C# Sharp program to exchange the
            //first and last characters in a given string and return the new string
            string str = "FirstLast";
            if (str.Length == 1)
            {
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine(str.Substring(str.Length - 1)+str.Substring(1,str.Length-2)+str.Substring(0,1));
            }
            //We can also use this method using ternary operator
            Console.WriteLine(str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str);
            }
      }
}
