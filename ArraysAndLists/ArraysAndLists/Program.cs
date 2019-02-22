using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        int[] numArray1 = new int[] { 3, 7, 17, 175, 3333 };

        int[] numArray2 = { 6, 12, 24, 48, 96, 192 };

        int n = 0;
        while(n < numArray.Length)
        {
            Console.WriteLine(numArray[n]);
            Console.WriteLine(numArray1[n]);
            Console.WriteLine(numArray2[n]);
            n++;
        }
        Console.ReadLine();

        List<int> intlist = new List<int>();
        intlist.Add(4);
        intlist.Add(10);

        Random rand = new Random();
        n = 0;
        for (n = 0; n < 5; n++)
            intlist.Add(rand.Next());
        n = 0;
        while (n < intlist.Count)
        {
            Console.WriteLine(intlist[n]);
            n++;
        }
        Console.ReadLine();
        
    }
}

