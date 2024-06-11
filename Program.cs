using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Assignment6._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

    }

    internal class Stack
    {
        const int max = 1000;
        int top;
        private int[] stack = new int[max];
        public bool Push()
        {
            if (top >= max)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[top++] = top;
                return true;
            }
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                return stack[top--];
            }
        }
    }

    
}
