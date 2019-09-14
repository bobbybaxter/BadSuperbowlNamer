using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer
{
    public class RomanNumeralConverter
    {
        public string ConvertNumber(int number)
        {
            var input = number;
            string numeralResult = "No number selected";

            if (input == 1)
            {
                numeralResult = "I";
                return numeralResult;
            }
            
            return numeralResult;

        }
    }
}
