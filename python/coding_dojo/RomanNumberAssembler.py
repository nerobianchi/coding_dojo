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

        return self.try_subtracted(number)

    def get_subtracted(self, number, high, low, high_lord, high_roman, low_roman, high_lord_roman):
        if number == high - low:
            return low_roman + high_roman
        if number == high_lord - low:
            return low_roman + high_lord_roman

    def try_subtracted(self, number):
        if number >= 100:
            return self.get_subtracted(number, 500, 100, 1000, "D", "C", "M")
        if number >= 10:
            return self.get_subtracted(number, 50, 10, 100, "L", "X", "C")
        if number >= 1:
            return self.get_subtracted(number, 5, 1, 10, "V", "I", "X")

