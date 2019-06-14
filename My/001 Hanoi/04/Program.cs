using System;

namespace _04
{
    class Program
    {
        static int count=0;
        static void Main(string[] args)
        {
            string X="A";
            string Y="B";
            string Z="C";
            long result=Process(3,X,Y,Z);
            System.Console.WriteLine(result);
        }

        static long Process(int n, string X,string Y,string Z){
            if(n==1){
                count++;
                System.Console.WriteLine("{0} {1}->{2}",count,X,Z);
            }else{
                Process(n-1,X,Z,Y);
                count++;
                System.Console.WriteLine("{0} {1}->{2}",count,X,Z);
                Process(n-1,Y,X,Z);
            }
            return count;
        }
    }
}
