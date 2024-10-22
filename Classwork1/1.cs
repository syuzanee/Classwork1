using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "madam";
        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine($"Is the string \"{input}\" a palindrome? {isPalindrome}");
    }

    static bool IsPalindrome(string input)
    {

        string sanitizedInput = input.Replace(" ", "").ToLower();

        int length = sanitizedInput.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (sanitizedInput[i] != sanitizedInput[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}