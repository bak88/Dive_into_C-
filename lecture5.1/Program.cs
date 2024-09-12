using System.Collections;
using System.Collections.Immutable;
using System.Threading.Tasks.Dataflow;

namespace lecture5._1
{
    internal class Program
    {
        static bool ValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '[')
                {
                    stack.Push(']');
                }
                if (c == '(')
                {
                    stack.Push(')');
                }
                if (c == '{')
                {
                    stack.Push('}');
                }
                if ("])}".Contains(c))
                {
                    if (stack.Count == 0)
                        return false;
                    if (stack.Pop() != c) 
                        return false;
                }


            }
            return stack.Count == 0;

        }

        static void Main()
        {
            Console.WriteLine(ValidParentheses("{}()"));

        }

    }
}