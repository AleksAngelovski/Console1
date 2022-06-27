using System;

class MainClass
{
    static void Main()
    {
        int[][] partiesJagged = new int[3][];
        partiesJagged[0] = new int[] { 25, 27, 28, 29 };
        partiesJagged[1] = new int[] { 25, 27, 28, 66 };
        partiesJagged[2] = new int[] { 25, 27, 28, 29, 30, 32 };
        int totalAge = 0;

        foreach (int[] thisRow in partiesJagged)
        {
            foreach(int i in thisRow)
            {
                Console.WriteLine(i);
                totalAge++;
            }
        }
        Console.WriteLine("Total age: " + totalAge);    
    }
    private static void MainMenu()
    {
        
    }
}
 
