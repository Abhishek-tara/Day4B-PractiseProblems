﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_FourB
{
    public class CountDuplicate
    {
        public void CountMethod()
        {
            int i, j, num, count = 0;
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
            //Find all duplicate elements in array
            for(i = 0; i < num; i++)
            {
                for(j=i+1;j<num;j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("\n Total number of duplicate elements found in array:" + count);
            Console.ReadKey();
        }
    }
}
