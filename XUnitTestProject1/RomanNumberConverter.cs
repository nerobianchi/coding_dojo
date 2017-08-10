using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class RomanNumberConverter
    {
        private readonly Dictionary<int, string> arabicToRomanDictionary = new Dictionary<int, string>();

        public RomanNumberConverter()
        {
            this.arabicToRomanDictionary.Add(1, "I");
            this.arabicToRomanDictionary.Add(5, "V");
            this.arabicToRomanDictionary.Add(10, "X");
            this.arabicToRomanDictionary.Add(50, "L");
            this.arabicToRomanDictionary.Add(100, "C");
            this.arabicToRomanDictionary.Add(500, "D");
            this.arabicToRomanDictionary.Add(1000, "M");
        }
        public string ConvertToRomanNumber(int input)
        {
            if (this.arabicToRomanDictionary.ContainsKey(input)) { return this.arabicToRomanDictionary[input]; }

            if (input == 4) return "I" + "V";
            if (input == 9) return "I" + "X";
            if (input == 40) return "X" + "L";
            if (input == 90) return "X" + "C";

            return string.Empty;
        }
    }
}