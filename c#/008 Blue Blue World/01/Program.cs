using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] sea={
                new[]{0,1,0,0,0,0},
                new[]{0,2,0,0,0,0},
                new[]{2,3,2,3,0,0},
                new[]{0,0,4,0,0,0},
                new[]{0,2,1,2,3,1},
                new[]{2,2,1,1,2,1}
            };

            var solution=new Solution();
            var result=solution.CountIsLands(sea,5);
            System.Console.WriteLine(result);
        }
    }
}
