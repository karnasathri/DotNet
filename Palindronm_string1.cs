using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    class Palindronm_string1
    {
        static void Main()
        {
            string word = "Malayalam";

            bool isPalindrome = IsPalindrome(word);

            if (isPalindrome)
                Console.WriteLine("The word '{0}' is a palindrome.", word);
            else
                Console.WriteLine("The word '{0}' is not a palindrome.", word);
            Console.ReadLine();
        }
        static bool IsPalindrome(string word)
        {
            int length = word.Length;
           
            for (int i = 0; i < length ; i++)
            {
                if (word[i] != word[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
