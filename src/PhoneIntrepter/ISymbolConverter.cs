using Aspose.PhoneInterpreter.Exceptions;

namespace Aspose.PhoneInterpreter
{
    public interface ISymbolConverter
    {
        /// <summary>
        /// Converts symbol to mobile input
        /// </summary>
        /// <param name="symbol">Symbol for conversion</param>
        /// <returns>Mobile input</returns>
        /// <exception cref="UnknownSymbolException">Thrown when symbol is unknown</exception>
        string Convert(char symbol);
    }
}