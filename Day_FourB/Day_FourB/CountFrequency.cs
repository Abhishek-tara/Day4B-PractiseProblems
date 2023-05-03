using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_FourB
{
    public class CountFrequency
    {
        public void Count()
        {
            int i, j, num, count;
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

            //Count frequency
            for (i = 0; i < num; i++)
            {
                int target = arr[i];
                count =  0;

                if(target == -1)
                {
                    continue;
                }
                for(j=0;j<num; j++)
                {
                    if (arr[j] == target)
                    {
                        count++;
                        arr[j] = -1;
                    }
                }
                Console.Write(target + " : " + count + " times" + "\n");
            }
            Console.ReadKey();
        }
    }
}
