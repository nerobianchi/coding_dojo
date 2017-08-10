using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class RomanNumberConverter
    {
        private readonly Dictionary<int, string> arabicToRomanDictionary = new Dictionary<int, string>
        {
            {1000, "M"},
            {500, "D"},
            {100, "C"},
            {50, "L"},
            {10, "X"},
            {5, "V"},
            {1, "I"},
        };

        public string ConvertToRomanNumber(int number)
        {
            if (this.arabicToRomanDictionary.ContainsKey(number))
            {
                return this.arabicToRomanDictionary[number];
            }

            string romanNumber = "";
            while (number > 0)
            {
                var divisor = this.FindMaxDivisor(number);
                number -= divisor.Key;
                romanNumber = romanNumber + divisor.Value;

               romanNumber= this.Normalize(romanNumber);
            }

            
//            foreach (var pair in this.arabicToRomanDictionary)
//            {
//                if (number < pair.Key)
//                {
//                    if (number == 5 - 1) return "I" + "V";
//                    if (number == 10 - 1) return "I" + "X";
//                    if (number == 50 - 10) return "X" + "L";
//                    if (number == 100 - 10) return "X" + "C";
//                }
//            }
//            if (number < 10)
//            {
//                if (number == 5 - 1) return "I" + "V";
//                if (number == 10 - 1) return "I" + "X";
//            }
//            if (number < 100)
//            {
//                if (number == 40) return "X" + "L";
//                if (number == 90) return "X" + "C";
//            }
            return romanNumber;
        }

        private string Normalize(string romanNumber)
        {
            return romanNumber
                              .Replace("DCCCC", "CM")
                              .Replace("CCCC", "CD")
                              .Replace("LXXXX", "XC")
                              .Replace("XXXX", "XL")
                              .Replace("VIIII", "IX")
                              .Replace("IIII", "IV")
                
                ;
        }

        private KeyValuePair<int, string> FindMaxDivisor(int number)
        {
            foreach (var pair in this.arabicToRomanDictionary)
            {
                if (number/pair.Key >= 1)
                {
                    return pair;
                }
            }
            return new KeyValuePair<int, string>();
        }
    }
}