package coding_dojo;

import java.util.*;

public class RomanNumberAssembler {
    private Map<Integer, String> arabicToRomanMap = new LinkedHashMap<Integer, String>();

    public RomanNumberAssembler() {
        this.arabicToRomanMap.put(1000, "M");
        this.arabicToRomanMap.put(500, "D");
        this.arabicToRomanMap.put(100, "C");
        this.arabicToRomanMap.put(50, "L");
        this.arabicToRomanMap.put(10, "X");
        this.arabicToRomanMap.put(5, "V");
        this.arabicToRomanMap.put(1, "I");

    }

    public String convertToRomanNumber(Integer number) {
        if (this.arabicToRomanMap.containsKey(number)) {
            return this.arabicToRomanMap.get(number);
        }


        List<Integer> list = new ArrayList<Integer>(this.arabicToRomanMap.keySet());

        for (int i = 1; i < list.size() - 1; i = i + 2) {

            int high = list.get(i);
            String high_roman = this.arabicToRomanMap.get(high);

            int low = list.get(i+1);
            String low_roman = this.arabicToRomanMap.get(low);

            int highLord = list.get(i-1);;
            String highLord_roman = this.arabicToRomanMap.get(highLord);

            if (number == high - low) {
                return low_roman + high_roman;
            }
            if (number == highLord - low) {
                return low_roman + highLord_roman;
            }
        }
        
        return "";
    }
}
