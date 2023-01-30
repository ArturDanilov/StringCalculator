using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public int AddNumber(string input)
        {
            if (input == "" || input == "0")
                return 0;
            return 1;
        }
    }
}
