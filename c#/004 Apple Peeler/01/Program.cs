﻿using System;

namespace _01
{
    public class ApplePeeler{
        public static int[] Peel(int[][] m){
            if(m==null)return new int[0];
            int sr=0,sc=0,h=m.Length,w=m[0].Length,p=0;
            int[] result=new int[h*w];

            while(true){
                if(h==0||w==0)break;
                for(int c=sc;c<sc+w;c++)
                    result[p++]=m[sr][c];
                sr+=1;
                h-=1;
                if(h==0||w==0)break;
                for(int r=sr;r<sr+h;r++)
                    result[p++]=m[r][sc+w-1];
                w-=1;
                if(h==0||w==0)break;
                for(int c=sc+w-1;c>=sc;c--)
                    result[p++]=m[sr+h-1][c];
                h-=1;
                if(h==0||w==0)break;
                for(int r=sr+h-1;r>=sr;r--)
                    result[p++]=m[r][sc];
                sc+=1;
                w-=1;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int [][] m=new[]{
                new[]{1,2,3,4,5},
                new[]{14,15,16,17,6},
                new[]{13,20,19,18,7},
                new[]{12,11,10,9, 8}
            };
            int[] result=ApplePeeler.Peel(m);
            System.Console.WriteLine(String.Join("->",result));
        }
    }
}
