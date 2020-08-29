using System;
using System.Collections.Generic;
using Aspose.PhoneInterpreter.Exceptions;

namespace Aspose.PhoneInterpreter
{
    public abstract class SymbolConverter : ISymbolConverter
    {
        private readonly IDictionary<char, string> _symbols;

        protected SymbolConverter(IDictionary<char, string> symbols)
        {
            if (symbols == null || symbols.Count == 0)
            {
                throw new ArgumentException("Dictionary is null or empty", nameof(symbols));
            }

            _symbols = symbols;
        }

        public virtual string Convert(char symbol)
        {
            if (!_symbols.TryGetValue(symbol, out var result))
            {
                throw new UnknownSymbolException($"Unknown symbol {symbol}");
            }

            return result;
        }
    }
}