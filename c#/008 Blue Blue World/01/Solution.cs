using System;
using System.Collections.Generic;

public class Solution{
    public int CountIsLands(int[][] sea, int level){
        int h=sea.Length,w=sea[0].Length;
        int[][] directions={new[]{-1,0},new[]{1,0},new[]{0,-1},new[]{0,1}};
        for(int r=0;r<h;r++){
            for(int c=0;c<w;c++){
                sea[r][c]=sea[r][c]>level?1:0;
            }
        }

        int counter=0;
        for(int r=0;r<h;r++){
            for(int c=0;c<w;c++){
                if(sea[r][c]==0) continue;
                counter++;
                var q=new Queue<int>();
                sea[r][c]=0;
                q.Enqueue(r);
                q.Enqueue(c);
                while(q.Count>0){
                    int cr=q.Dequeue(),cc=q.Dequeue();
                    foreach(var dir in directions){
                        int nr=cr+dir[0],nc=cc+dir[1];
                        if(nr>=0&&nr<h&&nc>=0&&nc<w)
                            if(sea[nr][nc]==1){
                                sea[nr][nc]=0;
                                q.Enqueue(nr);
                                q.Enqueue(nc);
                            }
                    }
                }
            }
        }

        return counter;
    }


}