package coding_dojo;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;

import java.util.Arrays;
import java.util.Collection;

import static org.assertj.core.api.Assertions.assertThat;

@RunWith(Parameterized.class)
public class RomanNumberAssemblerComplexTest {

    private Integer number;

    private String expected;

    public RomanNumberAssemblerComplexTest(Integer number, String expected) {
        this.number = number;
        this.expected = expected;
    }

    @Test
    public void given_complex_numbers_when_converting_to_roman_number_then_it_should_converted_successfully() throws Exception {
        RomanNumberAssembler sut = new RomanNumberAssembler();
        String actual = sut.convertToRomanNumber(number);

        assertThat(actual).isEqualTo(expected);
    }


    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        return Arrays.asList(
                new Object[]{1066, "MLXVI"},
                new Object[]{1989, "MCMLXXXIX"},
                new Object[]{89, "LXXXIX"},
                new Object[]{99, "XCIX"},
                new Object[]{49, "XLIX"});
    }
}
