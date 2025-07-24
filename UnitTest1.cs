using Xunit;
using MyTestAssignment;

namespace MyTestAssignment.Tests
{
    public class OldPhonePadTests
    {
        [Theory]
        [InlineData("8 88777444666*664#", "TURING")] // First assertion
        [InlineData("227*#", "B")] // Backspace assertion
        [InlineData("33#", "E")] // Regular assertion
        [InlineData("444777666 660 777766633389277733#", "IRON SOFTWARE")] // "IRON SOFTWARE" Assertion
        [InlineData("", "")] // Empty input assertion
        [InlineData("222222#", "C")] // Circle back logic assertion 

        public void OldPhonePad_VariousInputs_ReturnsExpectedOutput(string input, string expected)
        {
            var result = Program.OldPhonePad(input);
            Assert.Equal(expected, result);
        }
    }
}
