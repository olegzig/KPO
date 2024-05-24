using System;
using System.Text;

namespace KPO_LR2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = { "example string with some x characters", "another string with x here and there" };
            string charNeedToBeDoubled = "x";
            string concatenatedString;

            int bufferSize = ModifyAndConcatenateStrings(out concatenatedString, charNeedToBeDoubled, inputStrings);

            Console.WriteLine($"Concatenated string: {concatenatedString}");
            Console.WriteLine($"Buffer size: {bufferSize}");
            Console.ReadKey();
        }

        static int ModifyAndConcatenateStrings(out string result,string charNeedToBeDoubled, params string[] strings)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string str in strings)
            {
                string modifiedString = str.Replace(charNeedToBeDoubled, charNeedToBeDoubled + charNeedToBeDoubled);
                sb.Append(modifiedString).Append(";");
            }

            // Уменьшить ёмкость буфера до реального размера полученной строки
            sb.Length--; // Удаляем последний добавленный разделитель ';'

            result = sb.ToString();

            return result.Length; // Возвращаем размер буфера
        }
    }
}
