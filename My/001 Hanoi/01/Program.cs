using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi h = new Hanoi();
            string A = "A";
            string B = "B";
            string C = "C";
            long result = h.Process(3, A, B, C);
            System.Console.WriteLine(result);
        }
    }

    class Hanoi
    {
        private int count = 0;

        public long Process(int n, string X, string Y, string Z)
        {
            if (n == 1)
            {
                count++;
                System.Console.WriteLine("{0}.{1}->{2}", count, X, Z);
            }
            else
            {
                Process(n - 1, X, Z, Y);
                count++;
                System.Console.WriteLine("{0}.{1}->{2}", count, X, Z);
                Process(n - 1, Y, X, Z);
            }
            return count;
        }
    }
}
