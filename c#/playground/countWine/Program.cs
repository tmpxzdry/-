using System;

namespace countWine
{
  class Program
  {
    static void Main(string[] args)
    {
      CountWine c=new CountWine();
      int result=c.CalculateWine(5,0,0);
      System.Console.WriteLine(result);
    }
  }

  class CountWine
  {
    public int CalculateWine(int wineInit, int capCount, int bottleCount){
      System.Console.WriteLine("本轮酒数:{0},酒瓶数:{1},瓶盖数:{2}",wineInit,capCount,bottleCount);
      int remain,div,wineCount=0;

      if(wineInit==0){
        return wineInit;
      }
      System.Console.WriteLine(wineInit);
      capCount+=wineInit;     //瓶盖数
      bottleCount+=wineInit;  //酒瓶数

      if(capCount!=0){
        remain=capCount%4;
        div=capCount/4;
        wineCount+=div;
        capCount=remain;
      }
      if(bottleCount!=0){
        remain=bottleCount%2;
        div=bottleCount/2;
        wineCount+=div;
        bottleCount=remain;  
      }

      wineInit+=CalculateWine(wineCount,capCount,bottleCount);
      return wineInit;
    }

  }
}
