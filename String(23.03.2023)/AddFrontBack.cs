using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class AddFrontBack
    {
        public static void Main(string[] args)
        {
             //Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.
            string str1 = "FrontBack";
            if (str1.Length == 1)
            {
                Console.WriteLine(str);
            }
            else
            {
                string str2 = str1.Substring(str1.Length - 1) + str1 + str1.Substring(str1.Length - 1);
                Console.WriteLine(str2);
            }
       }
    }
 }
