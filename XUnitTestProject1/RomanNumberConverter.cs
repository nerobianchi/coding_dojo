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
            }
            romanNumber = this.Normalize(romanNumber);

            return romanNumber;
        }

        private string Normalize(string romanNumber)
        {
//            return romanNumber
//                              .Replace("DCCCC", "CM")
//                              .Replace("CCCC", "CD")
//                              .Replace("LXXXX", "XC")
//                              .Replace("XXXX", "XL")
//                              .Replace("VIIII", "IX")
//                              .Replace("IIII", "IV")
//                ;
//            
            List<string> list = new List<string>(this.arabicToRomanDictionary.Values);
            for (int i = 1; i < list.Count; i = i + 2)
            {
                var high = list[i];
                var low = list[i + 1];
                var repeated = "".PadRight(4, low.ToCharArray()[0]);
                var highLord = list[i - 1];
                romanNumber = romanNumber.Replace(high + repeated, low + highLord);
                romanNumber = romanNumber.Replace(repeated, low + high);
            }
            return romanNumber;
        }

        private KeyValuePair<int, string> FindMaxDivisor(int number)
        {
            foreach (var pair in this.arabicToRomanDictionary)
            {
                if (number / pair.Key >= 1)
                {
                    return pair;
                }
            }
            return new KeyValuePair<int, string>();
        }
    }
}