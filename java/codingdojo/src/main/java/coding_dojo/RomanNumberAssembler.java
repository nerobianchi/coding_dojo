package coding_dojo;

import java.util.HashMap;
import java.util.Map;

public class RomanNumberAssembler {
    private Map<Integer, String> arabicToRomanMap = new HashMap<Integer, String>();

    public RomanNumberAssembler() {
        this.arabicToRomanMap.put(1, "I");
        this.arabicToRomanMap.put(5, "V");
        this.arabicToRomanMap.put(10, "X");
        this.arabicToRomanMap.put(50, "L");
        this.arabicToRomanMap.put(100, "C");
        this.arabicToRomanMap.put(500, "D");
        this.arabicToRomanMap.put(1000, "M");
    }

    public String convertToRomanNumber(Integer number) {
        if (this.arabicToRomanMap.containsKey(number)) {
            return this.arabicToRomanMap.get(number);
        }

        if (number == 4) {
            return "IV";
        }
        if (number == 9) {
            return "IX";
        }
        if (number == 40) {
            return "XL";
        }
        if (number == 90) {
            return "XC";
        }
        if (number == 400) {
            return "CD";
        }
        if (number == 900) {
            return "CM";
        }
        return "";
    }
}
