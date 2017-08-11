package coding_dojo;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;

import java.util.Arrays;
import java.util.Collection;

import static org.assertj.core.api.Assertions.*;

@RunWith(Parameterized.class)
public class RomanNumberAssemblerTest {

    private Integer number;

    private String expected;

    public RomanNumberAssemblerTest(Integer number, String expected) {
        this.number = number;
        this.expected = expected;
    }

    @Test
    public void given_primitive_numbers_when_convertiong_to_roman_number_then_it_should_converted_successfully() throws Exception {
        RomanNumberAssembler sut = new RomanNumberAssembler();
        String actual = sut.convertToRomanNumber(number);

        assertThat(actual).isEqualTo(expected);
    }


    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        return Arrays.asList(new Object[][]{
                new Object[]{1,"I"}
        });
    }
}
