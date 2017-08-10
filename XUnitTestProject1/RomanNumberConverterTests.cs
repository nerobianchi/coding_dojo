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
}