using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ReverseInt
    {

        public int Reverse(int x)
        {
            String numberInString = x.ToString();
            String numbers = "";
            if (numberInString.StartsWith("-"))
            {
                numbers = "-";
                for(int i = (numberInString.Length-1); i > 0; i--)
                {
                    numbers += numberInString[i];
                }
            }

            else
                for (int i = (numberInString.Length - 1); i >= 0; i--)
                {
                    numbers += numberInString[i];
                }
            try
            {
                return int.Parse(numbers);
            } catch (System.OverflowException e)
            {
                return 0;
            }
        }
    }
}
