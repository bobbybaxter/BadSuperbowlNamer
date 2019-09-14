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
                if (value >= 40 && value % 40 >= 0)
                {
                    parts.Add("XL");
                    value -= 40;
                }

                if (value >= 10 && value % 10 >= 0)
                {
                    int quotient = value / 10;
                    for (var i = 0; i < quotient; i++)
                    {
                        parts.Add("X");
                        value -= 10;
                    }
                }

                if (value >= 9 && value % 9 >= 0)
                {
                    parts.Add("IX");
                    value -= 9;
                }

                if (value >= 5 && value % 5 >= 0)
                {
                    parts.Add("V");
                    value -= 5;
                }

                if (value >= 4 && value % 4 >= 0)
                {
                    parts.Add("IV");
                    value -= 4;
                }

                if (value >= 1  && value % 1 == 0)
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
