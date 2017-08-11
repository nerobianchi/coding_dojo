package coding_dojo;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;

import java.util.Arrays;
import java.util.Collection;

import static org.assertj.core.api.Assertions.assertThat;

@RunWith(Parameterized.class)
public class RomanNumberAssemblerSubstructedTest {

    private Integer number;

    private String expected;

    public RomanNumberAssemblerSubstructedTest(Integer number, String expected) {
        this.number = number;
        this.expected = expected;
    }

    @Test
    public void given_substructed_numbers_when_converting_to_roman_number_then_it_should_converted_successfully() throws Exception {
        RomanNumberAssembler sut = new RomanNumberAssembler();
        String actual = sut.convertToRomanNumber(number);

        assertThat(actual).isEqualTo(expected);
    }


    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        return Arrays.asList(
                new Object[] {4, "IV"},
                new Object[] {9, "IX"},
                new Object[] {40, "XL"},
                new Object[] {90, "XC"},
                new Object[] {400, "CD"},
                new Object[] {900, "CM"});
    }
}
