using System.Collections.Generic;
using Aspose.PhoneInterpreter;
using Aspose.PhoneInterpreter.Exceptions;
using Xunit;

namespace PhoneInterpreter.Tests.Unit
{
    public class SymbolConverterTests
    {
        private readonly ISymbolConverter _sut;

        public SymbolConverterTests()
        {
            _sut = new TestSymbolConverter();
        }

        [Fact]
        public void Convert_WithKnownSymbol_ReturnsExpected()
        {
            Assert.Equal("2", _sut.Convert('a'));
        }

        [Fact]
        public void Convert_WhenSymbolIsUnknown_ThrowsUnknownSymbolException()
        {
            Assert.Throws<UnknownSymbolException>(() => _sut.Convert('x'));
        }

        private class TestSymbolConverter : SymbolConverter
        {
            public TestSymbolConverter() : base(Symbols)
            {
            }

            private static IDictionary<char, string> Symbols => new Dictionary<char, string>()
            {
                {'a', "2"},
                {'b', "22"},
                {'c', "33"}
            };
        }
    }
}
