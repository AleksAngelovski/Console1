using System;
using System.Linq;
using Console1.MeList;

class MainClass
{
    static void Main()
    {
        var list = new MeList<int>();

        int currentCapacity = list.Capacity;
        for(int i = 0; i < 500; i++)
        {
            list.Add(i);
            if(currentCapacity != list.Capacity)
            {
                Console.WriteLine("Resized to" + list.Capacity);
                currentCapacity = list.Capacity;
            }
        }
        //list.PrintList();
        list.TrimExcess(); Console.WriteLine("Trimming: ");
        Console.WriteLine(list.Capacity);
   

        //list.Add(new[] { 2, 2, 1, 3, 4, 5, 563, 23, 12, 2 });

    }
       
}
 
