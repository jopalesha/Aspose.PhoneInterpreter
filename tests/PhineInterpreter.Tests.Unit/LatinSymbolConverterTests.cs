using System.Collections.Generic;
using Aspose.PhoneInterpreter;
using Xunit;

namespace PhoneInterpreter.Tests.Unit
{
    public class LatinSymbolConverterTests
    {
        private readonly ISymbolConverter _sut;

        public LatinSymbolConverterTests()
        {
            _sut = new LatinSymbolConverter();
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Convert_ReturnsExpected(char symbol, string expected)
        {
            Assert.Equal(expected, _sut.Convert(symbol));
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { ' ', "0"},
                new object[] { 'a', "2"},
                new object[] { 'b', "22" },
                new object[] { 'c', "222" },
                new object[] { 'd', "3"},
                new object[] { 'e', "33"},
                new object[] { 'f', "333"},
                new object[] { 'g', "4"},
                new object[] { 'h', "44"},
                new object[] { 'i', "444"},
                new object[] { 'j', "5"},
                new object[] { 'k', "55"},
                new object[] { 'l', "555"},
                new object[] { 'm', "6"},
                new object[] { 'n', "66"},
                new object[] { 'o', "666"},
                new object[] { 'p', "7"},
                new object[] { 'q', "77"},
                new object[] { 'r', "777"},
                new object[] { 's', "7777"},
                new object[] { 't', "8"},
                new object[] { 'u', "88"},
                new object[] { 'v', "888"},
                new object[] { 'w', "9"},
                new object[] { 'x', "99"},
                new object[] { 'y', "999"},
                new object[] { 'z', "9999"},
            };
    }
}
