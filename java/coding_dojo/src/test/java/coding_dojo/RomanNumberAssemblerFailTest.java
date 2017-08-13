package coding_dojo;

import org.junit.Rule;
import org.junit.Test;
import org.junit.rules.ExpectedException;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;

import java.util.Arrays;
import java.util.Collection;

import static org.assertj.core.api.Assertions.assertThat;
import static org.assertj.core.api.Assertions.assertThatThrownBy;

public class RomanNumberAssemblerFailTest {

    @Test
    public void given_0_when_converting_to_roman_number_then_it_should_return_empty_string() throws Exception {
        thrown.expect(Exception.class);

        RomanNumberAssembler sut = new RomanNumberAssembler();
        sut.convertToRomanNumber(5000);
    }

    @Rule
    public ExpectedException thrown = ExpectedException.none();

    @Test
    public void given_5000_when_converting_to_roman_number_then_it_should_throw_can_not_convert_exception() throws Exception {
        thrown.expect(Exception.class);

        RomanNumberAssembler sut = new RomanNumberAssembler();
        sut.convertToRomanNumber(5000);
    }


}
