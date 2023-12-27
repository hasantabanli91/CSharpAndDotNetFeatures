using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAndDotNetFeatures
{
    public class Delegates
    {
        public delegate long MathFourOperationsHandler(long a, long b);

        public long Sum(long a, long b)
        { return a + b; }

        public long Substraction(long a, long b)
        { return a - b; }

        public long Multiplication(long a, long b)
        { return a * b; }

        public double Divide(long a, long b)
        { return a / b; }
    }
}
