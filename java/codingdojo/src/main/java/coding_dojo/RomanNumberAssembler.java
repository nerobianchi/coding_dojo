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
        

        if (number == 5 - 1) {
            return "I" + "V";
        }
        if (number == 10 - 1) {
            return "I" + "X";
        }
        if (number == 50 - 10) {
            return "X" + "L";
        }
        if (number == 100 - 10) {
            return "X" + "C";
        }
        if (number == 500 - 100) {
            return "C" + "D";
        }
        if (number == 1000 - 100) {
            return "C" + "M";
        }
        return "";
    }
}
