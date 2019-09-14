using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer
{
    public class RomanNumeralConverter
    {
        public string ConvertNumber(int number)
        {
            var value = number;
            List<string> parts = new List<string>();

            while (value != 0)
            {
                if (value >= 10 && value % 10 >= 0)
                {
                    parts.Add("X");
                    value -= 10;
                }

                if (value > 0 && value % 9 == 0)
                {
                    parts.Add("IX");
                    value -= 9;
                }

                if (value > 0 && value % 5 == 0)
                {
                    parts.Add("V");
                    value -= 5;
                }

                if (value > 0 && value % 1 == 0)
                {
                    parts.Add("I");
                    value--;
                }
            }

            var RomanNumeral = String.Join("", parts);
            return RomanNumeral;
        }
    }
}
