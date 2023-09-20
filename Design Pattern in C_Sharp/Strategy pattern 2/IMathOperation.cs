using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern_2
{
    public interface IMathOperation
    {
        public void Execute(double firstNum, double secondNum);
    }
}
