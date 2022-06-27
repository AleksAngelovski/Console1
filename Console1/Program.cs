using System;
using System.Linq;
using Console1.MeList;

class MainClass
{
    static void Main()
    {
        MeList<int> list = new MeList<int>();
        list.Add(1);
        list.Add(2);    
        list.Add(3);

        list.PrintList();

        //list.Add(new[] { 2, 2, 1, 3, 4, 5, 563, 23, 12, 2 });

    }
       
}
 
