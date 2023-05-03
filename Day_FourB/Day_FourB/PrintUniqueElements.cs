using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_FourB
{
    public class PrintUniqueElements
    {
        public void Print()
        {
            int i, j, num, count ;
            //Reads size of the array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];

            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                Console.Write($"Insert value at {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //PrintUnique
            Console.WriteLine("\nUnique elements in array are:");
            for (i = 0; i < arr.Length; i++)
            {
                count = 0;
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                        count++;
                }
                if (count == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
