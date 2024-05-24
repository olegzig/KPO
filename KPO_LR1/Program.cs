using System;

namespace KPO_LR1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "example string with some x characters";
            char targetChar = 'x';

            int[] indexes = getFirstAndLastIndex(inputString, targetChar);

            Console.WriteLine($"Input: {inputString}");
            Console.WriteLine($"First index of '{targetChar}': {indexes[0]}");
            Console.WriteLine($"Last index of '{targetChar}': {indexes[1]}");
            Console.ReadKey();
        }

        static int[] getFirstAndLastIndex(string input, char target)
        {
            int firstIndex = FindFirstIndex(input, target);
            int lastIndex = FindLastIndex(input, target);
            return new int[] { firstIndex, lastIndex };
        }

        static int FindFirstIndex(string input, char target)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == target)
                {
                    return i;
                }
            }
            return -1; // Если символ не найден
        }

        static int FindLastIndex(string input, char target)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == target)
                {
                    return i;
                }
            }
            return -1; // Если символ не найден
        }
    }
}
