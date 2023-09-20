using System;

namespace Strategy_pattern_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator sum = new Calculator(new SumOperation());
            sum.Calculate(45, 20.5);
            Calculator diff = new Calculator(new SubtractOperation());
            diff.Calculate(67.89, 34);
            Calculator mul = new Calculator(new MultiPlyOperation());
            mul.Calculate(20, 10);

            Console.ReadKey();
        }
    }
}
