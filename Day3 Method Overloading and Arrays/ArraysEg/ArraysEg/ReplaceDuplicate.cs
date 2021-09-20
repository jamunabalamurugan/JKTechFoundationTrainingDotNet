using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEg
{
    class ReplaceDuplicate
    {
		static void Replace()
		{
			
			int i, j, k, Size;

            Console.WriteLine ("\n Please Enter Number of elements in an array  :   ");
			Size = int.Parse(Console.ReadLine());
			int[] arr = new int[Size];
			Console.WriteLine("\n Please Enter elements of an Array \n", Size);
			for (i = 0; i < Size; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}

			for (i = 0; i < Size; i++)
			{
				for (j = i + 1; j < Size; j++)
				{
					if (arr[i] == arr[j])//to check if there is any duplicate
					{
						for (k = j; k < Size; k++)
						{
							arr[k] = arr[k + 1];//replace the  duplicate value
						}
						Size--;//resize the array
						j--;
					}
				}
			}

			Console.WriteLine("\n Final Array after Deleteing Duplicate Array Elements is:\n");
			for (i = 0; i < Size; i++)
			{
				Console.WriteLine("{0}\t", arr[i]);
			}
			
		}
		public static void Main()
        {
			Replace();
			Console.ReadKey();
        }

	}
}
