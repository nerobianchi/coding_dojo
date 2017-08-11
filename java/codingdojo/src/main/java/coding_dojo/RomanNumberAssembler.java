package coding_dojo;

import java.util.HashMap;
import java.util.Map;

public class RomanNumberAssembler {
    private Map<Integer,String> arabicToRomanMap=new HashMap<Integer, String>() ;

    public RomanNumberAssembler() {
        this.arabicToRomanMap.put(1,"I");
    }

    public String convertToRomanNumber(Integer number) {


        if(this.arabicToRomanMap.containsKey(number)) {
         return    this.arabicToRomanMap.get(number);
        }
        return "";
    }
}
