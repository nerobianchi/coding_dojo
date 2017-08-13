import unittest
from unittest import TestCase

from assertpy import assert_that
from nose_parameterized import parameterized

from RomanNumberAssembler import RomanNumberAssembler

param_list = [(1, "I"), (5, "V")]


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
    def test_primitives(self, number, expected):
        sut = RomanNumberAssembler()
        actual = sut.convert(number)
        assert_that(expected).is_equal_to(actual)


# test_given_primitive_numbers_when_converting_to_roman_number_then_it_should_be_converted_successfully
if __name__ == '__main__':
    unittest.main()

# param_list2 = [('a', 'a'), ('c', 'c'), ('b', 'b')]
#
#
# def test_generator():
#     for params in param_list2:
#         yield check_em, params[0], params[1]
#
#
# def check_em(a, b):
#     assert a == b
