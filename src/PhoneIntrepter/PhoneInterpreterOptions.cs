using System;

namespace Aspose.PhoneInterpreter
{
    public class PhoneInterpreterOptions
    {
        public PhoneInterpreterOptions(int minLength, int maxLength)
        {
            if (minLength < 0)
            {
                throw new ArgumentException("Invalid min length", nameof(minLength));
            }

            if (minLength > maxLength || maxLength > 1000)
            {
                throw new ArgumentException("Invalid max length", nameof(MaxLength));
            }

            MinLength = minLength;
            MaxLength = maxLength;
        }

        public int MinLength { get; }

        public int MaxLength { get; }

        public static PhoneInterpreterOptions Default => new PhoneInterpreterOptions(1, 1000);
    }
}