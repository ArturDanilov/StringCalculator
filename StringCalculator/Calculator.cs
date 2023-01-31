using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string input)
        {
            //if 0 or empty
            if (input == "" || input == "0")
                return 0;

            string[] number = input.Split(' ');

            //if one parameter || is integer
            int intCount = 0;
            foreach (string s in number)
                intCount++;
            if (intCount == 1)
                return int.Parse(input);

            //if two parameter wilth delimeter
            
            var inputSplit = input.Split(
                new char[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries);

            //take delimeter
            char delimeter = ' ';
            if (input.Contains('+'))
                delimeter = '+';
            if (input.Contains('-'))
                delimeter = '-';
            if (input.Contains('*'))
                delimeter = '*';
            if (input.Contains('/'))
                delimeter = '/';

            int a = int.Parse(inputSplit[0]);
            int b = int.Parse(inputSplit[2]);
            
            switch (delimeter)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }
    }
}
