using System;
using System.Collections.Generic;
using System.Text;

namespace BlaxZoser.Algorithm
{
    public class Factorial : IMath
    {
        public int Calculate(int n)
        {
            return n == 1 ? n : n * Calculate(n - 1);
        }
    }
}
