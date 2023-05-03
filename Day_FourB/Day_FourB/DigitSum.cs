using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_FourB
{
    public class DigitSum
    {
        public void Sum()
        {
            int num = 456;
            Console.WriteLine($"Given number: {num}");
            int sum = 0, rem;
            while(num > 0)
            {
                rem = num % 10;
                sum += rem;
                num /= 10;
            }
            Console.WriteLine($"Sum of digits is: {sum}");
        }
    }
}
