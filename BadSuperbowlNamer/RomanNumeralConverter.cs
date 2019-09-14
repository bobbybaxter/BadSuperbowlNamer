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

            int valueCheck(int passedValue, int numberToCheck, string romanNumeralSymbol)
            {
                if (passedValue >= numberToCheck && passedValue % numberToCheck >= 0)
                {
                    parts.Add(romanNumeralSymbol);
                    passedValue -= numberToCheck;
                    return passedValue;
                }
                return passedValue;
            }

            int valueCheckWithLoop(int passedValue, int numberToCheck, string romanNumeralSymbol)
            {
                if (passedValue >= numberToCheck && passedValue % numberToCheck >= 0)
                {
                    int quotient = passedValue / numberToCheck;
                    for (var i = 0; i < quotient; i++)
                    {
                        parts.Add(romanNumeralSymbol);
                        passedValue -= numberToCheck;
                    }
                    return passedValue;
                }
                return passedValue;
            }

            while (value != 0)
            {
                value = valueCheck(value, 800, "DCCC");
                value = valueCheck(value, 700, "DCC");
                value = valueCheck(value, 600, "DC");
                value = valueCheckWithLoop(value, 500, "D");
                value = valueCheck(value, 90, "XC");
                value = valueCheck(value, 60, "LX");
                value = valueCheck(value, 40, "XL");
                value = valueCheckWithLoop(value, 10, "X");
                value = valueCheck(value, 9, "IX");
                value = valueCheck(value, 5, "V");
                value = valueCheck(value, 4, "IV");
                value = valueCheck(value, 1, "I");
            }

            var RomanNumeral = String.Join("", parts);
            return RomanNumeral;
        }
    }
}
