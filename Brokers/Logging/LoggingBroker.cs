using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Register.Brokers.Logging
{
    internal class LoggingBroker : ILoggingBroker
    {
        public void LogError(string userMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(userMessage);
            Console.ResetColor();
        }

        public void LogInformation(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}