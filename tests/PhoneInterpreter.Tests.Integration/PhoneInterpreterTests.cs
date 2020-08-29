using Aspose.PhoneInterpreter;
using Xunit;

namespace PhoneInterpreter.Tests.Integration
{
    public class PhoneInterpreterTests
    {
        private readonly IPhoneInterpreter _sut;

        public PhoneInterpreterTests()
        {
            _sut = new Aspose.PhoneInterpreter.PhoneInterpreter();
        }

        [Theory]
        [InlineData("hi","44 444")]
        [InlineData("yes","999337777")]
        [InlineData("foo  bar","333666 6660 022 2777")]
        [InlineData("hello world","4433555 555666096667775553")]
        public void Convert_ReturnsExpected(string input,string expected)
        {
            Assert.Equal(expected, _sut.Interpret(input));
        }
    }
}
