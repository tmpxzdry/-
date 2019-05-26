using System;
using System.Collections.Generic;

namespace _01
{
    public class Solution{
        private IList<string> result;

        public IList<string> Permute(int n){
            result=new List<string>();
            DFS(n,1,0,"女");
            DFS(n,0,1,"男");
            return result;
        }

        private void DFS(int n,int fc,int mc,string solution){
            if(fc==n&&mc==n){
                result.Add(solution);
                return;
            }
            if(fc<n) DFS(n,fc+1,mc,solution+"女");
            if(mc<n) DFS(n,fc,mc+1,solution+"男");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var solution=new Solution();
            var result=solution.Permute(3);
            foreach(var str in result){
                System.Console.WriteLine(str);
            }
        }
    }
}
