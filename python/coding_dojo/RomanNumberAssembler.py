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

        roman_number = ""
        while number > 0:
            divisor = self.get_divisor(number)
            roman = self.mapping.get(divisor)
            roman_number = roman_number + roman
            number = number - divisor
        return self.normalize(roman_number)

    def get_divisor(self, number):
        numbers = list(self.mapping.keys())
        for i in numbers:
            if number / i >= 1:
                return i

    def normalize(self, roman_number):

        values = list(self.mapping.values())

        for i in range(2, len(values), 2):
            repeated_low = values[i] * 4
            low = values[i]
            high = values[i - 1]
            high_lord = values[i - 2]
            roman_number = roman_number.replace(high + repeated_low, low + high_lord).replace(repeated_low, low + high)

        return roman_number
