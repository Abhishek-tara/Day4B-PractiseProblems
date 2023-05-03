using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_FourB
{
    public class FindMinMax
    {
        public void Find()
        {
            int min, max , i , num;
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

            min = max = arr[0];
            for ( i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine($"Min value is: {min}");
            Console.WriteLine($"Max value is: {max}");
            Console.ReadKey();
        }
    }
}
