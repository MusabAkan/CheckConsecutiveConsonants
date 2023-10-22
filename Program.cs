using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir metin ifadesi girin:");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            bool hasConsecutiveConsonants = CheckConsecutiveConsonants(word);
            Console.Write(hasConsecutiveConsonants + " ");
        }
    }

    static bool CheckConsecutiveConsonants(string word)
    {
        for (int i = 0; i < word.Length - 1; i++)
        {
            char currentChar = char.ToLower(word[i]);
            char nextChar = char.ToLower(word[i + 1]);

            if (IsConsonant(currentChar) && IsConsonant(nextChar))
            {
                return true;
            }
        }

        return false;
    }

    static bool IsConsonant(char character)
    {
        char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        return Array.Exists(consonants, c => c == character);
    }
}