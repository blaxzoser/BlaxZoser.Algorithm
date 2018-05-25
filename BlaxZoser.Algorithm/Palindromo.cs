namespace BlaxZoser.Algorithm
{
    //This is dev
    public class Palindromo  
    {
        public bool Is(string sentence)
        {
            int length = sentence.Length;
            char[] array = sentence.ToCharArray();
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

    }
}
