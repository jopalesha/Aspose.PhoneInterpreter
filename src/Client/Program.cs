using System;
using System.Collections.Generic;
using Aspose.PhoneInterpreter;
using Aspose.PhoneInterpreter.Exceptions;

namespace Client
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Input number of cases: ");
            var count = Convert.ToInt32(Console.ReadLine());
            var interpreter = new PhoneInterpreter();
            var values = new List<string>();

            for (var i = 0; i < count; i++)
            {
                values.Add(Console.ReadLine());
            }

            Console.WriteLine("\n Result:");
            var counter = 1;

            foreach (var value in values)
            {
                string result;
                try
                {
                    result = interpreter.Interpret(value);
                }
                catch (PhoneInterpreterException e)
                {
                    result = $"Invalid input. {e.Message}";
                }
                Console.WriteLine($"Case #{counter++}: {result}");
            }


            Console.ReadKey();
        }
    }

}
