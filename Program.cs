using System;

namespace AlgoPractice
{
    class Program
    {
        static void Main(string[] args)
        {            
            BstConstruction myBst = new BstConstruction(10);
            myBst.Insert(5);
            myBst.Insert(15);
            myBst.Insert(2);
            myBst.Insert(5);
            myBst.Insert(1);
            myBst.Insert(13);
            myBst.Insert(22);
            myBst.Insert(14);
        }
    }
}
  