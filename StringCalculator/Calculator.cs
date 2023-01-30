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
            
            //var delimeter = ''; 

            //if delimeter = '+' => +;
            //if delimeter = '-' => -;
            //if delimeter = '*' => *;
            //if delimeter = '/' => /;

            var inputSplit = input.Split(
                new string[] { ",", ".", "/", "|", ":", ";", "\r\n", "\r", "\n" },
                StringSplitOptions.None);
            int sum = 0;
            foreach (var i in inputSplit)
                sum += int.Parse(i);

            return sum;
        }
    }
}
