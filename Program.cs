using System;

namespace AlgoPractice
{
    class Program
    {
        static void Main(string[] args)
        {            
            BstConstruction myBst = new BstConstruction(10);
            myBst.Insert(5).Insert(5).Insert(2).Insert(1).Insert(15).Insert(13).Insert(14).Insert(22);
            myBst.FindClosestValue(12);

        }
    }
}
  