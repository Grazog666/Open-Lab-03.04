using System;

namespace Open_Lab_03._04
{
    public class Numbers
    {
        public string EvenOrOdd(int number)
        {
            int i = number % 2;
            if (i == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
    }
}
