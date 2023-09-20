using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern_2
{
    public class Calculator
    {
        private IMathOperation _operation;
        public Calculator(IMathOperation operation)
        {
            _operation = operation;
        }
        public void Calculate(double firstNum, double secondNum)
        {
            _operation.Execute(firstNum, secondNum);
        }
    }
}
