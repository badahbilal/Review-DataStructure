using System;

namespace Linear_D_S_Stack_Balanced_Parentheses
{
    internal class Program
    {
        public class Stack
        {


            char[] arrValues = new char[1000];

            int indexTop = 0;

            public void Push(char val)
            {
                if (indexTop == 999)
                    return;
                arrValues[indexTop] = val;
                indexTop++;
            }

            public void Pop()
            {
                if (!isEmpty())
                    indexTop--;
            }

            public char TopValue()
            {
                if (isEmpty()) return '0';
                return arrValues[indexTop - 1];
            }

            public bool isEmpty()
            {
                return indexTop == 0;
            }




        }

        static bool Pair(char open,char close)
        {
            if (open == '(' && close == ')') return true;
            if (open == '{' && close == '}') return true;
            if (open == '[' && close == ']') return true;

            return false;
        }

         static bool Balenced(string expression)
        {
            if(expression == "") return false;
            Stack openBracket = new Stack();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(' || expression[i] == '{' || expression[i] == '[')
                {
                    openBracket.Push(expression[i]);

                }
                else if (expression[i] == ')' || expression[i] == '}' || expression[i] == ']')
                {
                    if (openBracket.isEmpty()) return false;
                    else if (!Pair(openBracket.TopValue(), expression[i])) return false;

                    openBracket.Pop();

                }
            }
            if(openBracket.isEmpty()) return true;

            return false;
        }

        static void Main(string[] args)
        {
            string s = "";

            if (Balenced(s)) Console.WriteLine("Expression is Balanced");
            else Console.WriteLine("Expression is not Balanced");
        }
    }
}
