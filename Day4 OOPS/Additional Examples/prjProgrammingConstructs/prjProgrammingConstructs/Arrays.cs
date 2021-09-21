

using System;

class Arrays
{
    int n;

    void CheckArrays()
    {
        n = 5;

        int[] arr1;
        arr1 = new int[n];
        //or
        int[] arr2 = new int[5];

        for (int i = 0; i < arr2.Length; i++)
        {
            Console.WriteLine("Enter the Number");
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

        //for (int i = 0; i < arr2.Length; i++)
        //{
        //    Console.WriteLine(arr2[i]);
        //}

        foreach (int mynumber in arr2)
        {
            Console.WriteLine("The Numbers in the array are : "+mynumber);
        }


    }

    static void Main()
    {
        Arrays myobj = new Arrays();
        myobj.CheckArrays();
        Console.ReadKey();
    }
}

