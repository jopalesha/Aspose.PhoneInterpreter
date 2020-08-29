using Aspose.PhoneInterpreter;
using Aspose.PhoneInterpreter.Exceptions;
using Moq;
using Xunit;

namespace PhoneInterpreter.Tests.Unit
{
    public class PhoneInterpreterTests
    {  
        private readonly IPhoneInterpreter _sut;

        public PhoneInterpreterTests()
        {
            var symbolConverter = new Mock<ISymbolConverter>(MockBehavior.Strict);
            symbolConverter.Setup(it => it.Convert('a')).Returns("2");
            symbolConverter.Setup(it => it.Convert(' ')).Returns("0");

            var options = new PhoneInterpreterOptions(2, 4);
            _sut = new Aspose.PhoneInterpreter.PhoneInterpreter(options, symbolConverter.Object);
        }

        [Theory]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("aaaaa")]
        public void Interpret_WithInvalidLength_ThrowsInvalidInputException(string input)
        {
            Assert.Throws<InvalidInputException>(() => _sut.Interpret(input));
        }

        [Theory]
        [InlineData("a a", "202")]
        [InlineData("aa", "2 2")]
        public void Interpret_ReturnsExpected(string input, string expected)
        {
            Assert.Equal(expected, _sut.Interpret(input));
        }
    }
}
