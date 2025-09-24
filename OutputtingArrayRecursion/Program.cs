using System;
class MyClass
{
    static void GenerateArray(int[] programmArray, Random rnd, int iterator)
    {
        if (iterator >= programmArray.Length) return;
        
        programmArray[iterator] = rnd.Next(-11, 11);
        
        GenerateArray(programmArray, rnd, iterator + 1);
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

        GenerateArray(programmArray, rnd, iterator);
        PrintArray(programmArray, iterator);

    }
}