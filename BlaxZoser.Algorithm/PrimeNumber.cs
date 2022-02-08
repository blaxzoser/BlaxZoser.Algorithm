using System;
using System.Collections.Generic;
using System.Text;

namespace BlaxZoser.Algorithm
{
    public class PrimeNumber : INumber 
    {
        private readonly IMath _factorial;
        public PrimeNumber()
        {          
        }

        public PrimeNumber(IMath factorial)
        {
            _factorial = factorial;
        }

        public int[] GiveAll(int n)
        {
            int[] array = new int[n];
            int counter = 0;
            int number = 1;
            while (counter < n)
            {
                    if(IsPrime(number))
                    {
                        array[counter] = number;
                        counter++;
                    }
              number++;
            }
            return array;
        }


        public  bool IsPrime(int n)
        {
            if (n <= 2 || n % 2 == 0) 
                return n == 2;
            
            for (var i = 3; i <= Math.Sqrt(n); i += 2) 
            {
                if (n % i == 0) 
                    return false;
            }
            return true;
        }

        public bool Is(int number)
        {
            if (number == 1  || number == 0)
                return false;

            int counter = 0;
            int divisores = 0;
            while (counter < number)
            {
                if (number % (number - counter) == 0)
                {
                    divisores++;
                }
                counter++;
            }
            return divisores > 2?false:true;
        }

        public bool ApplyThehoremaWilson(int number)
        {
            return (_factorial.Calculate(number - 1 ) + 1) % number==0?true:false;
        }

    }
}
