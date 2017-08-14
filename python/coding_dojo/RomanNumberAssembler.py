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

        if number == 5 - 1:
            return "I" + "V"
        if number == 10 - 1:
            return "I" + "X"
        if number == 50 - 10:
            return "X" + "L"
        if number == 100 - 10:
            return "X" + "C"
        if number == 500 - 100:
            return "C" + "D"
        if number == 1000 - 100:
            return "C" + "M"
