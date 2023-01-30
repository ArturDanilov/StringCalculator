using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public int AddAndParseNumber(string input)
        {
            if (input == "" || input == "0")
                return 0;
            
            char delimeter;

            //if delimeter = '+' => +;
            //if delimeter = '-' => -;
            //if delimeter = '*' => *;
            //if delimeter = '/' => /;

            if (input.Contains('+'))
            {
                delimeter = '+';
            }
            if (input.Contains('-'))
            {
                delimeter = '-';
            }
            if (input.Contains('*'))
            {
                delimeter = '*';
            }
            else
            {
                delimeter= '/';
            }

            var inputSplit = input.Split(',');
            int sum = 0;

            foreach (var i in inputSplit)
                sum += int.Parse(i);

            return sum;
        }
    }
}
