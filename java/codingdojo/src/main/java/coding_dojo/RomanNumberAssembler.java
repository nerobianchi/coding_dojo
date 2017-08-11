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

        StringBuilder sb = new StringBuilder();
        while (number > 0) {
            Integer divisor = this.getDivisor(number);

            sb.append(this.arabicToRomanMap.get(divisor));

            number -= divisor;
        }
        String romanNumber = this.normalize(sb.toString());

        return romanNumber;
    }

    private Integer getDivisor(Integer number) {
        List<Integer> list = new ArrayList<>(this.arabicToRomanMap.keySet());

        for (Integer primitive : list) {
            if (number / primitive > 0) {
                return primitive;
            }
        }
        return 0;
    }

    private String normalize(String number) {

        List<String> list = new ArrayList<>(this.arabicToRomanMap.values());

        for (int i = 1; i < list.size() - 1; i = i + 2) {

            String high = list.get(i);
            String low = list.get(i + 1);
            String highLord = list.get(i - 1);
            String low_repeated = String.join("", Collections.nCopies(4, low));

            if (number.contains(high + low_repeated)) {
                number = number.replace(high + low_repeated, low + highLord);
            }
            if (number.contains(low_repeated)) {
                number = number.replace(low_repeated, low + high);
            }
        }


        return number;
    }
}
