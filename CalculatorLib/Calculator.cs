using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Calculator
    {
        public int Add(int firstNum,int secondNum)
        {
            if (firstNum > 0 && secondNum > 0)
                return firstNum + secondNum;
            else if (firstNum > 0 && secondNum <= 0)
                return -1;
            else if (firstNum <= 0 && secondNum > 0)
                return -2;
            else
                return 0;
        }
    }
}
