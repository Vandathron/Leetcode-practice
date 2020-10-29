using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            String reversed = "";
                for (int i = (x.ToString().Length - 1); i >= 0; i--)
                {
                reversed += x.ToString()[i];
                }

            return reversed == x.ToString() ? true : false;
        }
    }
}
