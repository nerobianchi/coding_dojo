class RomanNumberAssembler:
    mapping = {
        1: "I",
        5: "V",
        10: "X",
        50: "L",
        100: "C",
        500: "D",
        1000: "M"
    }

    def convert(self, number):
        roman_mapping = self.mapping.get(number)
        if roman_mapping is not None:
            return roman_mapping

        if number >= 100:
            return self.get_substructed_thousands(number)
        if number >= 10:
            return self.get_substructed_hundreds(number)
        if number >= 1:
            return self.get_substructed_tens(number, 5, 1, 10, "V", "I", "X")

    def get_substructed_tens(self, number, high, low, high_lord, high_roman, low_roman, high_lord_roman):
        if number == high - low:
            return low_roman + high_roman
        if number == high_lord - low:
            return low_roman + high_lord_roman

    def get_substructed2(self, number):
        high = 5
        high_roman = "V"
        low = 1
        low_roman = "I"
        high_lord = 10
        high_lord_roman = "X"

        if number == high - low:
            return low_roman + high_roman
        if number == high_lord - low:
            return low_roman + high_lord_roman

    def get_substructed_hundreds(self, number):
        if number == 50 - 10:
            return "X" + "L"
        if number == 100 - 10:
            return "X" + "C"

    def get_substructed_thousands(self, number):
        if number == 500 - 100:
            return "C" + "D"
        if number == 1000 - 100:
            return "C" + "M"
