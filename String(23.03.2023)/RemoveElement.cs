using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class RemoveElement
    {
        public static void Main(string[] args)
        {            
            //Write a C# Sharp program to check if a string 'ok' appears in a given string.
            //If it appears return a string without 'ok'
            //otherwise return the original string.

            string s= "Itsalrightok everyothing be ookk";
            Console.WriteLine(s.Contains("ok"));
            while(s.Contains("ok"))

            {
                if (s.Contains("ok"))
                {
                    Console.WriteLine(s.IndexOf("ok"));
                    s = s.Remove(s.IndexOf("ok"),2);
                }
                else
                {
                    Console.WriteLine(s);
                }

            }
                Console.WriteLine(s);


            //


        }
    }
}
