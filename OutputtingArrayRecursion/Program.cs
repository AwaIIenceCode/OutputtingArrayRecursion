using System;
class MyClass
{
    static void Generaterray(int[] programmArry, Random rnd, int iterator)
    {
        if (iterator >= programmArry.Length) return;
        
        programmArry[iterator] = rnd.Next(-11, 11);
        
        Generaterray(programmArry, rnd, iterator + 1);
    }

    static void PrintArray(int[] programmArray, int iterator)
    {
        if (iterator >= programmArray.Length) return;
        
        Console.Write(programmArray[iterator] + " ");
        
        PrintArray(programmArray, iterator + 1);
    }
    static void Main()
    {
        Random rnd = new Random();
        int iterator = 0;
        
        const byte arraySize = 15;
        int[] programmArray = new int [arraySize];

        Generaterray(programmArray, rnd, iterator);
        PrintArray(programmArray, iterator);

    }
}