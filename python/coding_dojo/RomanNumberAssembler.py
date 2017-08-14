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

        if number == 4:
            return "IV"
        if number == 9:
            return "IX"
        if number == 40:
            return "XL"
        if number == 90:
            return "XC"
        if number == 400:
            return "CD"
        if number == 900:
            return "CM"
