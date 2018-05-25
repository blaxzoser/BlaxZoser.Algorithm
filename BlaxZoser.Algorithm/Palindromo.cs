using System;

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
            bool isPalindromo = true;
            for (int i = 0; i <= length - 1; i++)
            {
                for (int j = length - 1 - i; j >= 0; j--)
                {
                    if (array[i] != array[j])
                    {
                        isPalindromo = false;
                        break;
                    }
                    break;
                }
            }
            return isPalindromo;
        }

        public Palindromo()
        {
        } 
    }
}
