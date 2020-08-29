using System;
using System.Text;
using Aspose.PhoneInterpreter.Exceptions;

namespace Aspose.PhoneInterpreter
{
    public class PhoneInterpreter : IPhoneInterpreter
    {
        private readonly ISymbolConverter _symbolConverter;
        private readonly PhoneInterpreterOptions _options;

        public PhoneInterpreter() : this(new LatinSymbolConverter())
        {
        }

        public PhoneInterpreter(ISymbolConverter symbolConverter) : this(PhoneInterpreterOptions.Default, symbolConverter)
        {
        }

        public PhoneInterpreter(
            PhoneInterpreterOptions options,
            ISymbolConverter symbolConverter)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _symbolConverter = symbolConverter ?? throw new ArgumentNullException(nameof(symbolConverter));
        }

        public string Interpret(string input)
        {
            if (input.Length < _options.MinLength || input.Length > _options.MaxLength)
            {
                throw new InvalidInputException("Invalid input length");
            }

            var sb = new StringBuilder(input.Length * 4 + input.Length - 1);

            for (var i = 0; i < input.Length; i++)
            {
                var value = _symbolConverter.Convert(input[i]);
                sb.Append($"{(i != 0 && sb[sb.Length-1] - value[0] == 0 ? " " : string.Empty)}{value}");
            }

            return sb.ToString();
        }
    }
}