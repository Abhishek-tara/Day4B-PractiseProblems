using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_FourB
{
    public class ReverseWord
    {
        public void PrintReverse()
        {
            string str = "Hi, how are you!";
            Console.Write("Given string: ");
            Console.WriteLine(str);
            string[] rev = str.Split(' ');
            string revStr = "";
            for(int i = rev.Length - 1; i >= 0; i--)
            {
                revStr += rev[i] + " ";
            }
            Console.Write("Reverse string: ");
            Console.WriteLine(revStr);
        }
    }
}
