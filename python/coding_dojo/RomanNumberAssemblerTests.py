import unittest
from unittest import TestCase

from assertpy import assert_that
from nose_parameterized import parameterized

from RomanNumberAssembler import RomanNumberAssembler


class RomanNumberAssemblerTests(TestCase):
    @parameterized.expand([
        (1, "I"),
        (5, "V"),
        (10, "X"),
        (50, "L"),
        (100, "C"),
        (500, "D"),
        (1000, "M"),
    ])
    def test_given_primitive_numbers_when_converting_to_roman_number_then_it_should_be_converted_successfully(self,
                                                                                                              number,
                                                                                                              expected):
        sut = RomanNumberAssembler()
        actual = sut.convert(number)
        assert_that(expected).is_equal_to(actual)

    @parameterized.expand([
        (4, "IV"),
        (9, "IX"),
        (40, "XL"),
        (90, "XC"),
        (400, "CD"),
        (900, "CM"),
    ])
    def test_given_subtracted_numbers_when_converting_to_roman_number_then_it_should_converted_successfully(self,
                                                                                                            number,
                                                                                                            expected):
        sut = RomanNumberAssembler()
        actual = sut.convert(number)
        assert_that(expected).is_equal_to(actual)

    @parameterized.expand([
        (1066, "MLXVI"),
        (1989, "MCMLXXXIX"),
        (89, "LXXXIX"),
        (99, "XCIX"),
        (49, "XLIX"),
        (4999, "MMMMCMXCIX"),
        (4000, "MMMM")
    ])
    def test_given_complex_numbers_when_converting_to_roman_number_then_it_should_converted_successfully(self,
                                                                                                         number,
                                                                                                         expected):
        sut = RomanNumberAssembler()
        actual = sut.convert(number)
        assert_that(expected).is_equal_to(actual)

    @parameterized.expand([
        (1, "I"),
        (2, "II"),
        (3, "III"),
        (4, "IV"),
        (5, "V"),
        (9, "IX"),
        (12, "XII"),
        (16, "XVI"),
        (29, "XXIX"),
        (44, "XLIV"),
        (45, "XLV"),
        (68, "LXVIII"),
        (83, "LXXXIII"),
        (97, "XCVII"),
        (99, "XCIX"),
        (500, "D"),
        (501, "DI"),
        (649, "DCXLIX"),
        (798, "DCCXCVIII"),
        (891, "DCCCXCI"),
        (1000, "M"),
        (1004, "MIV"),
        (1006, "MVI"),
        (1023, "MXXIII"),
        (2014, "MMXIV"),
        (3999, "MMMCMXCIX")
    ])
    def test_given_some_numbers_when_converting_to_roman_number_then_it_should_converted_successfully(self,
                                                                                                      number,
                                                                                                      expected):
        sut = RomanNumberAssembler()
        actual = sut.convert(number)
        assert_that(expected).is_equal_to(actual)


if __name__ == '__main__':
    unittest.main()
