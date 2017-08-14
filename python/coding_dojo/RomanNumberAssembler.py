class RomanNumberAssembler:
    mapping = {
        1000: "M",
        500: "D",
        100: "C",
        50: "L",
        10: "X",
        5: "V",
        1: "I"
    }

    def convert(self, number):
        roman_mapping = self.mapping.get(number)
        if roman_mapping is not None:
            return roman_mapping

        return self.try_subtracted(number)

    def try_subtracted(self, number):
        numbers = list(self.mapping.keys())

        for i in range(2, len(numbers), 2):
            low = numbers[i]
            high = numbers[i - 1]
            high_lord = numbers[i - 2]
            high_roman = self.mapping.get(high)
            low_roman = self.mapping.get(low)
            high_lord_roman = self.mapping.get(high_lord)

            if number >= low:
                return self.get_subtracted(number, high, low, high_lord, high_roman, low_roman, high_lord_roman)

    def get_subtracted(self, number, high, low, high_lord, high_roman, low_roman, high_lord_roman):
        if number == high - low:
            return low_roman + high_roman
        if number == high_lord - low:
            return low_roman + high_lord_roman
