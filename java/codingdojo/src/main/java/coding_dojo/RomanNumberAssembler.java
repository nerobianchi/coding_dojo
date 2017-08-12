package coding_dojo;

import java.util.*;

class RomanNumberAssembler {
    private Map<Integer, String> arabicToRomanMap = new LinkedHashMap<>();

    RomanNumberAssembler() {
        this.arabicToRomanMap.put(1000, "M");
        this.arabicToRomanMap.put(500, "D");
        this.arabicToRomanMap.put(100, "C");
        this.arabicToRomanMap.put(50, "L");
        this.arabicToRomanMap.put(10, "X");
        this.arabicToRomanMap.put(5, "V");
        this.arabicToRomanMap.put(1, "I");
    }

    String convertToRomanNumber(Integer number) throws Exception {
        if (this.arabicToRomanMap.containsKey(number)) {
            return this.arabicToRomanMap.get(number);
        }

        StringBuilder sb = new StringBuilder();

        if (number <= 0 || number >= 5000) {
            throw new Exception("Can not be converted !!!");
        }

        while (number > 0) {
            Integer divisor = this.getDivisor(number);

            sb.append(this.arabicToRomanMap.get(divisor));

            number -= divisor;
        }

        return this.normalize(sb.toString());
    }

    private Integer getDivisor(Integer number) {
        List<Integer> list = new ArrayList<>(this.arabicToRomanMap.keySet());

//        int value = 0;
//
//        for (Integer primitive : list)
//            if (number / primitive > 0) {
//                value = primitive;
//                break;
//            }
//
//        return value;

        for (Integer primitive : list)
            if (number / primitive > 0) {
                return primitive;
            }

        return 0;
    }

    private String normalize(String number) {

        List<String> list = new ArrayList<>(this.arabicToRomanMap.values());

        for (int i = 1; i < list.size() - 1; i = i + 2) {
        /*
            ("DCCCC", "CM")
            ("CCCC", "CD")
            ("LXXXX", "XC")
            ("XXXX", "XL")
            ("VIIII", "IX")
            ("IIII", "IV")
        */
            String high = list.get(i);
            String low = list.get(i + 1);
            String highLord = list.get(i - 1);
            String low_repeated = String.join("", Collections.nCopies(4, low));

            number = number.replace(high + low_repeated, low + highLord);
            number = number.replace(low_repeated, low + high);
        }

        return number;
    }
}
