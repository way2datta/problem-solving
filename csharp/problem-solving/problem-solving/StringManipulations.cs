using System.Collections.Generic;

namespace ProblemSolving
{
    public class StringManipulations
    {
        public static bool ContainsBalancedParanthesis(string expression)
        {
            Stack<char> braces = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                var letter = expression[i];
                if (letter == '{' || letter == '(' || letter == '[')
                {
                    braces.Push(letter);
                    continue;
                }

                char topBrace = braces.Peek();

                if ((letter == '}' && topBrace == '{') ||
                    (letter == ')' && topBrace == '(') ||
                    (letter == ']' && topBrace == '['))
                {
                    braces.Pop();
                }
            }

            return braces.Count == 0;
        }
    }
}