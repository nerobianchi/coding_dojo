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


if __name__ == '__main__':
    unittest.main()
