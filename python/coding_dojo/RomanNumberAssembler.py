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
        return self.mapping.get(number)
