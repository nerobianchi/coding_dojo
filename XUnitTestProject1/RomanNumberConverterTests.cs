using System;
using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace XUnitTestProject1
{
    public class RomanNumberConverterTests
    {
        [Theory]
        [ClassData(typeof(PrimitiveInput))]
        public void given_primitive_numbers_for_roman_when_converting_then_success(int input, string expected)
        {
            RomanNumberConverter sut = new RomanNumberConverter();
            string actual = sut.ConvertToRomanNumber(input);
            actual.Should().Be(expected);
        }

        [Theory]
        [ClassData(typeof(SubtructedInput))]
        public void given_subtructed_numbers_for_roman_when_converting_then_success(int input, string expected)
        {
            RomanNumberConverter sut = new RomanNumberConverter();
            string actual = sut.ConvertToRomanNumber(input);
            actual.Should().Be(expected);
        }

        [Theory]
        [ClassData(typeof(ComplexInput))]
        public void given_complex_numbers_numbers_when_converting_then_it_should_be_conveted_sucessfully(int number,
            string expected)
        {
            RomanNumberConverter sut = new RomanNumberConverter();
            string actual = sut.ConvertToRomanNumber(number);

            actual.Should().Be(expected);
        }


        [Theory]
        [ClassData(typeof(SomeInput))]
        public void given_sth_numbers_numbers_when_converting_then_it_should_be_conveted_sucessfully(int number,
            string expected)
        {
            RomanNumberConverter sut = new RomanNumberConverter();
            string actual = sut.ConvertToRomanNumber(number);

            actual.Should().Be(expected);
        }
    }

    internal class PrimitiveInput : IEnumerable<object[]>
    {
        IList<object[]> data = new List<object[]>
        {
            new object[] {1, "I"},
            new object[] {5, "V"},
            new object[] {10, "X"},
            new object[] {50, "L"},
            new object[] {100, "C"},
            new object[] {500, "D"},
            new object[] {1000, "M"},
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    internal class SubtructedInput : IEnumerable<object[]>
    {
        private readonly IList<object[]> data = new List<object[]>
        {
            new object[] {4, "IV"},
            new object[] {9, "IX"},
            new object[] {40, "XL"},
            new object[] {90, "XC"},
            new object[] {400, "CD"},
            new object[] {900, "CM"},
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    internal class ComplexInput : IEnumerable<object[]>
    {
        private readonly IList<object[]> data = new List<object[]>
        {
            new object[] {1066, "MLXVI"},
            new object[] {1989, "MCMLXXXIX"},
            new object[] {89, "LXXXIX"},
            new object[] {99, "XCIX"},
            new object[] {49, "XLIX"},
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    internal class SomeInput : IEnumerable<object[]>
    {
        private readonly IList<object[]> data = new List<object[]>
        {
            new object[] {1, "I"},
            new object[] {2, "II"},
            new object[] {3, "III"},
            new object[] {4, "IV"},
            new object[] {5, "V"},
            new object[] {9, "IX"},
            new object[] {12, "XII"},
            new object[] {16, "XVI"},
            new object[] {29, "XXIX"},
            new object[] {44, "XLIV"},
            new object[] {45, "XLV"},
            new object[] {68, "LXVIII"},
            new object[] {83, "LXXXIII"},
            new object[] {97, "XCVII"},
            new object[] {99, "XCIX"},
            new object[] {500, "D"},
            new object[] {501, "DI"},
            new object[] {649, "DCXLIX"},
            new object[] {798, "DCCXCVIII"},
            new object[] {891, "DCCCXCI"},
            new object[] {1000, "M"},
            new object[] {1004, "MIV"},
            new object[] {1006, "MVI"},
            new object[] {1023, "MXXIII"},
            new object[] {2014, "MMXIV"},
            new object[] {3999, "MMMCMXCIX"},
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}