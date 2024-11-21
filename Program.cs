


using System;

public class main
{

    public static void Main()
    {
        int[] array = new int[6] { 1, 2, 33, 4, 57, 6 };
        string[] cars = new string[4] { "tata", "suzuki", "toyota", "mahendra" };

        foreach (int i in array )
        {
            Console.WriteLine(i);
           
        }
        Array.Sort(array);
        foreach (int i in array )
        Console.WriteLine(i);

        foreach (string  i in cars) Console.WriteLine(i);


    }
}