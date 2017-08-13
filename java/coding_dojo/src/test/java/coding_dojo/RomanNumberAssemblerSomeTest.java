package coding_dojo;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;

import java.util.Arrays;
import java.util.Collection;

import static org.assertj.core.api.Assertions.assertThat;

@RunWith(Parameterized.class)
public class RomanNumberAssemblerSomeTest {

    private Integer number;

    private String expected;

    public RomanNumberAssemblerSomeTest(Integer number, String expected) {
        this.number = number;
        this.expected = expected;
    }

    @Test
    public void given_some_numbers_when_converting_to_roman_number_then_it_should_converted_successfully() throws Exception {
        RomanNumberAssembler sut = new RomanNumberAssembler();
        String actual = sut.convertToRomanNumber(number);

        assertThat(actual).isEqualTo(expected);
    }

    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        return Arrays.asList(
                new Object[]{1, "I"},
                new Object[]{2, "II"},
                new Object[]{3, "III"},
                new Object[]{4, "IV"},
                new Object[]{5, "V"},
                new Object[]{9, "IX"},
                new Object[]{12, "XII"},
                new Object[]{16, "XVI"},
                new Object[]{29, "XXIX"},
                new Object[]{44, "XLIV"},
                new Object[]{45, "XLV"},
                new Object[]{68, "LXVIII"},
                new Object[]{83, "LXXXIII"},
                new Object[]{97, "XCVII"},
                new Object[]{99, "XCIX"},
                new Object[]{500, "D"},
                new Object[]{501, "DI"},
                new Object[]{649, "DCXLIX"},
                new Object[]{798, "DCCXCVIII"},
                new Object[]{891, "DCCCXCI"},
                new Object[]{1000, "M"},
                new Object[]{1004, "MIV"},
                new Object[]{1006, "MVI"},
                new Object[]{1023, "MXXIII"},
                new Object[]{2014, "MMXIV"},
                new Object[]{3999, "MMMCMXCIX"}
        );
    }
}
