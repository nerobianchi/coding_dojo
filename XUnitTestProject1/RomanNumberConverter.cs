using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class RomanNumberConverter
    {
        private readonly Dictionary<int, string> arabicToRomanDictionary = new Dictionary<int, string>
        {
            {1, "I"},
            {5, "V"},
            {10, "X"},
            {50, "L"},
            {100, "C"},
            {500, "D"},
            {1000, "M"}
        };

        public string ConvertToRomanNumber(int input)
        {
            if (this.arabicToRomanDictionary.ContainsKey(input))
            {
                return this.arabicToRomanDictionary[input];
            }

            if (input == 4) return "I" + "V";
            if (input == 9) return "I" + "X";
            if (input == 40) return "X" + "L";
            if (input == 90) return "X" + "C";

            return string.Empty;
        }
    }
}