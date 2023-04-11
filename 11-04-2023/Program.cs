using System;
using System.Collections.Generic;

namespace Assignments
{
    internal class Program
    {
        /*
         * 
         * Question 1:
         * Check if parentheses are balanced using Stack
         * Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
         * Example 1:
         * Input: n = 3
         * Output: ["((()))","(()())","(())()","()(())","()()()"]
         *
         */
        static void Main(string[] args)
        {
            //for enterning the number of prathesis we need to generate
            Console.WriteLine("Enter the number of paranthesis");
            int n = int.Parse(Console.ReadLine()!);
            foreach (var res in BalancedParentheses(0, 0, n))
            {
                Console.WriteLine(res);
            }
        }

        //we are sending it tothe function BalancedParathesis with the 3 parameters
        //open_paran represent the number of open parameter we actually inserted
        //close_paran represent number of close parameter we actually inserted

        public static Stack<string> BalancedParentheses(int open_paren, int close_paren, int n)
        {
            Stack<char> parentheses = new Stack<char>();
            Stack<string> result = new Stack<string>();
            GenerateParentheses(open_paren, close_paren, n, parentheses, result);
            return result;
        }
        //GenerateParanthesis is a recurrsive paranthesis to generate the balanced paranthesis
        public static void GenerateParentheses(int open_paren, int close_paren, int n, Stack<char> parentheses, Stack<string> result)
        {
            //if the close_paren = n, it means that we inserted the balanced parathesis with n
            //eg: if the close paran is 3 and n is 3 it means that there are no more parathesis we need to balance in the stack
            if (close_paren == n)
            {
                //as we have paranthesis stack as char, we need to first convert it into the string then we have to push the result inot the result stack

                string result_parentheses = "";
                // as we are using stack, it is LIFO  we need to make it FIFO so we make use of this foreach function
                foreach(char ch in parentheses)
                {
                    result_parentheses= ch+result_parentheses;
                }
                // then we add this parentheses type to the result 
                result.Push(result_parentheses);
                return;
            }

            // if the open paren is < n, that means we still havent push the open paren upto n 
            if (open_paren < n)
            {
                parentheses.Push('(');
                GenerateParentheses(open_paren + 1, close_paren, n, parentheses, result);
                parentheses.Pop();
            }

            // if the close_paren is < n, that means we still havent push the close paren upto n 
            if (close_paren < open_paren)
            {
                parentheses.Push(')');
                GenerateParentheses(open_paren, close_paren + 1, n, parentheses, result);
                parentheses.Pop();
            }
        }
    }
}
