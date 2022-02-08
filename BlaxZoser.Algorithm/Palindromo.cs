using System;
using System.Collections.Generic;

namespace BlaxZoser.Algorithm
{

    public class Palindromo : IAlgorithm
    {
        private string _sentence;
        public bool Calculate(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                throw new Exception("It's empty");

            _sentence = sentence.ToLower().Replace(" ","");
            int length = _sentence.Length;
            char[] array = _sentence.ToCharArray();
            for (int i = 0; i <length; i++)
            {
                for (int j = length - 1 - i; j >= 0; j--)
                {
                    if (array[i] != array[j])
                    {
                        return false;
                    }
                    break;
                }
            }
            return true;
        }

        public Palindromo()
        {
        } 
    }
}
