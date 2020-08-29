using Aspose.PhoneInterpreter.Exceptions;

namespace Aspose.PhoneInterpreter
{
    public interface IPhoneInterpreter
    {
        /// <summary>
        /// Interpret message to mobile input
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Result string</returns>
        /// <exception cref="PhoneInterpreterException">Thrown when input data is invalid</exception>
        string Interpret(string input);
    }
}