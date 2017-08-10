using System;
using System.Collections;
using System.Collections.Generic;

using FluentAssertions;

using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
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
    }
    internal class PrimitiveInput : IEnumerable<object[]>
    {
        IList<object[]> data = new List<object[]>{
                                                     new object[]{1,"I"},
                                                     new object[]{5,"V"},
                                                     new object[]{10,"X"},
                                                     new object[]{50,"L"},
                                                     new object[]{100,"C"},
                                                     new object[]{500,"D"},
                                                     new object[]{1000,"M"},
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
        private readonly IList<object[]> data = new List<object[]>{
                                                     new object[]{4,"IV"},
                                                     new object[]{9,"IX"},
                                                      new object[]{40,"XL"},
                                                     // new object[]{90,"LC"},
                                                     // new object[]{400,"CD"},
                                                     // new object[]{900,"DM"},
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
